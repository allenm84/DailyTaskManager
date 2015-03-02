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
  public partial class EditCategoryDialog : BaseForm
  {
    public EditCategoryDialog(Category category)
    {
      InitializeComponent();
      txtName.DataBindings.Add("Text", category, "Name");
    }
  }
}
