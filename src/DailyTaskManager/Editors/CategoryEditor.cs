using System;
using System.Collections.Generic;
using System.Common.References;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DailyTaskManager
{
  public class CategoryEditor : BaseEditor
  {
    private BindingList<Category> categories;

    public override string Caption
    {
      get
      {
        return "Categories";
      }
    }

    public CategoryEditor()
    {
      this.categories = new BindingList<Category>();
      foreach (Category current in SaveFile.Instance.Categories)
      {
        this.categories.Add(current.Duplicate());
      }
      base.SetList(this.categories);
    }

    protected override void DoDataBind(GridView grid)
    {
      GridColumn gridColumn = grid.Columns.AddField("Name");
      gridColumn.SortOrder = ColumnSortOrder.Ascending;
      gridColumn.Visible = true;
      grid.OptionsView.ShowColumnHeaders = false;
      grid.OptionsView.ShowIndicator = false;
      grid.GridControl.DataSource = this.categories;
    }

    public static Category CreateCategory(IWin32Window owner)
    {
      Category category = new Category
      {
        ID = Tuid.Next,
        Name = "<New>"
      };
      using (EditCategoryDialog editCategoryDialog = new EditCategoryDialog(category))
      {
        editCategoryDialog.Text = "New Category";
        if (editCategoryDialog.ShowDialog(owner) == DialogResult.OK)
        {
          return category;
        }
      }
      return null;
    }

    public override void AddNew(IWin32Window owner)
    {
      Category category = CategoryEditor.CreateCategory(owner);
      if (category != null)
      {
        this.categories.Add(category);
      }
    }

    public override void EditItem(IWin32Window owner, object item)
    {
      Category category = item as Category;
      if (category == null)
      {
        return;
      }
      Category category2 = category.Duplicate();
      using (EditCategoryDialog editCategoryDialog = new EditCategoryDialog(category2))
      {
        editCategoryDialog.Text = string.Format("Edit {0}", category.Name);
        if (editCategoryDialog.ShowDialog(owner) == DialogResult.OK)
        {
          int num = this.categories.IndexOf(category);
          this.categories[num] = category2;
          this.categories.ResetItem(num);
        }
      }
    }
  }
}
