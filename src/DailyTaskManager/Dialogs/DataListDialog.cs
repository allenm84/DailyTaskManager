using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
  public partial class DataListDialog : BaseForm
  {
    private bool cancelClose = false;
    private BaseEditor editor;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override string DialogKey
    {
      get { return editor.Key; }
    }

    public DataListDialog(BaseEditor editor)
    {
      this.editor = editor;
      InitializeComponent();
      Text = editor.Caption;
      editor.Changed += editor_Changed;
    }

    private void UpdateButtons()
    {
      int selection = gridViewList.SelectedRowsCount;
      btnAdd.Enabled = editor.CanAdd();
      btnEdit.Enabled = selection == 1;
      btnRemove.Enabled = selection > 0;
      btnClear.Enabled = editor.Count > 0;
    }

    private void EditByHitInfo(GridHitInfo info)
    {
      if (info.InRow || info.InRowCell)
      {
        EditByRowHandle(info.RowHandle);
      }
    }

    private void EditByRowHandle(int rowHandle)
    {
      editor.EditItem(this, gridViewList.GetRow(rowHandle));
    }

    protected override void OnLoad(EventArgs e)
    {
      editor.Setup(gridViewList);
      base.OnLoad(e);
      UpdateButtons();
    }

    private void editor_Changed(object sender, EventArgs e)
    {
      UpdateButtons();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      editor.AddNew(this);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      EditByRowHandle(gridViewList.FocusedRowHandle);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "Are you sure you want to remove the selected items?", "Remove",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      gridViewList.DeleteSelectedRows();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "Are you sure you want to clear all items?", "Clear",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      editor.Clear();
    }

    private void gridViewList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void gridList_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var info = gridViewList.CalcHitInfo(e.Location);
        EditByHitInfo(info);
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      string okClickCloseError;
      if (!editor.IsOKToClose(out okClickCloseError))
      {
        cancelClose = true;
        XtraMessageBox.Show(this, okClickCloseError, "Error",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (cancelClose)
      {
        e.Cancel = true;
        cancelClose = false;
      }
      base.OnFormClosing(e);
    }
  }
}
