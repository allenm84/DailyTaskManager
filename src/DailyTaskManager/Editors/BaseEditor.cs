using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTaskManager
{
  public abstract class BaseEditor
  {
    private Lazy<string> editorKey;
    public virtual string Key { get { return editorKey.Value; } }

    public abstract string Caption { get; }
    public virtual int Count { get { return list.Count; } }

    private IBindingList list;
    public IBindingList List { get { return list; } }

    public event EventHandler Changed;

    public BaseEditor()
    {
      editorKey = new Lazy<string>(() => GetType().Name);
    }

    protected void SetList(IBindingList list)
    {
      this.list = list;
      this.list.ListChanged += list_ListChanged;
    }

    private void list_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (Changed != null)
      {
        Changed(this, EventArgs.Empty);
      }
    }

    public void Setup(GridView grid)
    {
      DoDataBind(grid);
    }

    protected abstract void DoDataBind(GridView grid);

    public abstract void AddNew(IWin32Window owner);
    public abstract void EditItem(IWin32Window owner, object item);

    public virtual void Remove(IEnumerable<object> selected)
    {
      foreach (var o in selected)
      {
        list.Remove(o);
      }
    }

    public virtual void Clear()
    {
      list.Clear();
    }

    public virtual bool CanAdd()
    {
      return true;
    }

    public virtual bool IsOKToClose(out string okClickCloseError)
    {
      okClickCloseError = null;
      return true;
    }
  }
}
