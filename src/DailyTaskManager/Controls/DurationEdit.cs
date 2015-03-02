using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DailyTaskManager
{
  public partial class DurationEdit : XtraUserControl
  {
    public DurationEdit()
    {
      InitializeComponent();
    }

    public void BindTo(Duration duration)
    {
      numMinutes.DataBindings.Clear();
      numMinutes.DataBindings.Add("Value", duration, "Minutes");

      numHours.DataBindings.Clear();
      numHours.DataBindings.Add("Value", duration, "Hours");

      numDays.DataBindings.Clear();
      numDays.DataBindings.Add("Value", duration, "Days");

      numWeeks.DataBindings.Clear();
      numWeeks.DataBindings.Add("Value", duration, "Weeks");
    }
  }
}
