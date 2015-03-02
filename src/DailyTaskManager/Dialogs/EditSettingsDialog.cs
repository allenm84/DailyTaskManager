using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTaskManager
{
  public partial class EditSettingsDialog : BaseForm
  {
    public float Volume
    {
      get { return CalculatePercent(tbVolume.Value, tbVolume.Properties.Minimum, tbVolume.Properties.Maximum); }
      set { tbVolume.Value = (int)CalculateValue(value, tbVolume.Properties.Minimum, tbVolume.Properties.Maximum); }
    }

    public EditSettingsDialog()
    {
      InitializeComponent();
    }

    static float CalculateValue(float percent, float min, float max)
    {
      return (min * (-percent)) + min + (max * percent);
    }

    static float CalculatePercent(float value, float min, float max)
    {
      return (value - min) / (max - min);
    }

    private void UpdateDisplay()
    {
      layoutControlVolume.Text = string.Format("{0:P1}", Volume);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateDisplay();
    }

    private void tbVolume_ValueChanged(object sender, EventArgs e)
    {
      UpdateDisplay();
    }
  }
}
