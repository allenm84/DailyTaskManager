using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DailyTaskManager
{
  public partial class BaseForm : XtraForm
  {
    private bool readSizeInLoad = true;
    private Lazy<string> dialogKey;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual string DialogKey { get { return dialogKey.Value; } }

    public BaseForm()
    {
      dialogKey = new Lazy<string>(() => GetType().Name);

      InitializeComponent();
      if (!SaveFile.IsLoaded)
      {
        readSizeInLoad = false;
        SaveFile.Loaded += SaveFile_Loaded;
      }
    }

    private void ReadSize()
    {
      if (InvokeRequired)
      {
        Invoke(new Action(ReadSize));
      }
      else
      {
        var sizes = SaveFile.Instance.Dialogs;
        Size size;
        if (sizes.TryGetValue(DialogKey, out size))
        {
          Size = size;
        }
        SizeChanged += BaseForm_SizeChanged;
      }
    }

    private void WriteSize()
    {
      var sizes = SaveFile.Instance.Dialogs;
      sizes[DialogKey] = Size;
    }

    private void SaveFile_Loaded(object sender, EventArgs e)
    {
      SaveFile.Loaded -= SaveFile_Loaded;
      ReadSize();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (readSizeInLoad)
      {
        ReadSize();
      }
    }

    private void BaseForm_SizeChanged(object sender, EventArgs e)
    {
      WriteSize();
    }
  }
}