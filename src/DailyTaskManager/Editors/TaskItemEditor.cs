using System;
using System.Collections.Generic;
using System.Common.References;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DailyTaskManager
{
  public class TaskItemEditor : BaseEditor
  {
    private BindingList<TaskItem> tasks;
    private BindingList<Category> categories;

    public override string Caption
    {
      get
      {
        return "All Tasks";
      }
    }

    public TaskItemEditor()
    {
      this.categories = new BindingList<Category>(SaveFile.Instance.Categories);
      this.tasks = new BindingList<TaskItem>();
      foreach (TaskItem current in SaveFile.Instance.Tasks)
      {
        this.tasks.Add(current.Duplicate());
      }
      base.SetList(this.tasks);
    }

    protected override void DoDataBind(GridView grid)
    {
      GridColumn gridColumn = grid.Columns.AddField("Name");
      gridColumn.Visible = true;
      gridColumn.SortOrder = ColumnSortOrder.Ascending;
      RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
      repositoryItemLookUpEdit.DataSource = this.categories;
      repositoryItemLookUpEdit.DisplayMember = "Name";
      repositoryItemLookUpEdit.ValueMember = "ID";
      GridColumn gridColumn2 = grid.Columns.AddField("CategoryID");
      gridColumn2.Visible = true;
      gridColumn2.ColumnEdit = repositoryItemLookUpEdit;
      gridColumn2.Caption = "Category";
      grid.Columns.AddField("Span").Visible = true;
      RepositoryItemLookUpEdit repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
      Factory.FillImportanceLookUpEdit(repositoryItemLookUpEdit2);
      GridColumn gridColumn3 = grid.Columns.AddField("Importance");
      gridColumn3.Visible = true;
      gridColumn3.ColumnEdit = repositoryItemLookUpEdit2;
      gridColumn3.Width = 40;
      gridColumn3.OptionsColumn.AllowSize = false;
      gridColumn3.OptionsColumn.FixedWidth = true;
      grid.OptionsView.ShowColumnHeaders = false;
      grid.OptionsView.ShowIndicator = false;
      grid.GridControl.DataSource = this.tasks;
      grid.BestFitColumns();
    }

    public override void AddNew(IWin32Window owner)
    {
      TaskItem taskItem = new TaskItem
      {
        ID = Tuid.Next,
        Name = "<New Task>",
        Span = new Duration()
      };
      using (EditTaskItemDialog editTaskItemDialog = new EditTaskItemDialog(taskItem, this.categories))
      {
        editTaskItemDialog.Text = "Add New Task";
        if (editTaskItemDialog.ShowDialog(owner) == DialogResult.OK)
        {
          this.tasks.Add(taskItem);
        }
      }
    }

    public override void EditItem(IWin32Window owner, object item)
    {
      TaskItem taskItem = item as TaskItem;
      if (taskItem == null)
      {
        return;
      }
      TaskItem taskItem2 = taskItem.Duplicate();
      using (EditTaskItemDialog editTaskItemDialog = new EditTaskItemDialog(taskItem2, this.categories))
      {
        editTaskItemDialog.Text = string.Format("Edit {0}", taskItem.Name);
        if (editTaskItemDialog.ShowDialog(owner) == DialogResult.OK)
        {
          int num = this.tasks.IndexOf(taskItem);
          this.tasks[num] = taskItem2;
          this.tasks.ResetItem(num);
        }
      }
    }
  }
}
