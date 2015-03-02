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
  public partial class TaskItemListDialog : BaseForm
  {
    public TaskItemListDialog(IList<TaskItem> tasks, string message)
    {
      InitializeComponent();

      lstTasks.DataSource = tasks;
      lstTasks.DisplayMember = "Name";
      lstTasks.ValueMember = "ID";

      lblMessage.Text = message;
    }
  }
}
