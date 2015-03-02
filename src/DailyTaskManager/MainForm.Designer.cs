namespace DailyTaskManager
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.tbbMain = new DevExpress.XtraBars.BarButtonItem();
      this.tbbCategories = new DevExpress.XtraBars.BarButtonItem();
      this.tbbSettings = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.progStatus = new DevExpress.XtraEditors.MarqueeProgressBarControl();
      this.btnNextDay = new DevExpress.XtraEditors.SimpleButton();
      this.btnPreviousDay = new DevExpress.XtraEditors.SimpleButton();
      this.btnRemoveTask = new DevExpress.XtraEditors.SimpleButton();
      this.btnAddTask = new DevExpress.XtraEditors.SimpleButton();
      this.gridCurrentTasks = new DevExpress.XtraGrid.GridControl();
      this.dailyTasksSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewCurrentTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
      this.chkCompleted = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.colOrder = new DevExpress.XtraGrid.Columns.GridColumn();
      this.numOrder = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
      this.colTaskID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboTasks = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.tasksSource = new System.Windows.Forms.BindingSource(this.components);
      this.colSpan1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridAllTasks = new DevExpress.XtraGrid.GridControl();
      this.gridViewAllTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.categorySource = new System.Windows.Forms.BindingSource(this.components);
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSpan = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colImportance = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboImportance = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.dateTimePicker = new DevExpress.XtraEditors.DateEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.timerUpdate = new System.Windows.Forms.Timer(this.components);
      this.dailyTasksPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
      this.mnuUpdateOrder = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.progStatus.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridCurrentTasks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dailyTasksSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrentTasks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkCompleted)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numOrder)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboTasks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridAllTasks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewAllTasks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategories)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.categorySource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboImportance)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dailyTasksPopupMenu)).BeginInit();
      this.SuspendLayout();
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tbbSave,
            this.tbbMain,
            this.tbbCategories,
            this.tbbSettings,
            this.mnuUpdateOrder});
      this.barManager1.MaxItemId = 5;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbMain, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbCategories, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSettings, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DisableClose = true;
      this.bar1.OptionsBar.DisableCustomization = true;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // tbbSave
      // 
      this.tbbSave.Caption = "Save";
      this.tbbSave.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.Glyph")));
      this.tbbSave.Id = 0;
      this.tbbSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.LargeGlyph")));
      this.tbbSave.Name = "tbbSave";
      this.tbbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSave_ItemClick);
      // 
      // tbbMain
      // 
      this.tbbMain.Caption = "Main";
      this.tbbMain.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbMain.Glyph")));
      this.tbbMain.Id = 1;
      this.tbbMain.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbMain.LargeGlyph")));
      this.tbbMain.Name = "tbbMain";
      this.tbbMain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbMain_ItemClick);
      // 
      // tbbCategories
      // 
      this.tbbCategories.Caption = "Categories";
      this.tbbCategories.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbCategories.Glyph")));
      this.tbbCategories.Id = 2;
      this.tbbCategories.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbCategories.LargeGlyph")));
      this.tbbCategories.Name = "tbbCategories";
      this.tbbCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbCategories_ItemClick);
      // 
      // tbbSettings
      // 
      this.tbbSettings.Caption = "Settings";
      this.tbbSettings.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbSettings.Glyph")));
      this.tbbSettings.Id = 3;
      this.tbbSettings.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSettings.LargeGlyph")));
      this.tbbSettings.Name = "tbbSettings";
      this.tbbSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSettings_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Size = new System.Drawing.Size(735, 31);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 452);
      this.barDockControlBottom.Size = new System.Drawing.Size(735, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(735, 31);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.progStatus);
      this.layoutControl1.Controls.Add(this.btnNextDay);
      this.layoutControl1.Controls.Add(this.btnPreviousDay);
      this.layoutControl1.Controls.Add(this.btnRemoveTask);
      this.layoutControl1.Controls.Add(this.btnAddTask);
      this.layoutControl1.Controls.Add(this.gridCurrentTasks);
      this.layoutControl1.Controls.Add(this.gridAllTasks);
      this.layoutControl1.Controls.Add(this.dateTimePicker);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 31);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(645, 395, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(735, 421);
      this.layoutControl1.TabIndex = 4;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // progStatus
      // 
      this.progStatus.EditValue = 0;
      this.progStatus.Location = new System.Drawing.Point(12, 391);
      this.progStatus.MenuManager = this.barManager1;
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(711, 18);
      this.progStatus.StyleController = this.layoutControl1;
      this.progStatus.TabIndex = 11;
      // 
      // btnNextDay
      // 
      this.btnNextDay.AutoWidthInLayoutControl = true;
      this.btnNextDay.Image = ((System.Drawing.Image)(resources.GetObject("btnNextDay.Image")));
      this.btnNextDay.Location = new System.Drawing.Point(685, 24);
      this.btnNextDay.Name = "btnNextDay";
      this.btnNextDay.Size = new System.Drawing.Size(26, 22);
      this.btnNextDay.StyleController = this.layoutControl1;
      this.btnNextDay.TabIndex = 10;
      this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
      // 
      // btnPreviousDay
      // 
      this.btnPreviousDay.AutoWidthInLayoutControl = true;
      this.btnPreviousDay.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousDay.Image")));
      this.btnPreviousDay.Location = new System.Drawing.Point(24, 24);
      this.btnPreviousDay.Name = "btnPreviousDay";
      this.btnPreviousDay.Size = new System.Drawing.Size(26, 22);
      this.btnPreviousDay.StyleController = this.layoutControl1;
      this.btnPreviousDay.TabIndex = 9;
      this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
      // 
      // btnRemoveTask
      // 
      this.btnRemoveTask.AutoWidthInLayoutControl = true;
      this.btnRemoveTask.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTask.Image")));
      this.btnRemoveTask.Location = new System.Drawing.Point(352, 210);
      this.btnRemoveTask.Name = "btnRemoveTask";
      this.btnRemoveTask.Size = new System.Drawing.Size(26, 22);
      this.btnRemoveTask.StyleController = this.layoutControl1;
      this.btnRemoveTask.TabIndex = 8;
      this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
      // 
      // btnAddTask
      // 
      this.btnAddTask.AutoWidthInLayoutControl = true;
      this.btnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTask.Image")));
      this.btnAddTask.Location = new System.Drawing.Point(352, 184);
      this.btnAddTask.Name = "btnAddTask";
      this.btnAddTask.Size = new System.Drawing.Size(26, 22);
      this.btnAddTask.StyleController = this.layoutControl1;
      this.btnAddTask.TabIndex = 7;
      this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
      // 
      // gridCurrentTasks
      // 
      this.gridCurrentTasks.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridCurrentTasks.DataSource = this.dailyTasksSource;
      this.gridCurrentTasks.Location = new System.Drawing.Point(394, 93);
      this.gridCurrentTasks.MainView = this.gridViewCurrentTasks;
      this.gridCurrentTasks.MenuManager = this.barManager1;
      this.gridCurrentTasks.Name = "gridCurrentTasks";
      this.gridCurrentTasks.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboTasks,
            this.numOrder,
            this.chkCompleted});
      this.gridCurrentTasks.Size = new System.Drawing.Size(317, 282);
      this.gridCurrentTasks.TabIndex = 6;
      this.gridCurrentTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCurrentTasks});
      // 
      // dailyTasksSource
      // 
      this.dailyTasksSource.DataSource = typeof(DailyTaskManager.DailyTaskItem);
      this.dailyTasksSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.dailyTasksSource_ListChanged);
      // 
      // gridViewCurrentTasks
      // 
      this.gridViewCurrentTasks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompleted,
            this.colOrder,
            this.colTaskID,
            this.colSpan1});
      this.gridViewCurrentTasks.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewCurrentTasks.GridControl = this.gridCurrentTasks;
      this.gridViewCurrentTasks.Name = "gridViewCurrentTasks";
      this.gridViewCurrentTasks.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewCurrentTasks.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewCurrentTasks.OptionsMenu.EnableColumnMenu = false;
      this.gridViewCurrentTasks.OptionsMenu.EnableFooterMenu = false;
      this.gridViewCurrentTasks.OptionsMenu.EnableGroupPanelMenu = false;
      this.gridViewCurrentTasks.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewCurrentTasks.OptionsSelection.MultiSelect = true;
      this.gridViewCurrentTasks.OptionsView.ShowColumnHeaders = false;
      this.gridViewCurrentTasks.OptionsView.ShowGroupPanel = false;
      this.gridViewCurrentTasks.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewCurrentTasks.OptionsView.ShowIndicator = false;
      this.gridViewCurrentTasks.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewCurrentTasks.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewCurrentTasks_CustomDrawCell);
      this.gridViewCurrentTasks.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewCurrentTasks_PopupMenuShowing);
      this.gridViewCurrentTasks.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_SelectionChanged);
      this.gridViewCurrentTasks.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewCurrentTasks_CellValueChanged);
      // 
      // colCompleted
      // 
      this.colCompleted.ColumnEdit = this.chkCompleted;
      this.colCompleted.FieldName = "Completed";
      this.colCompleted.Name = "colCompleted";
      this.colCompleted.OptionsColumn.FixedWidth = true;
      this.colCompleted.Visible = true;
      this.colCompleted.VisibleIndex = 0;
      this.colCompleted.Width = 20;
      // 
      // chkCompleted
      // 
      this.chkCompleted.AutoHeight = false;
      this.chkCompleted.Caption = "Check";
      this.chkCompleted.Name = "chkCompleted";
      this.chkCompleted.CheckedChanged += new System.EventHandler(this.chkCompleted_CheckedChanged);
      // 
      // colOrder
      // 
      this.colOrder.AppearanceCell.Options.UseTextOptions = true;
      this.colOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.colOrder.ColumnEdit = this.numOrder;
      this.colOrder.FieldName = "Order";
      this.colOrder.Name = "colOrder";
      this.colOrder.OptionsColumn.AllowSize = false;
      this.colOrder.OptionsColumn.FixedWidth = true;
      this.colOrder.Visible = true;
      this.colOrder.VisibleIndex = 1;
      this.colOrder.Width = 80;
      // 
      // numOrder
      // 
      this.numOrder.AutoHeight = false;
      this.numOrder.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numOrder.IsFloatValue = false;
      this.numOrder.Mask.EditMask = "N00";
      this.numOrder.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numOrder.Name = "numOrder";
      // 
      // colTaskID
      // 
      this.colTaskID.ColumnEdit = this.cboTasks;
      this.colTaskID.FieldName = "TaskID";
      this.colTaskID.Name = "colTaskID";
      this.colTaskID.OptionsColumn.AllowEdit = false;
      this.colTaskID.OptionsColumn.ReadOnly = true;
      this.colTaskID.Visible = true;
      this.colTaskID.VisibleIndex = 2;
      // 
      // cboTasks
      // 
      this.cboTasks.AutoHeight = false;
      this.cboTasks.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboTasks.DataSource = this.tasksSource;
      this.cboTasks.DisplayMember = "Name";
      this.cboTasks.Name = "cboTasks";
      this.cboTasks.ValueMember = "ID";
      // 
      // tasksSource
      // 
      this.tasksSource.DataSource = typeof(DailyTaskManager.TaskItem);
      // 
      // colSpan1
      // 
      this.colSpan1.AppearanceCell.Options.UseTextOptions = true;
      this.colSpan1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.colSpan1.FieldName = "Span";
      this.colSpan1.MaxWidth = 120;
      this.colSpan1.Name = "colSpan1";
      this.colSpan1.OptionsColumn.AllowEdit = false;
      this.colSpan1.OptionsColumn.ReadOnly = true;
      this.colSpan1.Visible = true;
      this.colSpan1.VisibleIndex = 3;
      this.colSpan1.Width = 120;
      // 
      // gridAllTasks
      // 
      this.gridAllTasks.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridAllTasks.DataSource = this.tasksSource;
      this.gridAllTasks.Location = new System.Drawing.Point(24, 93);
      this.gridAllTasks.MainView = this.gridViewAllTasks;
      this.gridAllTasks.MenuManager = this.barManager1;
      this.gridAllTasks.Name = "gridAllTasks";
      this.gridAllTasks.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboCategories,
            this.cboImportance});
      this.gridAllTasks.Size = new System.Drawing.Size(312, 282);
      this.gridAllTasks.TabIndex = 5;
      this.gridAllTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAllTasks});
      // 
      // gridViewAllTasks
      // 
      this.gridViewAllTasks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCategoryID,
            this.colName,
            this.colSpan,
            this.colImportance});
      this.gridViewAllTasks.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewAllTasks.GridControl = this.gridAllTasks;
      this.gridViewAllTasks.GroupCount = 1;
      this.gridViewAllTasks.GroupFormat = "{1}";
      this.gridViewAllTasks.Name = "gridViewAllTasks";
      this.gridViewAllTasks.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewAllTasks.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewAllTasks.OptionsBehavior.Editable = false;
      this.gridViewAllTasks.OptionsBehavior.ReadOnly = true;
      this.gridViewAllTasks.OptionsMenu.EnableColumnMenu = false;
      this.gridViewAllTasks.OptionsMenu.EnableFooterMenu = false;
      this.gridViewAllTasks.OptionsMenu.EnableGroupPanelMenu = false;
      this.gridViewAllTasks.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewAllTasks.OptionsSelection.MultiSelect = true;
      this.gridViewAllTasks.OptionsView.ShowColumnHeaders = false;
      this.gridViewAllTasks.OptionsView.ShowGroupPanel = false;
      this.gridViewAllTasks.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewAllTasks.OptionsView.ShowIndicator = false;
      this.gridViewAllTasks.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewAllTasks.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategoryID, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.gridViewAllTasks.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_SelectionChanged);
      // 
      // colID
      // 
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      // 
      // colCategoryID
      // 
      this.colCategoryID.ColumnEdit = this.cboCategories;
      this.colCategoryID.FieldName = "CategoryID";
      this.colCategoryID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;
      this.colCategoryID.Name = "colCategoryID";
      this.colCategoryID.Visible = true;
      this.colCategoryID.VisibleIndex = 0;
      // 
      // cboCategories
      // 
      this.cboCategories.AutoHeight = false;
      this.cboCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboCategories.DataSource = this.categorySource;
      this.cboCategories.DisplayMember = "Name";
      this.cboCategories.Name = "cboCategories";
      this.cboCategories.ValueMember = "ID";
      // 
      // categorySource
      // 
      this.categorySource.DataSource = typeof(DailyTaskManager.Category);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      this.colName.Width = 85;
      // 
      // colSpan
      // 
      this.colSpan.AppearanceCell.Options.UseTextOptions = true;
      this.colSpan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.colSpan.FieldName = "Span";
      this.colSpan.MaxWidth = 120;
      this.colSpan.Name = "colSpan";
      this.colSpan.Visible = true;
      this.colSpan.VisibleIndex = 1;
      this.colSpan.Width = 85;
      // 
      // colImportance
      // 
      this.colImportance.ColumnEdit = this.cboImportance;
      this.colImportance.FieldName = "Importance";
      this.colImportance.Name = "colImportance";
      this.colImportance.OptionsColumn.AllowSize = false;
      this.colImportance.OptionsColumn.FixedWidth = true;
      this.colImportance.Visible = true;
      this.colImportance.VisibleIndex = 2;
      this.colImportance.Width = 40;
      // 
      // cboImportance
      // 
      this.cboImportance.AutoHeight = false;
      this.cboImportance.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboImportance.Name = "cboImportance";
      // 
      // dateTimePicker
      // 
      this.dateTimePicker.EditValue = new System.DateTime(2014, 6, 26, 15, 31, 43, 0);
      this.dateTimePicker.Location = new System.Drawing.Point(54, 25);
      this.dateTimePicker.MenuManager = this.barManager1;
      this.dateTimePicker.Name = "dateTimePicker";
      this.dateTimePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dateTimePicker.Properties.DisplayFormat.FormatString = "D";
      this.dateTimePicker.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.dateTimePicker.Properties.EditFormat.FormatString = "D";
      this.dateTimePicker.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.dateTimePicker.Properties.Mask.EditMask = "D";
      this.dateTimePicker.Size = new System.Drawing.Size(627, 20);
      this.dateTimePicker.StyleController = this.layoutControl1;
      this.dateTimePicker.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "Root";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlItem8,
            this.layoutControlGroup5});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(735, 421);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
      this.emptySpaceItem1.Location = new System.Drawing.Point(340, 50);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(30, 122);
      this.emptySpaceItem1.Text = "emptySpaceItem1";
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
      this.emptySpaceItem2.Location = new System.Drawing.Point(340, 224);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(30, 155);
      this.emptySpaceItem2.Text = "emptySpaceItem2";
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "All Tasks";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 50);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(340, 329);
      this.layoutControlGroup2.Text = "All Tasks";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.gridAllTasks;
      this.layoutControlItem2.CustomizationFormText = "All";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(316, 286);
      this.layoutControlItem2.Text = "All";
      this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.CustomizationFormText = "Tasks for Today";
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
      this.layoutControlGroup3.Location = new System.Drawing.Point(370, 50);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(345, 329);
      this.layoutControlGroup3.Text = "Tasks for Today";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.gridCurrentTasks;
      this.layoutControlItem3.CustomizationFormText = "Current";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(321, 286);
      this.layoutControlItem3.Text = "Current";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlGroup4
      // 
      this.layoutControlGroup4.CustomizationFormText = "Date";
      this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem6});
      this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new System.Drawing.Size(715, 50);
      this.layoutControlGroup4.Text = "Date";
      this.layoutControlGroup4.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.dateTimePicker;
      this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
      this.layoutControlItem1.CustomizationFormText = "Date";
      this.layoutControlItem1.Location = new System.Drawing.Point(30, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(631, 26);
      this.layoutControlItem1.Text = "Date";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      this.layoutControlItem1.TrimClientAreaToControl = false;
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.btnNextDay;
      this.layoutControlItem7.CustomizationFormText = "Tomorrow";
      this.layoutControlItem7.Location = new System.Drawing.Point(661, 0);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(30, 26);
      this.layoutControlItem7.Text = "Tomorrow";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem7.TextToControlDistance = 0;
      this.layoutControlItem7.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnPreviousDay;
      this.layoutControlItem6.CustomizationFormText = "Yesterday";
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(30, 26);
      this.layoutControlItem6.Text = "Yesterday";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextToControlDistance = 0;
      this.layoutControlItem6.TextVisible = false;
      // 
      // layoutControlItem8
      // 
      this.layoutControlItem8.Control = this.progStatus;
      this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
      this.layoutControlItem8.Location = new System.Drawing.Point(0, 379);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new System.Drawing.Size(715, 22);
      this.layoutControlItem8.Text = "layoutControlItem8";
      this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem8.TextToControlDistance = 0;
      this.layoutControlItem8.TextVisible = false;
      // 
      // layoutControlGroup5
      // 
      this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup5";
      this.layoutControlGroup5.GroupBordersVisible = false;
      this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem4});
      this.layoutControlGroup5.Location = new System.Drawing.Point(340, 172);
      this.layoutControlGroup5.Name = "layoutControlGroup5";
      this.layoutControlGroup5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup5.Size = new System.Drawing.Size(30, 52);
      this.layoutControlGroup5.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup5.Text = "layoutControlGroup5";
      this.layoutControlGroup5.TextVisible = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnRemoveTask;
      this.layoutControlItem5.CustomizationFormText = "Remove";
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 26);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(30, 26);
      this.layoutControlItem5.Text = "Remove";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextToControlDistance = 0;
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnAddTask;
      this.layoutControlItem4.CustomizationFormText = "Add";
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(30, 26);
      this.layoutControlItem4.Text = "Add";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextToControlDistance = 0;
      this.layoutControlItem4.TextVisible = false;
      // 
      // timerUpdate
      // 
      this.timerUpdate.Interval = 1;
      this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
      // 
      // dailyTasksPopupMenu
      // 
      this.dailyTasksPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuUpdateOrder)});
      this.dailyTasksPopupMenu.Manager = this.barManager1;
      this.dailyTasksPopupMenu.Name = "dailyTasksPopupMenu";
      // 
      // mnuUpdateOrder
      // 
      this.mnuUpdateOrder.Caption = "Update Order";
      this.mnuUpdateOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuUpdateOrder.Glyph")));
      this.mnuUpdateOrder.Id = 4;
      this.mnuUpdateOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuUpdateOrder.LargeGlyph")));
      this.mnuUpdateOrder.Name = "mnuUpdateOrder";
      this.mnuUpdateOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuUpdateOrder_ItemClick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(735, 452);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Daily Task Manager";
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.progStatus.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridCurrentTasks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dailyTasksSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrentTasks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkCompleted)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numOrder)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboTasks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridAllTasks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewAllTasks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategories)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.categorySource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboImportance)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dailyTasksPopupMenu)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarButtonItem tbbSave;
    private DevExpress.XtraBars.BarButtonItem tbbMain;
    private DevExpress.XtraBars.BarButtonItem tbbCategories;
    private DevExpress.XtraBars.BarButtonItem tbbSettings;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.DateEdit dateTimePicker;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraGrid.GridControl gridAllTasks;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewAllTasks;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SimpleButton btnRemoveTask;
    private DevExpress.XtraEditors.SimpleButton btnAddTask;
    private DevExpress.XtraGrid.GridControl gridCurrentTasks;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewCurrentTasks;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraEditors.SimpleButton btnNextDay;
    private DevExpress.XtraEditors.SimpleButton btnPreviousDay;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraEditors.MarqueeProgressBarControl progStatus;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    private System.Windows.Forms.BindingSource dailyTasksSource;
    private System.Windows.Forms.BindingSource tasksSource;
    private DevExpress.XtraGrid.Columns.GridColumn colID;
    private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategories;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colSpan;
    private DevExpress.XtraGrid.Columns.GridColumn colImportance;
    private System.Windows.Forms.BindingSource categorySource;
    private DevExpress.XtraGrid.Columns.GridColumn colCompleted;
    private DevExpress.XtraGrid.Columns.GridColumn colOrder;
    private DevExpress.XtraGrid.Columns.GridColumn colTaskID;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboTasks;
    private DevExpress.XtraGrid.Columns.GridColumn colSpan1;
    private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit numOrder;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboImportance;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkCompleted;
    private System.Windows.Forms.Timer timerUpdate;
    private DevExpress.XtraBars.BarButtonItem mnuUpdateOrder;
    private DevExpress.XtraBars.PopupMenu dailyTasksPopupMenu;
  }
}