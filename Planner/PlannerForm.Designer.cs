namespace Planner{
  partial class PlannerForm{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing){
      if (disposing && (components != null)){
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent(){
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlannerForm));
      this.tbcMain = new System.Windows.Forms.TabControl();
      this.tbTimeSheet = new System.Windows.Forms.TabPage();
      this.gbDayTotalTime = new System.Windows.Forms.GroupBox();
      this.lblTotal = new System.Windows.Forms.Label();
      this.btnQuickEnd = new System.Windows.Forms.Button();
      this.lblQuickTask = new System.Windows.Forms.Label();
      this.btnQuickAdd = new System.Windows.Forms.Button();
      this.txtQuickAddTask = new System.Windows.Forms.TextBox();
      this.dgvTimeSheet = new System.Windows.Forms.DataGridView();
      this.TimeSheetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TimeSheetTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TimeSheetStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TimeSheetEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TimeSheetJobTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TimeSheetMainCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TimeSheetSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cmsTimeSheet = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmsTimeSheetAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsTimeSheetEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsTimeSheetDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.cmsTimeSheetInsert = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.cmsTimeSheetViewLinkedTodo = new System.Windows.Forms.ToolStripMenuItem();
      this.calTimeSheet = new System.Windows.Forms.MonthCalendar();
      this.tbTodo = new System.Windows.Forms.TabPage();
      this.dgvTodo = new System.Windows.Forms.DataGridView();
      this.TodoComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.TodoTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TodoStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TodoEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TodoDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cmsTodo = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmsTodoAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsTodoEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsTodoDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.tbNotes = new System.Windows.Forms.TabPage();
      this.lblNote = new System.Windows.Forms.Label();
      this.txtNote = new System.Windows.Forms.TextBox();
      this.tvNotes = new System.Windows.Forms.TreeView();
      this.cmsNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmsNotesAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsNotesEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsNotesDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.imgList = new System.Windows.Forms.ImageList(this.components);
      this.tsPlanner = new System.Windows.Forms.ToolStrip();
      this.tsbAdd = new System.Windows.Forms.ToolStripButton();
      this.tsbInsert = new System.Windows.Forms.ToolStripButton();
      this.tsbEdit = new System.Windows.Forms.ToolStripButton();
      this.tsbDelete = new System.Windows.Forms.ToolStripButton();
      this.msPlanner = new System.Windows.Forms.MenuStrip();
      this.msPlannerFile = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTimeSheet = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTimeSheetAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTimeSheetEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTimeSheetDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTimeSheetSeperator01 = new System.Windows.Forms.ToolStripSeparator();
      this.msPlannerFileTimeSheetInsert = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTodo = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTodoAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTodoEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileTodoDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileNotes = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileNotesAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileNotesEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileNotesDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerFileSeperator01 = new System.Windows.Forms.ToolStripSeparator();
      this.msPlannerFileClose = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerTools = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerToolsCategories = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.msPlannerHelpSeperator01 = new System.Windows.Forms.ToolStripSeparator();
      this.msPlannerHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.nciPlanner = new System.Windows.Forms.NotifyIcon(this.components);
      this.cmsPlanner = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmsPlannerShow = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsPlannerSeparator01 = new System.Windows.Forms.ToolStripSeparator();
      this.cmsPlannerAddTimeSheet = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsPlannerAddTodo = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsPlannerAddNotes = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsPlannerSeparator02 = new System.Windows.Forms.ToolStripSeparator();
      this.cmsPlannerOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsPlannerSeparator03 = new System.Windows.Forms.ToolStripSeparator();
      this.cmsPlannerClose = new System.Windows.Forms.ToolStripMenuItem();
      this.cmsPlannerAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.tbcMain.SuspendLayout();
      this.tbTimeSheet.SuspendLayout();
      this.gbDayTotalTime.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheet)).BeginInit();
      this.cmsTimeSheet.SuspendLayout();
      this.tbTodo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
      this.cmsTodo.SuspendLayout();
      this.tbNotes.SuspendLayout();
      this.cmsNotes.SuspendLayout();
      this.tsPlanner.SuspendLayout();
      this.msPlanner.SuspendLayout();
      this.cmsPlanner.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbcMain
      // 
      this.tbcMain.Controls.Add(this.tbTimeSheet);
      this.tbcMain.Controls.Add(this.tbTodo);
      this.tbcMain.Controls.Add(this.tbNotes);
      this.tbcMain.ImageList = this.imgList;
      this.tbcMain.Location = new System.Drawing.Point(0, 66);
      this.tbcMain.Name = "tbcMain";
      this.tbcMain.SelectedIndex = 0;
      this.tbcMain.Size = new System.Drawing.Size(990, 498);
      this.tbcMain.TabIndex = 0;
      this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
      // 
      // tbTimeSheet
      // 
      this.tbTimeSheet.Controls.Add(this.gbDayTotalTime);
      this.tbTimeSheet.Controls.Add(this.btnQuickEnd);
      this.tbTimeSheet.Controls.Add(this.lblQuickTask);
      this.tbTimeSheet.Controls.Add(this.btnQuickAdd);
      this.tbTimeSheet.Controls.Add(this.txtQuickAddTask);
      this.tbTimeSheet.Controls.Add(this.dgvTimeSheet);
      this.tbTimeSheet.Controls.Add(this.calTimeSheet);
      this.tbTimeSheet.ImageIndex = 5;
      this.tbTimeSheet.Location = new System.Drawing.Point(4, 23);
      this.tbTimeSheet.Name = "tbTimeSheet";
      this.tbTimeSheet.Padding = new System.Windows.Forms.Padding(3);
      this.tbTimeSheet.Size = new System.Drawing.Size(982, 471);
      this.tbTimeSheet.TabIndex = 1;
      this.tbTimeSheet.Text = "Time Sheet";
      this.tbTimeSheet.UseVisualStyleBackColor = true;
      // 
      // gbDayTotalTime
      // 
      this.gbDayTotalTime.Controls.Add(this.lblTotal);
      this.gbDayTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbDayTotalTime.ForeColor = System.Drawing.SystemColors.Desktop;
      this.gbDayTotalTime.Location = new System.Drawing.Point(235, 87);
      this.gbDayTotalTime.Name = "gbDayTotalTime";
      this.gbDayTotalTime.Size = new System.Drawing.Size(148, 51);
      this.gbDayTotalTime.TabIndex = 11;
      this.gbDayTotalTime.TabStop = false;
      this.gbDayTotalTime.Text = "Selected Day(s) Total:";
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotal.ForeColor = System.Drawing.Color.Black;
      this.lblTotal.Location = new System.Drawing.Point(41, 25);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(19, 13);
      this.lblTotal.TabIndex = 10;
      this.lblTotal.Text = "...";
      // 
      // btnQuickEnd
      // 
      this.btnQuickEnd.Location = new System.Drawing.Point(882, 64);
      this.btnQuickEnd.Name = "btnQuickEnd";
      this.btnQuickEnd.Size = new System.Drawing.Size(75, 23);
      this.btnQuickEnd.TabIndex = 2;
      this.btnQuickEnd.Text = "Quick End";
      this.btnQuickEnd.UseVisualStyleBackColor = true;
      this.btnQuickEnd.Click += new System.EventHandler(this.btnQuickEnd_Click);
      // 
      // lblQuickTask
      // 
      this.lblQuickTask.AutoSize = true;
      this.lblQuickTask.Location = new System.Drawing.Point(238, 22);
      this.lblQuickTask.Name = "lblQuickTask";
      this.lblQuickTask.Size = new System.Drawing.Size(60, 13);
      this.lblQuickTask.TabIndex = 6;
      this.lblQuickTask.Text = "Quick Add:";
      // 
      // btnQuickAdd
      // 
      this.btnQuickAdd.Location = new System.Drawing.Point(801, 64);
      this.btnQuickAdd.Name = "btnQuickAdd";
      this.btnQuickAdd.Size = new System.Drawing.Size(75, 23);
      this.btnQuickAdd.TabIndex = 1;
      this.btnQuickAdd.Text = "Quick Add";
      this.btnQuickAdd.UseVisualStyleBackColor = true;
      this.btnQuickAdd.Click += new System.EventHandler(this.btnQuickAdd_Click);
      // 
      // txtQuickAddTask
      // 
      this.txtQuickAddTask.Location = new System.Drawing.Point(238, 38);
      this.txtQuickAddTask.Name = "txtQuickAddTask";
      this.txtQuickAddTask.Size = new System.Drawing.Size(719, 20);
      this.txtQuickAddTask.TabIndex = 0;
      this.txtQuickAddTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuickAddTask_KeyPress);
      // 
      // dgvTimeSheet
      // 
      this.dgvTimeSheet.AllowUserToDeleteRows = false;
      this.dgvTimeSheet.AllowUserToResizeColumns = false;
      this.dgvTimeSheet.AllowUserToResizeRows = false;
      this.dgvTimeSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvTimeSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvTimeSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeSheetDate,
            this.TimeSheetTask,
            this.TimeSheetStartTime,
            this.TimeSheetEndTime,
            this.TimeSheetJobTime,
            this.TimeSheetMainCategory,
            this.TimeSheetSubCategory});
      this.dgvTimeSheet.ContextMenuStrip = this.cmsTimeSheet;
      this.dgvTimeSheet.Location = new System.Drawing.Point(-1, 161);
      this.dgvTimeSheet.Name = "dgvTimeSheet";
      this.dgvTimeSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvTimeSheet.ShowEditingIcon = false;
      this.dgvTimeSheet.Size = new System.Drawing.Size(984, 310);
      this.dgvTimeSheet.TabIndex = 3;
      this.dgvTimeSheet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeSheet_CellDoubleClick);
      // 
      // TimeSheetDate
      // 
      this.TimeSheetDate.HeaderText = "Date";
      this.TimeSheetDate.Name = "TimeSheetDate";
      this.TimeSheetDate.ReadOnly = true;
      this.TimeSheetDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // TimeSheetTask
      // 
      this.TimeSheetTask.HeaderText = "Task";
      this.TimeSheetTask.Name = "TimeSheetTask";
      this.TimeSheetTask.ReadOnly = true;
      this.TimeSheetTask.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.TimeSheetTask.Width = 643;
      // 
      // TimeSheetStartTime
      // 
      this.TimeSheetStartTime.HeaderText = "Start Time";
      this.TimeSheetStartTime.Name = "TimeSheetStartTime";
      this.TimeSheetStartTime.ReadOnly = true;
      this.TimeSheetStartTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // TimeSheetEndTime
      // 
      this.TimeSheetEndTime.HeaderText = "End Time";
      this.TimeSheetEndTime.Name = "TimeSheetEndTime";
      this.TimeSheetEndTime.ReadOnly = true;
      this.TimeSheetEndTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // TimeSheetJobTime
      // 
      this.TimeSheetJobTime.HeaderText = "Job Time";
      this.TimeSheetJobTime.Name = "TimeSheetJobTime";
      // 
      // TimeSheetMainCategory
      // 
      this.TimeSheetMainCategory.HeaderText = "Category";
      this.TimeSheetMainCategory.Name = "TimeSheetMainCategory";
      this.TimeSheetMainCategory.ReadOnly = true;
      this.TimeSheetMainCategory.Width = 300;
      // 
      // TimeSheetSubCategory
      // 
      this.TimeSheetSubCategory.HeaderText = "Sub Category";
      this.TimeSheetSubCategory.Name = "TimeSheetSubCategory";
      this.TimeSheetSubCategory.ReadOnly = true;
      this.TimeSheetSubCategory.Width = 300;
      // 
      // cmsTimeSheet
      // 
      this.cmsTimeSheet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTimeSheetAdd,
            this.cmsTimeSheetEdit,
            this.cmsTimeSheetDelete,
            this.toolStripSeparator1,
            this.cmsTimeSheetInsert,
            this.toolStripSeparator2,
            this.cmsTimeSheetViewLinkedTodo});
      this.cmsTimeSheet.Name = "cmsTimeSheet";
      this.cmsTimeSheet.Size = new System.Drawing.Size(193, 126);
      this.cmsTimeSheet.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTimeSheet_Opening);
      // 
      // cmsTimeSheetAdd
      // 
      this.cmsTimeSheetAdd.Name = "cmsTimeSheetAdd";
      this.cmsTimeSheetAdd.Size = new System.Drawing.Size(192, 22);
      this.cmsTimeSheetAdd.Text = "Add";
      this.cmsTimeSheetAdd.Click += new System.EventHandler(this.cmsTimeSheetAdd_Click);
      // 
      // cmsTimeSheetEdit
      // 
      this.cmsTimeSheetEdit.Name = "cmsTimeSheetEdit";
      this.cmsTimeSheetEdit.Size = new System.Drawing.Size(192, 22);
      this.cmsTimeSheetEdit.Text = "Edit";
      this.cmsTimeSheetEdit.Click += new System.EventHandler(this.cmsTimeSheetEdit_Click);
      // 
      // cmsTimeSheetDelete
      // 
      this.cmsTimeSheetDelete.Name = "cmsTimeSheetDelete";
      this.cmsTimeSheetDelete.Size = new System.Drawing.Size(192, 22);
      this.cmsTimeSheetDelete.Text = "Delete";
      this.cmsTimeSheetDelete.Click += new System.EventHandler(this.cmsTimeSheetDelete_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
      // 
      // cmsTimeSheetInsert
      // 
      this.cmsTimeSheetInsert.Name = "cmsTimeSheetInsert";
      this.cmsTimeSheetInsert.Size = new System.Drawing.Size(192, 22);
      this.cmsTimeSheetInsert.Text = "Insert";
      this.cmsTimeSheetInsert.Click += new System.EventHandler(this.cmsTimeSheetInsert_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
      // 
      // cmsTimeSheetViewLinkedTodo
      // 
      this.cmsTimeSheetViewLinkedTodo.Name = "cmsTimeSheetViewLinkedTodo";
      this.cmsTimeSheetViewLinkedTodo.Size = new System.Drawing.Size(192, 22);
      this.cmsTimeSheetViewLinkedTodo.Text = "View Linked Todo Item";
      this.cmsTimeSheetViewLinkedTodo.Click += new System.EventHandler(this.cmsTimeSheetViewLinkedTodo_Click);
      // 
      // calTimeSheet
      // 
      this.calTimeSheet.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
      this.calTimeSheet.Location = new System.Drawing.Point(-4, 3);
      this.calTimeSheet.MaxSelectionCount = 31;
      this.calTimeSheet.Name = "calTimeSheet";
      this.calTimeSheet.ShowWeekNumbers = true;
      this.calTimeSheet.TabIndex = 4;
      this.calTimeSheet.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calTimeSheet_DateChanged);
      // 
      // tbTodo
      // 
      this.tbTodo.Controls.Add(this.dgvTodo);
      this.tbTodo.ImageIndex = 4;
      this.tbTodo.Location = new System.Drawing.Point(4, 23);
      this.tbTodo.Name = "tbTodo";
      this.tbTodo.Padding = new System.Windows.Forms.Padding(3);
      this.tbTodo.Size = new System.Drawing.Size(982, 471);
      this.tbTodo.TabIndex = 0;
      this.tbTodo.Text = "ToDo List";
      this.tbTodo.UseVisualStyleBackColor = true;
      // 
      // dgvTodo
      // 
      this.dgvTodo.AllowUserToDeleteRows = false;
      this.dgvTodo.AllowUserToResizeColumns = false;
      this.dgvTodo.AllowUserToResizeRows = false;
      this.dgvTodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TodoComplete,
            this.TodoTask,
            this.TodoStartDate,
            this.TodoEndDate,
            this.TodoDesc});
      this.dgvTodo.ContextMenuStrip = this.cmsTodo;
      this.dgvTodo.Location = new System.Drawing.Point(-1, -1);
      this.dgvTodo.Name = "dgvTodo";
      this.dgvTodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvTodo.ShowEditingIcon = false;
      this.dgvTodo.Size = new System.Drawing.Size(983, 472);
      this.dgvTodo.TabIndex = 0;
      this.dgvTodo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellDoubleClick);
      this.dgvTodo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellContentClick);
      // 
      // TodoComplete
      // 
      this.TodoComplete.HeaderText = "Complete";
      this.TodoComplete.Name = "TodoComplete";
      this.TodoComplete.Width = 60;
      // 
      // TodoTask
      // 
      this.TodoTask.HeaderText = "Task";
      this.TodoTask.Name = "TodoTask";
      this.TodoTask.ReadOnly = true;
      this.TodoTask.Width = 300;
      // 
      // TodoStartDate
      // 
      this.TodoStartDate.HeaderText = "Start Date";
      this.TodoStartDate.Name = "TodoStartDate";
      this.TodoStartDate.ReadOnly = true;
      this.TodoStartDate.Width = 140;
      // 
      // TodoEndDate
      // 
      this.TodoEndDate.HeaderText = "Due Date";
      this.TodoEndDate.Name = "TodoEndDate";
      this.TodoEndDate.ReadOnly = true;
      this.TodoEndDate.Width = 140;
      // 
      // TodoDesc
      // 
      this.TodoDesc.HeaderText = "Desc";
      this.TodoDesc.Name = "TodoDesc";
      this.TodoDesc.ReadOnly = true;
      this.TodoDesc.Width = 428;
      // 
      // cmsTodo
      // 
      this.cmsTodo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTodoAdd,
            this.cmsTodoEdit,
            this.cmsTodoDelete});
      this.cmsTodo.Name = "ctmTodo";
      this.cmsTodo.Size = new System.Drawing.Size(117, 70);
      this.cmsTodo.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTodo_Opening);
      // 
      // cmsTodoAdd
      // 
      this.cmsTodoAdd.Name = "cmsTodoAdd";
      this.cmsTodoAdd.Size = new System.Drawing.Size(116, 22);
      this.cmsTodoAdd.Text = "Add";
      this.cmsTodoAdd.Click += new System.EventHandler(this.cmsTodoAdd_Click);
      // 
      // cmsTodoEdit
      // 
      this.cmsTodoEdit.Name = "cmsTodoEdit";
      this.cmsTodoEdit.Size = new System.Drawing.Size(116, 22);
      this.cmsTodoEdit.Text = "Edit";
      this.cmsTodoEdit.Click += new System.EventHandler(this.cmsTodoEdit_Click);
      // 
      // cmsTodoDelete
      // 
      this.cmsTodoDelete.Name = "cmsTodoDelete";
      this.cmsTodoDelete.Size = new System.Drawing.Size(116, 22);
      this.cmsTodoDelete.Text = "Delete";
      this.cmsTodoDelete.Click += new System.EventHandler(this.cmsTodoDelete_Click);
      // 
      // tbNotes
      // 
      this.tbNotes.Controls.Add(this.lblNote);
      this.tbNotes.Controls.Add(this.txtNote);
      this.tbNotes.Controls.Add(this.tvNotes);
      this.tbNotes.ImageIndex = 8;
      this.tbNotes.Location = new System.Drawing.Point(4, 23);
      this.tbNotes.Name = "tbNotes";
      this.tbNotes.Padding = new System.Windows.Forms.Padding(3);
      this.tbNotes.Size = new System.Drawing.Size(982, 471);
      this.tbNotes.TabIndex = 2;
      this.tbNotes.Text = "Notes";
      this.tbNotes.UseVisualStyleBackColor = true;
      // 
      // lblNote
      // 
      this.lblNote.AutoSize = true;
      this.lblNote.Location = new System.Drawing.Point(313, 3);
      this.lblNote.Name = "lblNote";
      this.lblNote.Size = new System.Drawing.Size(33, 13);
      this.lblNote.TabIndex = 5;
      this.lblNote.Text = "Note:";
      // 
      // txtNote
      // 
      this.txtNote.AcceptsReturn = true;
      this.txtNote.BackColor = System.Drawing.SystemColors.Info;
      this.txtNote.Location = new System.Drawing.Point(313, 19);
      this.txtNote.Multiline = true;
      this.txtNote.Name = "txtNote";
      this.txtNote.ReadOnly = true;
      this.txtNote.Size = new System.Drawing.Size(663, 444);
      this.txtNote.TabIndex = 4;
      this.txtNote.DoubleClick += new System.EventHandler(this.txtNote_DoubleClick);
      // 
      // tvNotes
      // 
      this.tvNotes.ContextMenuStrip = this.cmsNotes;
      this.tvNotes.ImageKey = "Notes.ico";
      this.tvNotes.ImageList = this.imgList;
      this.tvNotes.Location = new System.Drawing.Point(6, 6);
      this.tvNotes.Name = "tvNotes";
      this.tvNotes.SelectedImageKey = "Notes.ico";
      this.tvNotes.Size = new System.Drawing.Size(301, 457);
      this.tvNotes.TabIndex = 0;
      this.tvNotes.DoubleClick += new System.EventHandler(this.tvNotes_DoubleClick);
      this.tvNotes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNotes_AfterSelect);
      // 
      // cmsNotes
      // 
      this.cmsNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNotesAdd,
            this.cmsNotesEdit,
            this.cmsNotesDelete});
      this.cmsNotes.Name = "ctmTodo";
      this.cmsNotes.Size = new System.Drawing.Size(117, 70);
      this.cmsNotes.Opening += new System.ComponentModel.CancelEventHandler(this.cmsNotes_Opening);
      // 
      // cmsNotesAdd
      // 
      this.cmsNotesAdd.Name = "cmsNotesAdd";
      this.cmsNotesAdd.Size = new System.Drawing.Size(116, 22);
      this.cmsNotesAdd.Text = "Add";
      this.cmsNotesAdd.Click += new System.EventHandler(this.cmsNotesAdd_Click);
      // 
      // cmsNotesEdit
      // 
      this.cmsNotesEdit.Name = "cmsNotesEdit";
      this.cmsNotesEdit.Size = new System.Drawing.Size(116, 22);
      this.cmsNotesEdit.Text = "Edit";
      this.cmsNotesEdit.Click += new System.EventHandler(this.cmsNotesEdit_Click);
      // 
      // cmsNotesDelete
      // 
      this.cmsNotesDelete.Name = "cmsNotesDelete";
      this.cmsNotesDelete.Size = new System.Drawing.Size(116, 22);
      this.cmsNotesDelete.Text = "Delete";
      this.cmsNotesDelete.Click += new System.EventHandler(this.cmsNotesDelete_Click);
      // 
      // imgList
      // 
      this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
      this.imgList.TransparentColor = System.Drawing.Color.Transparent;
      this.imgList.Images.SetKeyName(0, "Add.ico");
      this.imgList.Images.SetKeyName(1, "Calendar.ico");
      this.imgList.Images.SetKeyName(2, "Del.ico");
      this.imgList.Images.SetKeyName(3, "Edit.ico");
      this.imgList.Images.SetKeyName(4, "Todo.ico");
      this.imgList.Images.SetKeyName(5, "TimeSheet.ico");
      this.imgList.Images.SetKeyName(6, "Day.ico");
      this.imgList.Images.SetKeyName(7, "Week.ico");
      this.imgList.Images.SetKeyName(8, "Notes.ico");
      this.imgList.Images.SetKeyName(9, "Insert.ico");
      // 
      // tsPlanner
      // 
      this.tsPlanner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbInsert,
            this.tsbEdit,
            this.tsbDelete});
      this.tsPlanner.Location = new System.Drawing.Point(0, 24);
      this.tsPlanner.Name = "tsPlanner";
      this.tsPlanner.Size = new System.Drawing.Size(987, 39);
      this.tsPlanner.TabIndex = 8;
      this.tsPlanner.Text = "Time Sheet";
      // 
      // tsbAdd
      // 
      this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbAdd.Image = global::Planner.Controls.Properties.Resources.Add;
      this.tsbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbAdd.Name = "tsbAdd";
      this.tsbAdd.Size = new System.Drawing.Size(36, 36);
      this.tsbAdd.Text = "Add Item";
      this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
      // 
      // tsbInsert
      // 
      this.tsbInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbInsert.Image = global::Planner.Controls.Properties.Resources.Insert;
      this.tsbInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tsbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbInsert.Name = "tsbInsert";
      this.tsbInsert.Size = new System.Drawing.Size(36, 36);
      this.tsbInsert.Text = "Insert Item";
      this.tsbInsert.Click += new System.EventHandler(this.tsbInsert_Click);
      // 
      // tsbEdit
      // 
      this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbEdit.Image = global::Planner.Controls.Properties.Resources.Edit;
      this.tsbEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbEdit.Name = "tsbEdit";
      this.tsbEdit.Size = new System.Drawing.Size(36, 36);
      this.tsbEdit.Text = "Edit Item";
      this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
      // 
      // tsbDelete
      // 
      this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbDelete.Image = global::Planner.Controls.Properties.Resources.Del;
      this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbDelete.Name = "tsbDelete";
      this.tsbDelete.Size = new System.Drawing.Size(36, 36);
      this.tsbDelete.Text = "Delete Item";
      this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
      // 
      // msPlanner
      // 
      this.msPlanner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPlannerFile,
            this.msPlannerTools,
            this.msPlannerHelp});
      this.msPlanner.Location = new System.Drawing.Point(0, 0);
      this.msPlanner.Name = "msPlanner";
      this.msPlanner.Size = new System.Drawing.Size(987, 24);
      this.msPlanner.TabIndex = 9;
      this.msPlanner.Text = "Main Menu";
      // 
      // msPlannerFile
      // 
      this.msPlannerFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPlannerFileTimeSheet,
            this.msPlannerFileTodo,
            this.msPlannerFileNotes,
            this.msPlannerFileSeperator01,
            this.msPlannerFileClose});
      this.msPlannerFile.Name = "msPlannerFile";
      this.msPlannerFile.Size = new System.Drawing.Size(35, 20);
      this.msPlannerFile.Text = "&File";
      // 
      // msPlannerFileTimeSheet
      // 
      this.msPlannerFileTimeSheet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPlannerFileTimeSheetAdd,
            this.msPlannerFileTimeSheetEdit,
            this.msPlannerFileTimeSheetDelete,
            this.msPlannerFileTimeSheetSeperator01,
            this.msPlannerFileTimeSheetInsert});
      this.msPlannerFileTimeSheet.Name = "msPlannerFileTimeSheet";
      this.msPlannerFileTimeSheet.Size = new System.Drawing.Size(138, 22);
      this.msPlannerFileTimeSheet.Text = "&Time Sheet";
      // 
      // msPlannerFileTimeSheetAdd
      // 
      this.msPlannerFileTimeSheetAdd.Name = "msPlannerFileTimeSheetAdd";
      this.msPlannerFileTimeSheetAdd.Size = new System.Drawing.Size(210, 22);
      this.msPlannerFileTimeSheetAdd.Text = "&Add Time Sheet Item";
      this.msPlannerFileTimeSheetAdd.Click += new System.EventHandler(this.msPlannerFileTimeSheetAdd_Click);
      // 
      // msPlannerFileTimeSheetEdit
      // 
      this.msPlannerFileTimeSheetEdit.Name = "msPlannerFileTimeSheetEdit";
      this.msPlannerFileTimeSheetEdit.Size = new System.Drawing.Size(210, 22);
      this.msPlannerFileTimeSheetEdit.Text = "&Edit Time Sheet Item";
      this.msPlannerFileTimeSheetEdit.Click += new System.EventHandler(this.msPlannerFileTimeSheetEdit_Click);
      // 
      // msPlannerFileTimeSheetDelete
      // 
      this.msPlannerFileTimeSheetDelete.Name = "msPlannerFileTimeSheetDelete";
      this.msPlannerFileTimeSheetDelete.Size = new System.Drawing.Size(210, 22);
      this.msPlannerFileTimeSheetDelete.Text = "De&lete Time Sheet Item(s)";
      this.msPlannerFileTimeSheetDelete.Click += new System.EventHandler(this.msPlannerFileTimeSheetDelete_Click);
      // 
      // msPlannerFileTimeSheetSeperator01
      // 
      this.msPlannerFileTimeSheetSeperator01.Name = "msPlannerFileTimeSheetSeperator01";
      this.msPlannerFileTimeSheetSeperator01.Size = new System.Drawing.Size(207, 6);
      // 
      // msPlannerFileTimeSheetInsert
      // 
      this.msPlannerFileTimeSheetInsert.Name = "msPlannerFileTimeSheetInsert";
      this.msPlannerFileTimeSheetInsert.Size = new System.Drawing.Size(210, 22);
      this.msPlannerFileTimeSheetInsert.Text = "&Insert Time Sheet Item";
      this.msPlannerFileTimeSheetInsert.Click += new System.EventHandler(this.msPlannerFileTimeSheetInsert_Click);
      // 
      // msPlannerFileTodo
      // 
      this.msPlannerFileTodo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPlannerFileTodoAdd,
            this.msPlannerFileTodoEdit,
            this.msPlannerFileTodoDelete});
      this.msPlannerFileTodo.Name = "msPlannerFileTodo";
      this.msPlannerFileTodo.Size = new System.Drawing.Size(138, 22);
      this.msPlannerFileTodo.Text = "To&do Item";
      // 
      // msPlannerFileTodoAdd
      // 
      this.msPlannerFileTodoAdd.Name = "msPlannerFileTodoAdd";
      this.msPlannerFileTodoAdd.Size = new System.Drawing.Size(181, 22);
      this.msPlannerFileTodoAdd.Text = "&Add Todo Item";
      this.msPlannerFileTodoAdd.Click += new System.EventHandler(this.msPlannerFileTodoAdd_Click);
      // 
      // msPlannerFileTodoEdit
      // 
      this.msPlannerFileTodoEdit.Name = "msPlannerFileTodoEdit";
      this.msPlannerFileTodoEdit.Size = new System.Drawing.Size(181, 22);
      this.msPlannerFileTodoEdit.Text = "&Edit Todo Item";
      this.msPlannerFileTodoEdit.Click += new System.EventHandler(this.msPlannerFileTodoEdit_Click);
      // 
      // msPlannerFileTodoDelete
      // 
      this.msPlannerFileTodoDelete.Name = "msPlannerFileTodoDelete";
      this.msPlannerFileTodoDelete.Size = new System.Drawing.Size(181, 22);
      this.msPlannerFileTodoDelete.Text = "De&lete Todo Item(s)";
      this.msPlannerFileTodoDelete.Click += new System.EventHandler(this.msPlannerFileTodoDelete_Click);
      // 
      // msPlannerFileNotes
      // 
      this.msPlannerFileNotes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPlannerFileNotesAdd,
            this.msPlannerFileNotesEdit,
            this.msPlannerFileNotesDelete});
      this.msPlannerFileNotes.Name = "msPlannerFileNotes";
      this.msPlannerFileNotes.Size = new System.Drawing.Size(138, 22);
      this.msPlannerFileNotes.Text = "&Notes Item";
      // 
      // msPlannerFileNotesAdd
      // 
      this.msPlannerFileNotesAdd.Name = "msPlannerFileNotesAdd";
      this.msPlannerFileNotesAdd.Size = new System.Drawing.Size(155, 22);
      this.msPlannerFileNotesAdd.Text = "&Add Note";
      this.msPlannerFileNotesAdd.Click += new System.EventHandler(this.msPlannerFileNotesAdd_Click);
      // 
      // msPlannerFileNotesEdit
      // 
      this.msPlannerFileNotesEdit.Name = "msPlannerFileNotesEdit";
      this.msPlannerFileNotesEdit.Size = new System.Drawing.Size(155, 22);
      this.msPlannerFileNotesEdit.Text = "&Edit Note";
      this.msPlannerFileNotesEdit.Click += new System.EventHandler(this.msPlannerFileNotesEdit_Click);
      // 
      // msPlannerFileNotesDelete
      // 
      this.msPlannerFileNotesDelete.Name = "msPlannerFileNotesDelete";
      this.msPlannerFileNotesDelete.Size = new System.Drawing.Size(155, 22);
      this.msPlannerFileNotesDelete.Text = "De&lete Note(s)";
      this.msPlannerFileNotesDelete.Click += new System.EventHandler(this.msPlannerFileNotesDelete_Click);
      // 
      // msPlannerFileSeperator01
      // 
      this.msPlannerFileSeperator01.Name = "msPlannerFileSeperator01";
      this.msPlannerFileSeperator01.Size = new System.Drawing.Size(135, 6);
      // 
      // msPlannerFileClose
      // 
      this.msPlannerFileClose.Name = "msPlannerFileClose";
      this.msPlannerFileClose.Size = new System.Drawing.Size(138, 22);
      this.msPlannerFileClose.Text = "&Close";
      this.msPlannerFileClose.Click += new System.EventHandler(this.msPlannerFileClose_Click);
      // 
      // msPlannerTools
      // 
      this.msPlannerTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPlannerToolsCategories,
            this.msPlannerToolsOptions});
      this.msPlannerTools.Name = "msPlannerTools";
      this.msPlannerTools.Size = new System.Drawing.Size(44, 20);
      this.msPlannerTools.Text = "&Tools";
      // 
      // msPlannerToolsCategories
      // 
      this.msPlannerToolsCategories.Name = "msPlannerToolsCategories";
      this.msPlannerToolsCategories.Size = new System.Drawing.Size(193, 22);
      this.msPlannerToolsCategories.Text = "Time Sheet &Categories";
      this.msPlannerToolsCategories.Click += new System.EventHandler(this.msPlannerToolsCategories_Click);
      // 
      // msPlannerToolsOptions
      // 
      this.msPlannerToolsOptions.Name = "msPlannerToolsOptions";
      this.msPlannerToolsOptions.Size = new System.Drawing.Size(193, 22);
      this.msPlannerToolsOptions.Text = "&Options";
      this.msPlannerToolsOptions.Click += new System.EventHandler(this.msPlannerToolsOptions_Click);
      // 
      // msPlannerHelp
      // 
      this.msPlannerHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPlannerHelpSeperator01,
            this.msPlannerHelpAbout});
      this.msPlannerHelp.Name = "msPlannerHelp";
      this.msPlannerHelp.Size = new System.Drawing.Size(40, 20);
      this.msPlannerHelp.Text = "&Help";
      // 
      // msPlannerHelpSeperator01
      // 
      this.msPlannerHelpSeperator01.Name = "msPlannerHelpSeperator01";
      this.msPlannerHelpSeperator01.Size = new System.Drawing.Size(111, 6);
      // 
      // msPlannerHelpAbout
      // 
      this.msPlannerHelpAbout.Name = "msPlannerHelpAbout";
      this.msPlannerHelpAbout.Size = new System.Drawing.Size(114, 22);
      this.msPlannerHelpAbout.Text = "&About";
      this.msPlannerHelpAbout.Click += new System.EventHandler(this.msPlannerHelpAbout_Click);
      // 
      // nciPlanner
      // 
      this.nciPlanner.ContextMenuStrip = this.cmsPlanner;
      this.nciPlanner.Icon = ((System.Drawing.Icon)(resources.GetObject("nciPlanner.Icon")));
      this.nciPlanner.Text = "Planner";
      this.nciPlanner.Visible = true;
      this.nciPlanner.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nciPlanner_MouseDoubleClick);
      // 
      // cmsPlanner
      // 
      this.cmsPlanner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsPlannerShow,
            this.cmsPlannerSeparator01,
            this.cmsPlannerAddTimeSheet,
            this.cmsPlannerAddTodo,
            this.cmsPlannerAddNotes,
            this.cmsPlannerSeparator02,
            this.cmsPlannerOptions,
            this.cmsPlannerSeparator03,
            this.cmsPlannerClose,
            this.cmsPlannerAbout});
      this.cmsPlanner.Name = "contextMenuStrip1";
      this.cmsPlanner.Size = new System.Drawing.Size(183, 176);
      this.cmsPlanner.Text = "Planner";
      // 
      // cmsPlannerShow
      // 
      this.cmsPlannerShow.Name = "cmsPlannerShow";
      this.cmsPlannerShow.Size = new System.Drawing.Size(182, 22);
      this.cmsPlannerShow.Text = "&Show";
      this.cmsPlannerShow.Click += new System.EventHandler(this.cmsPlannerShow_Click);
      // 
      // cmsPlannerSeparator01
      // 
      this.cmsPlannerSeparator01.Name = "cmsPlannerSeparator01";
      this.cmsPlannerSeparator01.Size = new System.Drawing.Size(179, 6);
      // 
      // cmsPlannerAddTimeSheet
      // 
      this.cmsPlannerAddTimeSheet.Name = "cmsPlannerAddTimeSheet";
      this.cmsPlannerAddTimeSheet.Size = new System.Drawing.Size(182, 22);
      this.cmsPlannerAddTimeSheet.Text = "Add &TimeSheet Item";
      this.cmsPlannerAddTimeSheet.Click += new System.EventHandler(this.cmsPlannerTimeSheet_Click);
      // 
      // cmsPlannerAddTodo
      // 
      this.cmsPlannerAddTodo.Name = "cmsPlannerAddTodo";
      this.cmsPlannerAddTodo.Size = new System.Drawing.Size(182, 22);
      this.cmsPlannerAddTodo.Text = "Add To&do Item";
      this.cmsPlannerAddTodo.Click += new System.EventHandler(this.cmsPlannerTodo_Click);
      // 
      // cmsPlannerAddNotes
      // 
      this.cmsPlannerAddNotes.Name = "cmsPlannerAddNotes";
      this.cmsPlannerAddNotes.Size = new System.Drawing.Size(182, 22);
      this.cmsPlannerAddNotes.Text = "Add &Notes Item";
      this.cmsPlannerAddNotes.Click += new System.EventHandler(this.cmsPlannerNotes_Click);
      // 
      // cmsPlannerSeparator02
      // 
      this.cmsPlannerSeparator02.Name = "cmsPlannerSeparator02";
      this.cmsPlannerSeparator02.Size = new System.Drawing.Size(179, 6);
      // 
      // cmsPlannerOptions
      // 
      this.cmsPlannerOptions.Name = "cmsPlannerOptions";
      this.cmsPlannerOptions.Size = new System.Drawing.Size(182, 22);
      this.cmsPlannerOptions.Text = "&Options";
      this.cmsPlannerOptions.Click += new System.EventHandler(this.cmsPlannerOptions_Click);
      // 
      // cmsPlannerSeparator03
      // 
      this.cmsPlannerSeparator03.Name = "cmsPlannerSeparator03";
      this.cmsPlannerSeparator03.Size = new System.Drawing.Size(179, 6);
      // 
      // cmsPlannerClose
      // 
      this.cmsPlannerClose.Name = "cmsPlannerClose";
      this.cmsPlannerClose.Size = new System.Drawing.Size(182, 22);
      this.cmsPlannerClose.Text = "&Close";
      this.cmsPlannerClose.Click += new System.EventHandler(this.cmsPlannerClose_Click);
      // 
      // cmsPlannerAbout
      // 
      this.cmsPlannerAbout.Name = "cmsPlannerAbout";
      this.cmsPlannerAbout.Size = new System.Drawing.Size(182, 22);
      this.cmsPlannerAbout.Text = "&About";
      this.cmsPlannerAbout.Click += new System.EventHandler(this.cmsPlannerAbout_Click);
      // 
      // PlannerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(987, 561);
      this.Controls.Add(this.tsPlanner);
      this.Controls.Add(this.msPlanner);
      this.Controls.Add(this.tbcMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.msPlanner;
      this.MaximizeBox = false;
      this.Name = "PlannerForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Planner";
      this.Resize += new System.EventHandler(this.PlannerForm_Resize);
      this.Shown += new System.EventHandler(this.PlannerForm_Shown);
      this.tbcMain.ResumeLayout(false);
      this.tbTimeSheet.ResumeLayout(false);
      this.tbTimeSheet.PerformLayout();
      this.gbDayTotalTime.ResumeLayout(false);
      this.gbDayTotalTime.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheet)).EndInit();
      this.cmsTimeSheet.ResumeLayout(false);
      this.tbTodo.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
      this.cmsTodo.ResumeLayout(false);
      this.tbNotes.ResumeLayout(false);
      this.tbNotes.PerformLayout();
      this.cmsNotes.ResumeLayout(false);
      this.tsPlanner.ResumeLayout(false);
      this.tsPlanner.PerformLayout();
      this.msPlanner.ResumeLayout(false);
      this.msPlanner.PerformLayout();
      this.cmsPlanner.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tbcMain;
    private System.Windows.Forms.TabPage tbTodo;
    private System.Windows.Forms.ContextMenuStrip cmsTodo;
    private System.Windows.Forms.ToolStripMenuItem cmsTodoAdd;
    private System.Windows.Forms.ToolStripMenuItem cmsTodoEdit;
    private System.Windows.Forms.ToolStripMenuItem cmsTodoDelete;
    private System.Windows.Forms.ImageList imgList;
    private System.Windows.Forms.TabPage tbTimeSheet;
    private System.Windows.Forms.DataGridView dgvTimeSheet;
    private System.Windows.Forms.MonthCalendar calTimeSheet;
    private System.Windows.Forms.TextBox txtQuickAddTask;
    private System.Windows.Forms.Button btnQuickAdd;
    private System.Windows.Forms.Label lblQuickTask;
    private System.Windows.Forms.ContextMenuStrip cmsTimeSheet;
    private System.Windows.Forms.ToolStripMenuItem cmsTimeSheetAdd;
    private System.Windows.Forms.ToolStripMenuItem cmsTimeSheetEdit;
    private System.Windows.Forms.ToolStripMenuItem cmsTimeSheetDelete;
    private System.Windows.Forms.ToolStripMenuItem cmsTimeSheetInsert;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.Button btnQuickEnd;
    private System.Windows.Forms.TabPage tbNotes;
    private System.Windows.Forms.Label lblNote;
    private System.Windows.Forms.TextBox txtNote;
    private System.Windows.Forms.TreeView tvNotes;
    private System.Windows.Forms.ContextMenuStrip cmsNotes;
    private System.Windows.Forms.ToolStripMenuItem cmsNotesAdd;
    private System.Windows.Forms.ToolStripMenuItem cmsNotesEdit;
    private System.Windows.Forms.ToolStripMenuItem cmsNotesDelete;
    private System.Windows.Forms.ToolStrip tsPlanner;
    private System.Windows.Forms.ToolStripButton tsbAdd;
    private System.Windows.Forms.ToolStripButton tsbEdit;
    private System.Windows.Forms.ToolStripButton tsbDelete;
    private System.Windows.Forms.ToolStripButton tsbInsert;
    private System.Windows.Forms.MenuStrip msPlanner;
    private System.Windows.Forms.ToolStripMenuItem msPlannerHelp;
    private System.Windows.Forms.ToolStripSeparator msPlannerHelpSeperator01;
    private System.Windows.Forms.ToolStripMenuItem msPlannerHelpAbout;
    private System.Windows.Forms.ToolStripMenuItem msPlannerTools;
    private System.Windows.Forms.ToolStripMenuItem msPlannerToolsOptions;
    private System.Windows.Forms.NotifyIcon nciPlanner;
    private System.Windows.Forms.ContextMenuStrip cmsPlanner;
    private System.Windows.Forms.ToolStripMenuItem cmsPlannerAbout;
    private System.Windows.Forms.ToolStripMenuItem cmsPlannerAddTimeSheet;
    private System.Windows.Forms.ToolStripMenuItem cmsPlannerAddTodo;
    private System.Windows.Forms.ToolStripMenuItem cmsPlannerAddNotes;
    private System.Windows.Forms.ToolStripSeparator cmsPlannerSeparator01;
    private System.Windows.Forms.ToolStripMenuItem cmsPlannerOptions;
    private System.Windows.Forms.ToolStripSeparator cmsPlannerSeparator02;
    private System.Windows.Forms.ToolStripMenuItem cmsPlannerClose;
    private System.Windows.Forms.ToolStripMenuItem cmsPlannerShow;
    private System.Windows.Forms.ToolStripSeparator cmsPlannerSeparator03;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFile;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTimeSheet;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTodo;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileNotes;
    private System.Windows.Forms.ToolStripSeparator msPlannerFileSeperator01;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileClose;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.GroupBox gbDayTotalTime;
    private System.Windows.Forms.DataGridView dgvTodo;
    private System.Windows.Forms.DataGridViewCheckBoxColumn TodoComplete;
    private System.Windows.Forms.DataGridViewTextBoxColumn TodoTask;
    private System.Windows.Forms.DataGridViewTextBoxColumn TodoStartDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn TodoEndDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn TodoDesc;
    private System.Windows.Forms.ToolStripMenuItem msPlannerToolsCategories;
    private System.Windows.Forms.DataGridViewTextBoxColumn TimeSheetDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn TimeSheetTask;
    private System.Windows.Forms.DataGridViewTextBoxColumn TimeSheetStartTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn TimeSheetEndTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn TimeSheetJobTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn TimeSheetMainCategory;
    private System.Windows.Forms.DataGridViewTextBoxColumn TimeSheetSubCategory;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem cmsTimeSheetViewLinkedTodo;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTimeSheetAdd;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTimeSheetInsert;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTimeSheetEdit;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTimeSheetDelete;
    private System.Windows.Forms.ToolStripSeparator msPlannerFileTimeSheetSeperator01;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTodoAdd;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTodoEdit;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileTodoDelete;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileNotesAdd;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileNotesEdit;
    private System.Windows.Forms.ToolStripMenuItem msPlannerFileNotesDelete;
  }
}

