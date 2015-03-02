using DevExpress.XtraEditors.Controls;
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
  public partial class EditTaskItemDialog : BaseForm
  {
    private TaskItem task;
    private IList<Category> categories;

    public EditTaskItemDialog(TaskItem task, IList<Category> categories)
    {
      this.task = task;
      this.categories = categories;

      InitializeComponent();
      InitializeSearchLookUp(categories);

      txtName.DataBindings.Add("Text", task, "Name");
      cboCategories.DataBindings.Add("EditValue", task, "CategoryID");
      durationEdit.BindTo(task.Span);
      rdgImportance.EditValue = (int)task.Importance;
      rdgImportance.EditValueChanged += rdgImportance_EditValueChanged;
    }

    private void InitializeSearchLookUp(IList<Category> categories)
    {
      var searchLookUp = cboCategories.Properties;
      searchLookUp.DataSource = categories;
      searchLookUp.DisplayMember = "Name";
      searchLookUp.ValueMember = "ID";
      searchLookUp.PopulateViewColumns();

      var view = searchLookUp.View;
      view.Columns["ID"].Visible = false;
    }

    private void cboCategories_AddNewValue(object sender, AddNewValueEventArgs e)
    {
      var category = CategoryEditor.CreateCategory(this);
      if (category != null)
      {
        categories.Add(category);
        e.Cancel = false;
        e.NewValue = category.ID;
      }
      else
      {
        e.Cancel = true;
      }
    }

    private void rdgImportance_EditValueChanged(object sender, EventArgs e)
    {
      task.Importance = (Importance)rdgImportance.EditValue;
    }
  }
}
