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
using DevExpress.XtraBars;
using DevExpress.XtraLayout.Utils;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DailyTaskManager.Properties;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DailyTaskManager
{
  public partial class MainForm : BaseForm
  {
    private float Volume
    {
      get { return SaveFile.Instance.Volume.GetValueOrDefault(0.1f); }
      set { SaveFile.Instance.Volume = value; }
    }

    private Dictionary<int, Sparkle> sparkles = new Dictionary<int, Sparkle>();
    private List<DailyTaskItem> current;

    public MainForm()
    {
      InitializeComponent();
      InitializeImportanceLookup();
    }

    private void InitializeImportanceLookup()
    {
      Factory.FillImportanceLookUpEdit(cboImportance);
    }

    private void SetIsWorking(bool working)
    {
      foreach (BarItem item in barManager1.Items)
      {
        item.Enabled = !working;
      }

      layoutControlGroup4.Enabled = !working;
      layoutControlGroup5.Enabled = !working;

      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
      layoutControlItem8.Visibility = working
        ? LayoutVisibility.Always
        : LayoutVisibility.Never;
    }

    private async void LoadData()
    {
      using (new WorkerToggle(SetIsWorking))
      {
        await Task.Run(() => SaveFile.Load());
        ReadCategories();

        LoadSelectedDate();
        dateTimePicker.DateTimeChanged += dateTimePicker_DateTimeChanged;

        ReadTasks();
      }
    }

    private void ReadTasks()
    {
      gridViewAllTasks.BeginDataUpdate();
      tasksSource.Clear();
      foreach (var t in SaveFile.Instance.Tasks)
      {
        tasksSource.Add(t);
      }
      gridViewAllTasks.EndDataUpdate();
      gridViewAllTasks.BestFitColumns();
      gridViewAllTasks.ExpandAllGroups();
    }

    private void UpdateTasks(List<TaskItem> list)
    {
      SaveFile.Instance.Tasks = list;
      ReadTasks();
    }

    private void ReadCategories()
    {
      gridViewAllTasks.BeginDataUpdate();
      categorySource.Clear();
      foreach (var c in SaveFile.Instance.Categories)
      {
        categorySource.Add(c);
      }
      gridViewAllTasks.EndDataUpdate();
    }

    private void UpdateCategories(List<Category> categories)
    {
      SaveFile.Instance.Categories = categories;
      ReadCategories();
    }

    private async void SaveData()
    {
      using (new WorkerToggle(SetIsWorking))
      {
        FlushTasks();
        await Task.Run(() => SaveFile.Save());
      }
    }

    private void LoadSelectedDate()
    {
      var days = SaveFile.Instance.Days;
      var date = dateTimePicker.DateTime;
      UpdateDateButtons();

      List<DailyTaskItem> items;
      if (!days.TryGetValue(date, out items))
      {
        items = new List<DailyTaskItem>();
        days[date] = items;
      }

      FlushTasks();
      current = items;

      gridViewCurrentTasks.BeginDataUpdate();
      dailyTasksSource.Clear();
      foreach (var d in items)
      {
        dailyTasksSource.Add(d);
      }
      gridViewCurrentTasks.EndDataUpdate();
      gridViewCurrentTasks.BestFitColumns();
      UpdateTaskButtons();
    }

    private void FlushTasks()
    {
      if (current != null)
      {
        current.Clear();
        current.AddRange(dailyTasksSource.Cast<DailyTaskItem>());
      }
    }

    private void UpdateDateButtons()
    {
      var date = dateTimePicker.DateTime;
      btnPreviousDay.Enabled = date > dateTimePicker.Properties.MinValue;
      btnNextDay.Enabled = date < dateTimePicker.Properties.MaxValue;
    }

    private void UpdateTaskButtons()
    {
      btnAddTask.Enabled = gridViewAllTasks.SelectedRowsCount > 0;
      btnRemoveTask.Enabled = gridViewCurrentTasks.SelectedRowsCount > 0;
    }

    private void PlayCompleteSound(int rowHandle)
    {
      new WavePlayer(Resources.Success, Volume);
      sparkles[rowHandle] = new Sparkle(rowHandle, gridViewCurrentTasks);

      if (!timerUpdate.Enabled)
      {
        timerUpdate.Start();
      }
    }

    private void UpdateTaskOrder()
    {
      gridViewCurrentTasks.BeginDataUpdate();
      var tasks = dailyTasksSource
        .Cast<DailyTaskItem>()
        .OrderBy(t => t.Order)
        .ToArray();

      dailyTasksSource.Clear();
      for (int i = 0; i < tasks.Length; ++i)
      {
        var t = tasks[i];
        t.Order = i + 1;
        dailyTasksSource.Add(t);
      }
      gridViewCurrentTasks.EndDataUpdate();
    }

    protected override void OnLoad(EventArgs e)
    {
      dateTimePicker.Properties.MinValue = DateTime.Parse("1/1/2014");
      dateTimePicker.Properties.MaxValue = DateTime.Parse("1/1/2064");
      dateTimePicker.DateTime = DateTime.Today;

      LoadData();
      base.OnLoad(e);

      UpdateTaskButtons();
    }

    private void tbbSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      SaveData();
    }

    private void tbbMain_ItemClick(object sender, ItemClickEventArgs e)
    {
      var editor = new TaskItemEditor();
      using (var dlg = new DataListDialog(editor))
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          UpdateTasks(editor.List.Cast<TaskItem>().ToList());
        }
      }
    }

    private void tbbCategories_ItemClick(object sender, ItemClickEventArgs e)
    {
      var editor = new CategoryEditor();
      using (var dlg = new DataListDialog(editor))
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          UpdateCategories(editor.List.Cast<Category>().ToList());
        }
      }
    }

    private void tbbSettings_ItemClick(object sender, ItemClickEventArgs e)
    {
      using (var dlg = new EditSettingsDialog())
      {
        dlg.Text = "Edit Settings";
        dlg.Volume = Volume;
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          Volume = dlg.Volume;
        }
      }
    }

    private void dateTimePicker_DateTimeChanged(object sender, EventArgs e)
    {
      LoadSelectedDate();
    }

    private void btnPreviousDay_Click(object sender, EventArgs e)
    {
      dateTimePicker.DateTime = dateTimePicker.DateTime.AddDays(-1);
    }

    private void btnNextDay_Click(object sender, EventArgs e)
    {
      dateTimePicker.DateTime = dateTimePicker.DateTime.AddDays(1);
    }

    private void dailyTasksSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateTaskButtons();
    }

    private void gridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      UpdateTaskButtons();
    }

    private void gridViewCurrentTasks_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
    {
      var task = gridViewCurrentTasks.GetRow(e.RowHandle) as DailyTaskItem;
      if (e.Column != colCompleted && task != null && task.Completed)
      {
        var rect = e.Bounds;
        var center = rect.Y + (rect.Height / 2);
        e.Graphics.DrawLine(Pens.Black, rect.Left - 1, center, rect.Right + 1, center);
      }

      if (sparkles.Count > 0)
      {
        Sparkle sparkle;
        if (sparkles.TryGetValue(e.RowHandle, out sparkle))
        {
          sparkle.Render(e.Graphics);
        }
      }
    }

    private void gridViewCurrentTasks_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      if (e.Column == colCompleted)
      {
        gridViewCurrentTasks.InvalidateRow(e.RowHandle);

        bool completed = (bool)e.Value;
        if (completed)
        {
          PlayCompleteSound(e.RowHandle);
        }
      }
    }

    private void chkCompleted_CheckedChanged(object sender, EventArgs e)
    {
      gridViewCurrentTasks.PostEditor();
    }

    private void btnAddTask_Click(object sender, EventArgs e)
    {
      // retrieve all of the tasks that the user has selected
      var selected = gridViewAllTasks.GetSelectedRows()
        .Select(i => gridViewAllTasks.GetRow(i) as TaskItem)
        .ToArray();

      // create a list to hold the tasks which already exist
      var exists = new List<TaskItem>();

      // create daily task items and add them to the current task list
      foreach (var task in selected)
      {
        // if the task already exists in the daily tasks, then don't add it again
        if (dailyTasksSource.Cast<DailyTaskItem>().Any(t => string.Equals(t.TaskID, task.ID)))
        {
          exists.Add(task);
          continue;
        }

        // add a new daily task for this task
        dailyTasksSource.Add(new DailyTaskItem
        {
          Completed = false,
          Order = dailyTasksSource.Count + 1,
          Span = task.Span,
          TaskID = task.ID,
        });
      }

      // if there are tasks which already exist, then alert the user
      if (exists.Count > 0)
      {
        using (var dlg = new TaskItemListDialog(exists, "The following tasks are already added"))
        {
          dlg.Text = "Duplicates Not Added";
          dlg.ShowDialog(this);
        }
      }
    }

    private void btnRemoveTask_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "Are you sure you want to remove the selected tasks?", "Remove",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      gridViewCurrentTasks.DeleteSelectedRows();
      UpdateTaskOrder();
    }

    private void timerUpdate_Tick(object sender, EventArgs e)
    {
      var keys = sparkles.Keys.ToArray();
      foreach (var k in keys)
      {
        var s = sparkles[k];
        s.Update();

        if (s.IsFinished)
        {
          sparkles.Remove(k);
        }
      }

      if (sparkles.Count == 0)
      {
        timerUpdate.Stop();
      }

      gridViewCurrentTasks.InvalidateRows();
    }

    private void mnuUpdateOrder_ItemClick(object sender, ItemClickEventArgs e)
    {
      UpdateTaskOrder();
    }

    private void gridViewCurrentTasks_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
    {
      dailyTasksPopupMenu.ShowPopup(gridCurrentTasks.PointToScreen(e.Point));
    }
  }
}