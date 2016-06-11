using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Planner.Controls;
using Planner.Components;
using Planner.Persistence;
using Planner.Controls.Properties;

namespace Planner{
  /// <summary>
  /// Planner Form
  /// </summary>
  public partial class PlannerForm : Form {
    private TodoControl _todoControl                          = null;
    private TimeSheetControl _timeSheetControl                = null;
    private NotesControl _noteControl                         = null;
    private CategoriesControl _categoriesControl              = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="frmPlanner"/> class.
    /// </summary>
    public PlannerForm(){
      InitializeComponent();

      _todoControl                        = new TodoControl();
      _timeSheetControl                   = new TimeSheetControl();
      _noteControl                        = new NotesControl();
      _categoriesControl                  = new CategoriesControl();
      
      SetUpPlanner();
    }

    /// <summary>
    /// Shows or hide form. (Subject to Options settings)
    /// </summary>
    /// <param name="show">if set to <c>true</c> [show].</param>
    private void ShowHideForm(bool show){
      if (show) {
        if (Settings.Default.Planner_MinimizeToSystemTray) {
          this.Show();
        }
        this.WindowState      = FormWindowState.Normal;

      } else {
        this.WindowState      = FormWindowState.Minimized;
        if (Settings.Default.Planner_MinimizeToSystemTray) {
          this.Hide();
        }
      }
    }

    /// <summary>
    /// Sets the up planner.
    /// </summary>
    private void SetUpPlanner(){
      SetUpTimeSheet();
      PopulateTimeSheetTab(new SelectionRange(DateTime.Now, DateTime.Now));

      PopulateTodoTab();

      PopulateNotes();
    }

    /// <summary>
    /// Sets the tool bar access.
    /// </summary>
    private void SetToolBarAccess(){
      switch (tbcMain.SelectedTab.Name) {
        case "tbTimeSheet":
          tsbAdd.Enabled      = true;
          tsbEdit.Enabled     = true;
          tsbDelete.Enabled   = true;
          tsbInsert.Enabled   = true;

          txtQuickAddTask.Focus();
          break;
        case "tbTodo":
          tsbAdd.Enabled      = true;
          tsbEdit.Enabled     = true;
          tsbDelete.Enabled   = true;
          tsbInsert.Enabled   = false;
          break;
        case "tbNotes":
          tsbAdd.Enabled      = true;
          tsbEdit.Enabled     = false;
          tsbDelete.Enabled   = true;
          tsbInsert.Enabled   = false;
          break;
      }
    }

    /// <summary>
    /// Shows the options form.
    /// </summary>
    private void ShowOptionsForm(){
      OptionsForm frm           = new OptionsForm();
      DialogResult result       = frm.ShowDialog();

      if (result == DialogResult.Yes) {
        Settings.Default.Save();
        SetUpPlanner();
      }
    }

    /// <summary>
    /// Shows the categories form.
    /// </summary>
    private void ShowCategoriesForm(){
      CategoriesForm frm      = new CategoriesForm();
      frm.ShowDialog();
    }

    /// <summary>
    /// Shows the about form.
    /// </summary>
    private void ShowAboutForm(){
      AboutForm frm       = new AboutForm();
      frm.ShowDialog();
    }

    #region TimeSheet
      /// <summary>
      /// Sets up time sheet. (Subject to Options settings)
      /// </summary>
      private void SetUpTimeSheet(){
        if (Settings.Default.TimeSheet_ShowJobTime) {
          dgvTimeSheet.Columns["TimeSheetJobTime"].Visible            = true;
          dgvTimeSheet.Columns["TimeSheetTask"].Width = 543;

        } else {
          dgvTimeSheet.Columns["TimeSheetJobTime"].Visible            = false;
          dgvTimeSheet.Columns["TimeSheetTask"].Width = 643;
        }

        if (Settings.Default.TimeSheet_EnableCategories) {
          dgvTimeSheet.Columns["TimeSheetMainCategory"].Visible       = true;
          dgvTimeSheet.Columns["TimeSheetSubCategory"].Visible        = true;

        } else {
          dgvTimeSheet.Columns["TimeSheetMainCategory"].Visible       = false;
          dgvTimeSheet.Columns["TimeSheetSubCategory"].Visible        = false;
        }

        if (Settings.Default.Planner_CalcTotalTime) {
          gbDayTotalTime.Enabled      = true;

        } else {
          gbDayTotalTime.Enabled      = false;
        }

        txtQuickAddTask.Focus();
      }

      /// <summary>
      /// Populates the time sheet tab. (Subject to Options settings)
      /// </summary>
      /// <param name="start">The start.</param>
      /// <param name="end">The end.</param>
      private void PopulateTimeSheetTab(SelectionRange dateRange){
        DateTime[] dates            = Utilities.GetDatesIndexed(dateRange);
        int[] dayIndexes            = _timeSheetControl.GetIndexFromDate(dates);
        dgvTimeSheet.Rows.Clear();

        for (int ct1 = 0; ct1 < dayIndexes.Length; ct1++) {
          if (dayIndexes[ct1] != -1){
            if (Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList.Count > 0){
              int rows              = dgvTimeSheet.Rows.Count - 1;
              dgvTimeSheet.Rows.Add(Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList.Count);
              calTimeSheet.Tag      = Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]];

              for (int ct2 = 0; ct2 < Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList.Count; ct2++) {
                if (Persistence.Persist.Data.TimeSheetDayList[ct1].TimeSheetList[ct2].TodoTaskGuid != "") {
                  dgvTimeSheet.Rows[ct2 + rows].DefaultCellStyle.Font                   = new Font(Font, FontStyle.Bold);
                }
                dgvTimeSheet.Rows[ct2 + rows].Cells["TimeSheetDate"].Value              = Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2].Date.Day + "/" + Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2].Date.Month + "/" + Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2].Date.Year;
                dgvTimeSheet.Rows[ct2 + rows].Cells["TimeSheetTask"].Value              = _timeSheetControl.GetTimeSheetDisplayName(Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2]);
                dgvTimeSheet.Rows[ct2 + rows].Cells["TimeSheetStartTime"].Value         = Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2].StartTime.TimeOfDay.ToString().Substring(0, 8);
                dgvTimeSheet.Rows[ct2 + rows].Cells["TimeSheetEndTime"].Value           = Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2].EndTime.TimeOfDay.ToString().Substring(0, 8);
                dgvTimeSheet.Rows[ct2 + rows].Cells["TimeSheetJobTime"].Value           = Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2].JobTime.Substring(0, 8);
                dgvTimeSheet.Rows[ct2 + rows].Cells["TimeSheetMainCategory"].Value      = CategoriesControl.FindMainCategory(Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2].MainCategoryGuid);
                dgvTimeSheet.Rows[ct2 + rows].Cells["TimeSheetSubCategory"].Value       = CategoriesControl.FindSubCategory(Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2].SubCategoryGuid);
                dgvTimeSheet.Rows[ct2 + rows].Tag                                       = Persistence.Persist.Data.TimeSheetDayList[dayIndexes[ct1]].TimeSheetList[ct2];
              }
            }

          } else {
            TimeSheetDay timeSheetDay       = new TimeSheetDay();
            timeSheetDay.GUID               = Utilities.GetNewGUID();
            timeSheetDay.Day                = calTimeSheet.SelectionStart;
            timeSheetDay.TimeSheetList      = new List<TimeSheet>();
            calTimeSheet.Tag                = timeSheetDay;
          }
        }

        if (Settings.Default.Planner_CalcTotalTime) {
          lblTotal.Text                     = GetTotalTime();

        } else {
          lblTotal.Text                     = "...";
        }

        txtQuickAddTask.Text                = string.Empty;
      }

      /// <summary>
      /// Sets the context menu access.
      /// </summary>
      private void SetTimeSheetContextMenuAccess(){
        cmsTimeSheet.Items["cmsTimeSheetAdd"].Enabled                     = false;
        cmsTimeSheet.Items["cmsTimeSheetEdit"].Enabled                    = false;
        cmsTimeSheet.Items["cmsTimeSheetDelete"].Enabled                  = false;
        cmsTimeSheet.Items["cmsTimeSheetInsert"].Enabled                  = false;
        cmsTimeSheet.Items["cmsTimeSheetViewLinkedTodo"].Enabled          = false;

        if (dgvTimeSheet.SelectedRows.Count == 0) {
          cmsTimeSheet.Items["cmsTimeSheetAdd"].Enabled                   = true;

        } else if (dgvTimeSheet.SelectedRows.Count == 1) {
          cmsTimeSheet.Items["cmsTimeSheetAdd"].Enabled                   = true;

          if (dgvTimeSheet.SelectedRows[0].Index != dgvTimeSheet.Rows.Count - 1) {
            cmsTimeSheet.Items["cmsTimeSheetEdit"].Enabled                = true;
            cmsTimeSheet.Items["cmsTimeSheetDelete"].Enabled              = true;
            cmsTimeSheet.Items["cmsTimeSheetInsert"].Enabled              = true;

            TimeSheet timeSheetItem                                       = (TimeSheet)dgvTimeSheet.SelectedRows[0].Tag;
            if (timeSheetItem.TodoTaskGuid != "") {
              cmsTimeSheet.Items["cmsTimeSheetViewLinkedTodo"].Enabled    = true;
            }
          }

        } else if (dgvTimeSheet.SelectedRows.Count > 1) {
          cmsTimeSheet.Items["cmsTimeSheetAdd"].Enabled                   = true;
          cmsTimeSheet.Items["cmsTimeSheetDelete"].Enabled                = true;
        }
      }

      /// <summary>
      /// Gets the total time.
      /// </summary>
      private string GetTotalTime(){
        string result           = string.Empty;

        List<String> time       = new List<string>();
        for (int ct = 0; ct < dgvTimeSheet.Rows.Count - 1; ct++) {
          if (dgvTimeSheet.Rows[ct].Cells["TimeSheetJobTime"].Value.ToString() != "--:--:--") {
            time.Add(dgvTimeSheet.Rows[ct].Cells["TimeSheetJobTime"].Value.ToString());
          }
        }

        if (time.Count > 0) {
          result                = Utilities.CalculateTotalTime(time);
        }
        return result;
      }

      /// <summary>
      /// Adds the time sheet item from context menu.
      /// </summary>
      private void AddTimeSheetItemFromContextMenu(){
        tbcMain.SelectedTab       = tbTimeSheet;

        if (Settings.Default.TimeSheet_OpenQuickAdd) {
          txtQuickAddTask.Focus();

        } else {
          AddTimeSheetItem();
        }
      }

      /// <summary>
      /// Adds the time sheet item.
      /// </summary>
      private void AddTimeSheetItem(){
        try {
          if (tbcMain.SelectedTab != tbTimeSheet) {
            tbcMain.SelectedTab       = tbTimeSheet;
          }

          if (calTimeSheet.SelectionStart == calTimeSheet.SelectionEnd) {
            TimeSheetDay timeSheetDayItem       = (TimeSheetDay)calTimeSheet.Tag;
            TimeSheet timeSheetItem             = new TimeSheet();
            TimeSheetItemForm frm               = new TimeSheetItemForm(ref timeSheetItem, timeSheetDayItem);
            frm.ShowDialog();

            if (timeSheetItem.GUID != "") {
              DateTime result                   = _timeSheetControl.SetLastTimeSheetItemsEndTime(timeSheetItem, timeSheetDayItem);
              _timeSheetControl.Add(timeSheetItem, timeSheetDayItem);
              PopulateTimeSheetTab(calTimeSheet.SelectionRange);

              //Set timesheet items linked Todo item complete if End time is set
              if (result != new DateTime()) {                                                           //previous timesheet item
                int index                       = _timeSheetControl.FindTimeSheetDayIndex(timeSheetDayItem.GUID);
                TimeSheet prevTimeSheetItem     = Persist.Data.TimeSheetDayList[index].TimeSheetList[Persist.Data.TimeSheetDayList[index].TimeSheetList.Count - 2];
                SetLinkedTodoItemComplete(prevTimeSheetItem.TodoTaskGuid);
                PopulateTodoTab();
              }

              if ((timeSheetItem.EndTime != new DateTime()) & (timeSheetItem.TodoTaskGuid != "")) {     //new time sheet item
                SetLinkedTodoItemComplete(timeSheetItem.TodoTaskGuid);
                PopulateTodoTab();
              }
            }

          } else {
            MessageBox.Show("Please select a specific date you wish to add a TimeSheet item to.", "ADD",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Adding TimeSheet Item.", ex);
        }
      }

      /// <summary>
      /// Inserts the time sheet item.
      /// </summary>
      /// <param name="index">The index.</param>
      private void InsertTimeSheetItem(){
        try {
          if (tbcMain.SelectedTab != tbTimeSheet) {
            tbcMain.SelectedTab       = tbTimeSheet;
          }

          if (calTimeSheet.SelectionStart == calTimeSheet.SelectionEnd) {
            if (dgvTimeSheet.SelectedRows.Count == 0) {
              if (dgvTimeSheet.SelectedRows.Count > 1) {
                if (dgvTimeSheet.SelectedRows[0].Index != dgvTimeSheet.Rows.Count - 1) {
                  TimeSheetDay timeSheetDayItem       = (TimeSheetDay)calTimeSheet.Tag;
                  TimeSheet insertPosition            = (TimeSheet)dgvTimeSheet.SelectedRows[0].Tag;
                  TimeSheet timeSheetItem             = new TimeSheet();
                  TimeSheetItemForm frm               = new TimeSheetItemForm(ref timeSheetItem, timeSheetDayItem);
                  DialogResult result                 = frm.ShowDialog();

                  if (timeSheetItem.Task != "") {
                    _timeSheetControl.Insert(timeSheetItem, timeSheetDayItem, insertPosition);
                    PopulateTimeSheetTab(calTimeSheet.SelectionRange);

                    //Set linked Todo item complete
                    if ((timeSheetItem.EndTime != new DateTime()) & (timeSheetItem.TodoTaskGuid != "")) {
                      SetLinkedTodoItemComplete(timeSheetItem.TodoTaskGuid);
                      PopulateTodoTab();
                    }
                  }
                }

              } else {
                MessageBox.Show("Please select only one Time Sheet Item you wish to insert above.", "INSERT",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }

            } else {
              MessageBox.Show("Please select the Time Sheet Item to insert above.", "INSERT",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

          } else {
            MessageBox.Show("Please select the specific date you wish to insert a Time Sheet Item above.", "INSERT",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Inserting TimeSheet Item.", ex);
        }
      }

      /// <summary>
      /// Edits the time sheet item.
      /// </summary>
      /// <param name="index">The index.</param>
      private void EditTimeSheetItem(){
        bool status                             = false;
        try {
          if (tbcMain.SelectedTab != tbTimeSheet) {
            tbcMain.SelectedTab       = tbTimeSheet;
          }

          if (calTimeSheet.SelectionStart == calTimeSheet.SelectionEnd) {
            if ((dgvTimeSheet.SelectedRows.Count > 0) & (dgvTimeSheet.Rows.Count != 1)) {
              if (dgvTimeSheet.SelectedRows.Count == 1) {
                if (dgvTimeSheet.SelectedRows[0].Index != dgvTimeSheet.Rows.Count - 1)
                {
                  TimeSheetDay timeSheetDayItem     = (TimeSheetDay)calTimeSheet.Tag;
                  TimeSheet timeSheetItem           = (TimeSheet)dgvTimeSheet.SelectedRows[0].Tag;
                  TimeSheetItemForm frm             = new TimeSheetItemForm(ref timeSheetItem, timeSheetDayItem);
                  frm.ShowDialog();

                  if (timeSheetItem.GUID != null) {
                    status                          = _timeSheetControl.Edit(timeSheetItem, timeSheetDayItem);
                    PopulateTimeSheetTab(calTimeSheet.SelectionRange);

                    //Set timesheet items linked Todo item complete if End time is set
                    if ((timeSheetItem.EndTime != new DateTime()) & (timeSheetItem.TodoTaskGuid != "")) {
                      SetLinkedTodoItemComplete(timeSheetItem.TodoTaskGuid);
                      PopulateTodoTab();
                    }
                  }
                }

              } else {
                MessageBox.Show("Please select only one Time Sheet Item to edit.", "EDIT",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }

            } else {
              MessageBox.Show("Please select the Time Sheet Item you wish to edit.", "EDIT",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

          } else {
            MessageBox.Show("Please select the specific date you wish to edit a Time Sheet item for.", "EDIT",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Editing TimeSheet Item.", ex);
        }
      }

      /// <summary>
      /// Deletes the time sheet item.
      /// </summary>
      /// <param name="index">The index.</param>
      private void DeleteTimeSheetItem(){
        try {
          if (tbcMain.SelectedTab != tbTimeSheet) {
            tbcMain.SelectedTab       = tbTimeSheet;
          }

          //unselect last row to prevent exception being thrown when using that rows Tag
          dgvTimeSheet.Rows[dgvTimeSheet.Rows.Count - 1].Selected       = false;

          if (calTimeSheet.SelectionStart == calTimeSheet.SelectionEnd) {
            if ((dgvTimeSheet.SelectedRows.Count > 0) & (dgvTimeSheet.Rows.Count != 1)) {
              DialogResult result;

              if (dgvTimeSheet.SelectedRows.Count > 1) {
                result                          = MessageBox.Show("Are you sure you want to remove these Tasks.", "DELETE",
                                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              } else {
                result                          = MessageBox.Show("Are you sure you want to remove this Task.", "DELETE",
                                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              }
              if (result == DialogResult.Yes) {
                TimeSheetDay timeSheetDay       = (TimeSheetDay)calTimeSheet.Tag;

                for (int ct = 0; ct < dgvTimeSheet.SelectedRows.Count; ct++) {
                  string guid                   = ((TimeSheet)dgvTimeSheet.SelectedRows[ct].Tag).GUID;
                  _timeSheetControl.Delete(guid, timeSheetDay);
                }
                PopulateTimeSheetTab(calTimeSheet.SelectionRange);
              }

            } else {
              MessageBox.Show("Please select the Time Sheet Item(s) you wish to delete.", "DELETE",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

          } else {
            MessageBox.Show("Please select the specific date you wish to delete Time Sheet Item(s) from.", "DELETE",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Deleting TimeSheet Item.", ex);
        }
      }

      /// <summary>
      /// Quicks the add time sheet item.
      /// </summary>
      private void QuickAddTimeSheetItem(){
        try {//todo// test there is an error when adding the first quick add item
          TimeSheetDay timeSheetDay                 = (TimeSheetDay)calTimeSheet.Tag;
          TimeSheet timeSheetItem                   = new TimeSheet();

          timeSheetItem.GUID                        = Utilities.GetNewGUID();
          timeSheetItem.Date                        = calTimeSheet.SelectionRange.Start;
          timeSheetItem.Task                        = txtQuickAddTask.Text;
          timeSheetItem.TodoTaskGuid                = "";
          timeSheetItem.MainCategoryGuid            = "";
          timeSheetItem.SubCategoryGuid             = "";
          timeSheetItem.StartTime                   = _timeSheetControl.SetLastTimeSheetItemsEndTime(timeSheetDay);
          timeSheetItem.EndTime                     = new DateTime();
          timeSheetItem.JobTime                     = TimeSheetControl.CalculateJobTime(timeSheetItem);

          _timeSheetControl.Add(timeSheetItem, timeSheetDay);
          PopulateTimeSheetTab(calTimeSheet.SelectionRange);

          //Set previous timesheet items linked Todo item complete if End time is set
          int index                         = _timeSheetControl.FindTimeSheetDayIndex(timeSheetDay.GUID);
          if ( Persist.Data.TimeSheetDayList[index].TimeSheetList.Count > 1) {
            TimeSheet prevTimeSheetItem       = Persist.Data.TimeSheetDayList[index].TimeSheetList[Persist.Data.TimeSheetDayList[index].TimeSheetList.Count - 2];

            if (prevTimeSheetItem.EndTime != new DateTime()) {
              SetLinkedTodoItemComplete(prevTimeSheetItem.TodoTaskGuid);
              PopulateTodoTab();
            }
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Adding Quick TimeSheet Item", ex);
        }
      }

      /// <summary>
      /// Quicks the end time sheet item.
      /// </summary>
      private void QuickEndTimeSheetItem(){
        TimeSheetDay timeSheetDay       = (TimeSheetDay)calTimeSheet.Tag;
        _timeSheetControl.SetLastTimeSheetItemsEndTime(timeSheetDay);
        PopulateTimeSheetTab(calTimeSheet.SelectionRange);

        //Set linked Todo item complete
        int index = _timeSheetControl.FindTimeSheetDayIndex(timeSheetDay.GUID);
        TimeSheet timeSheetItem = Persist.Data.TimeSheetDayList[index].TimeSheetList[Persist.Data.TimeSheetDayList[index].TimeSheetList.Count - 1];
        SetLinkedTodoItemComplete(timeSheetItem.TodoTaskGuid);
        PopulateTodoTab();
      }

      /// <summary>
      /// Shows the linked todo item.
      /// </summary>
      private void ShowLinkedTodoItem(){
        bool exists                                 = false;
        TimeSheet timeSheetItem                     = (TimeSheet)dgvTimeSheet.SelectedRows[0].Tag;
        for (int ct = 0; ct < dgvTodo.Rows.Count - 1; ct++) {
          ToDo todoItem                             = (ToDo)dgvTodo.Rows[ct].Tag;

          if (todoItem.GUID == timeSheetItem.TodoTaskGuid) {
            dgvTodo.Rows[ct].Cells[1].Selected      = true;
            exists                                  = true;
          }
        }

        if (exists) {
          tbcMain.SelectedTab                         = tbTodo;
          EditTodoItem();

        } else {
          MessageBox.Show("TodoItem linked to this TimeSheet item has been deleted.", "VIEW LINKED TODO ITEM",
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }

      #region TimeSheet Interface
        /// <summary>
        /// Handles the Opening event of the cmsTimeSheet control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void cmsTimeSheet_Opening(object sender, CancelEventArgs e) {
          SetTimeSheetContextMenuAccess();
        }

        /// <summary>
        /// Handles the Click event of the cmsTimeSheetAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsTimeSheetAdd_Click(object sender, EventArgs e) {
          AddTimeSheetItem();
        }

        /// <summary>
        /// Handles the Click event of the cmsTimeSheetEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsTimeSheetEdit_Click(object sender, EventArgs e) {
          EditTimeSheetItem();
        }

        /// <summary>
        /// Handles the Click event of the cmsTimeSheetDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsTimeSheetDelete_Click(object sender, EventArgs e) {
          DeleteTimeSheetItem();
        }

        /// <summary>
        /// Handles the Click event of the cmsTimeSheetInsert control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsTimeSheetInsert_Click(object sender, EventArgs e) {
          InsertTimeSheetItem();
        }

        /// <summary>
        /// Handles the Click event of the cmsTimeSheetViewLinkedTodo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsTimeSheetViewLinkedTodo_Click(object sender, EventArgs e) {
          ShowLinkedTodoItem();
        }

        /// <summary>
        /// Handles the Click event of the btnQuickAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnQuickAdd_Click(object sender, EventArgs e) {
          if (txtQuickAddTask.Text != "") {
            QuickAddTimeSheetItem();
          }
        }

        /// <summary>
        /// Handles the Click event of the btnQuickEnd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnQuickEnd_Click(object sender, EventArgs e) {
          QuickEndTimeSheetItem();
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the dgvTimeSheet control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvTimeSheet_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
          if (e.RowIndex == (dgvTimeSheet.Rows.Count - 1)) {
            AddTimeSheetItem();
          } else {
            EditTimeSheetItem();
          }
        }

        /// <summary>
        /// Handles the DateChanged event of the calTimeSheet control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DateRangeEventArgs"/> instance containing the event data.</param>
        private void calTimeSheet_DateChanged(object sender, DateRangeEventArgs e) {
          PopulateTimeSheetTab(new SelectionRange(e.Start, e.End));
        }

        /// <summary>
        /// Handles the KeyPress event of the txtQuickAddTask control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtQuickAddTask_KeyPress(object sender, KeyPressEventArgs e) {
          if ((e.KeyChar.ToString() == "\r") && (txtQuickAddTask.Text != "")) {
            QuickAddTimeSheetItem();
          }
        }
      #endregion TimeSheet Interface
    #endregion TimeSheet

    #region Todo
      /// <summary>
      /// Populates the todo tab.
      /// </summary>
      private void PopulateTodoTab(){
        dgvTodo.Rows.Clear();

        if (Persistence.Persist.Data.TodoList.Count > 0){
          dgvTodo.Rows.Add(Persistence.Persist.Data.TodoList.Count);

          for (int ct = 0; ct < Persistence.Persist.Data.TodoList.Count; ct++) {
            if (Persistence.Persist.Data.TodoList[ct].Complete) {
              dgvTodo.Rows[ct].DefaultCellStyle.Font        = new Font(Font, FontStyle.Strikeout);
            }
            dgvTodo.Rows[ct].Cells["TodoComplete"].Value    = Persistence.Persist.Data.TodoList[ct].Complete;
            dgvTodo.Rows[ct].Cells["TodoTask"].Value        = Persistence.Persist.Data.TodoList[ct].Task;
            dgvTodo.Rows[ct].Cells["TodoDesc"].Value        = _todoControl.GetTodoItemDisplayName(Persistence.Persist.Data.TodoList[ct]);
            dgvTodo.Rows[ct].Cells["TodoStartDate"].Value   = Persistence.Persist.Data.TodoList[ct].StartDate.ToString();
            dgvTodo.Rows[ct].Cells["TodoEndDate"].Value     = Persistence.Persist.Data.TodoList[ct].DueDate.ToString();
            dgvTodo.Rows[ct].Tag                            = Persistence.Persist.Data.TodoList[ct];
          }
        }
      }

      /// <summary>
      /// Sets the todo context menu access.
      /// </summary>
      private void SetTodoContextMenuAccess(){
        cmsTodo.Items["cmsTodoAdd"].Enabled             = false;
        cmsTodo.Items["cmsTodoEdit"].Enabled            = false;
        cmsTodo.Items["cmsTodoDelete"].Enabled          = false;

        if (dgvTodo.SelectedRows.Count == 0) {
          cmsTodo.Items["cmsTodoAdd"].Enabled           = true;

        } else if (dgvTodo.SelectedRows.Count == 1) {
          cmsTodo.Items["cmsTodoAdd"].Enabled           = true;

          if (dgvTodo.SelectedRows[0].Index != dgvTodo.Rows.Count - 1) {
            cmsTodo.Items["cmsTodoEdit"].Enabled        = true;
            cmsTodo.Items["cmsTodoDelete"].Enabled      = true;
          }

        } else if (dgvTodo.SelectedRows.Count > 1) {
          cmsTodo.Items["cmsTodoAdd"].Enabled           = true;
          cmsTodo.Items["cmsTodoDelete"].Enabled        = true;
        }
      }

      /// <summary>
      /// Adds the todo item.
      /// </summary>
      private void AddTodoItem(){
        try {
          if (tbcMain.SelectedTab != tbTodo) {
            tbcMain.SelectedTab       = tbTodo;
          }

          ToDo todoItem         = new ToDo();
          TodoItemForm frm      = new TodoItemForm(ref todoItem);
          frm.ShowDialog();

          if (todoItem.GUID != "") {
            _todoControl.Add(todoItem);
            PopulateTodoTab();
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Adding TodoList Item!", ex);
        }
      }

      /// <summary>
      /// Edits the todo item.
      /// </summary>
      private void EditTodoItem(){
        bool status                 = false;

        try {
          if (tbcMain.SelectedTab != tbTodo) {
            tbcMain.SelectedTab       = tbTodo;
          }

          if ((dgvTodo.SelectedRows.Count > 0) & (dgvTodo.Rows.Count != 1)) {
            if (dgvTodo.SelectedRows.Count == 1) {
              if (dgvTodo.SelectedRows[0].Index != dgvTodo.Rows.Count - 1){
                ToDo todoItem         = (ToDo)dgvTodo.SelectedRows[0].Tag;
                TodoItemForm frm      = new TodoItemForm(ref todoItem);
                frm.ShowDialog();

                if (todoItem.GUID != null) {
                  status              = _todoControl.Edit(todoItem);

                  if (status) {
                    PopulateTodoTab();

                  } else {
                    throw new Exception();
                  }
                }
              }

            } else {
              MessageBox.Show("Please select only one Todo Item you wish to edit.", "EDIT",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

          } else {
            MessageBox.Show("Please select the Todo Item you wish to edit.", "EDIT",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Editing TimeSheet Item.", ex);
        }
      }

      /// <summary>
      /// Deletes the todo item.
      /// </summary>
      private void DeleteTodoItem(){
        try {
          if (tbcMain.SelectedTab != tbTodo) {
            tbcMain.SelectedTab       = tbTodo;
          }

          //unselect last row to prevent exception being thrown when using that rows Tag
          dgvTodo.Rows[dgvTodo.Rows.Count - 1].Selected       = false;

          if ((dgvTodo.SelectedRows.Count > 0) & (dgvTodo.Rows.Count != 1)) {
            DialogResult result;

            if (dgvTodo.SelectedRows.Count > 1) {
              result              = MessageBox.Show("Are you sure you want to remove these Tasks.", "DELETE",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            } else {
              result              = MessageBox.Show("Are you sure you want to remove this Task.", "DELETE",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (result == DialogResult.Yes) {
              for (int ct = 0; ct < dgvTodo.SelectedRows.Count; ct++) {
                string guid       = ((ToDo)dgvTodo.SelectedRows[ct].Tag).GUID;
                _todoControl.Delete(guid);
              }
              PopulateTodoTab();
            }
          } else {
            MessageBox.Show("Please select the Todo Item(s) you wish to delete.", "DELETE",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Deleting TodoList Item.", ex);
        }
      }

      /// <summary>
      /// Marks the task complete.
      /// </summary>
      /// <param name="index">The index.</param>
      private void ChangeTaskStatus(int index){
        bool isComplete;

        try {
          string guid                 = ((ToDo)dgvTodo.Rows[index].Tag).GUID;
          isComplete                  = _todoControl.ChangeTaskStatus(guid);

          int todoIndex               = _todoControl.FindTodoIndex(guid);
          dgvTodo.Rows[index].Tag     = Persistence.Persist.Data.TodoList[todoIndex];

          SetRowFontStyle(isComplete, index);

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error changing task status", ex);
        }
      }

      /// <summary>
      /// Sets the row font style.
      /// </summary>
      /// <param name="isCompleted">if set to <c>true</c> [is completed].</param>
      private void SetRowFontStyle(bool isCompleted, int index){
        if (isCompleted) {
          dgvTodo.Rows[index].DefaultCellStyle.Font      = new Font(Font, FontStyle.Strikeout);

        } else {
          dgvTodo.Rows[index].DefaultCellStyle.Font      = Font;
        }
      }

      /// <summary>
      /// Sets the linked todo item complete. (Subject to Options settings)
      /// </summary>
      private void SetLinkedTodoItemComplete(string guid){
        if (Settings.Default.TimeSheet_SetTodoCompleteOnEndTime) {
          int index                     = _todoControl.FindTodoIndex(guid);

          if (index != -1) {
            if (!Persist.Data.TodoList[index].Complete) {

              DialogResult result       = MessageBox.Show("Would you like to mark the Linked Todo Item '" +
                                                          Persist.Data.TodoList[index].Task + "' as Complete", "COMPLETE",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              if (result == DialogResult.Yes) {
                _todoControl.ChangeTaskStatus(guid);
              }
            }
          }
        }
      }

      #region Todo Interface
        /// <summary>
        /// Handles the Opening event of the cmsTodo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void cmsTodo_Opening(object sender, CancelEventArgs e) {
          SetTodoContextMenuAccess();
        }

        /// <summary>
        /// Handles the Click event of the addTodoItemToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsTodoAdd_Click(object sender, EventArgs e){
          AddTodoItem();
        }

        /// <summary>
        /// Handles the Click event of the editTodoItemToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsTodoEdit_Click(object sender, EventArgs e){
          EditTodoItem();
        }

        /// <summary>
        /// Handles the Click event of the deleteToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsTodoDelete_Click(object sender, EventArgs e){
          DeleteTodoItem();
        }

        /// <summary>
        /// Handles the CellContentClick event of the dgvTodo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvTodo_CellContentClick(object sender, DataGridViewCellEventArgs e) {
          if (e.ColumnIndex == 0) {
            if (dgvTodo.Rows[e.RowIndex].Tag != null){
              ChangeTaskStatus(e.RowIndex);

            } else {
              dgvTodo.Rows.Remove(dgvTodo.Rows[dgvTodo.Rows.Count - 2]);
            }
          }
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the dgvTodo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvTodo_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
          if (e.RowIndex == (dgvTodo.Rows.Count - 1)) {
            AddTodoItem();

          } else {
            EditTodoItem();
          }
        }
      #endregion Todo Interface
    #endregion Todo

    #region Notes
      /// <summary>
      /// Populates the notes.
      /// </summary>
      private void PopulateNotes(){
        tvNotes.Nodes.Clear();
        txtNote.Clear();
        
        if (Persistence.Persist.Data.NotesList.Count > 0) {
          for (int ct = 0; ct < Persistence.Persist.Data.NotesList.Count; ct++) {
            TreeNode treeNode = new TreeNode(_noteControl.GetNoteDisplayName(Persistence.Persist.Data.NotesList[ct]));
            treeNode.Tag = Persistence.Persist.Data.NotesList[ct];
            tvNotes.Nodes.Add(treeNode);
          }
        }
      }

      /// <summary>
      /// Sets the todo context menu access.
      /// </summary>
      private void SetNotesContextMenuAccess(){       
        cmsNotes.Items["cmsNotesAdd"].Enabled           = false;
        cmsNotes.Items["cmsNotesEdit"].Enabled          = false;
        cmsNotes.Items["cmsNotesDelete"].Enabled        = false;

        if (tvNotes.SelectedNode == null) {
          cmsNotes.Items["cmsNotesAdd"].Enabled         = true;

        } else {
          cmsNotes.Items["cmsNotesAdd"].Enabled         = true;
          cmsNotes.Items["cmsNotesEdit"].Enabled        = true;
          cmsNotes.Items["cmsNotesDelete"].Enabled      = true;
        }
      }

      /// <summary>
      /// Displays the note. (Subject to Options settings)
      /// </summary>
      private void DisplayNote(){
        txtNote.Text = _noteControl.GetNote((Notes)tvNotes.SelectedNode.Tag);
      }

      /// <summary>
      /// Adds the notes item.
      /// </summary>
      private void AddNotesItem(){
        try {
          if (tbcMain.SelectedTab != tbNotes) {
            tbcMain.SelectedTab = tbNotes;
          }

          Notes noteItem          = new Notes();
          NotesItemForm frm       = new NotesItemForm(ref noteItem);
          frm.ShowDialog();

          if (noteItem.GUID != "") {
            _noteControl.Add(noteItem);
            PopulateNotes();
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Adding Note!", ex);
        }
      }

      /// <summary>
      /// Edits the notes item.
      /// </summary>
      private void EditNotesItem(){
        bool status                 = false;

        try {
          if (tbcMain.SelectedTab != tbNotes) {
            tbcMain.SelectedTab = tbNotes;
          }

          if (tvNotes.SelectedNode != null) {
            Notes noteItem          = (Notes)tvNotes.SelectedNode.Tag;
            NotesItemForm frm       = new NotesItemForm(ref noteItem);
            frm.ShowDialog();

            if (noteItem.GUID != null) {
              status                = _noteControl.Edit(noteItem);

              if (status) {
                PopulateNotes();

              } else {
                throw new Exception();
              }
            }

          } else {
            MessageBox.Show("Please select the note you wish to edit.", "EDIT",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Editing TimeSheet Item.", ex);
        }
      }

      /// <summary>
      /// Deletes the notes item.
      /// </summary>
      private void DeleteNotesItem(){
        try {
          if (tbcMain.SelectedTab != tbNotes) {
            tbcMain.SelectedTab = tbNotes;
          }

          if (tvNotes.SelectedNode != null) {
            DialogResult result;
            result              = MessageBox.Show("Are you sure you want to remove this Note.", "DELETE",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
              string guid       = ((Notes)tvNotes.SelectedNode.Tag).GUID;
              _noteControl.Delete(guid);
              PopulateNotes();
            }

          } else {
            MessageBox.Show("Please select the Note{s} you wish to delete.", "DELETE",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } catch (Exception ex) {
          Utilities.ShowErrorMessage("Error Deleting TodoList Item.", ex);
        }
      }

      #region Notes Interface
        /// <summary>
        /// Handles the Opening event of the cmsNotes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
        private void cmsNotes_Opening(object sender, CancelEventArgs e) {
          SetNotesContextMenuAccess();
        }

        /// <summary>
        /// Handles the Click event of the cmsNotesAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsNotesAdd_Click(object sender, EventArgs e) {
          AddNotesItem();
        }

        /// <summary>
        /// Handles the Click event of the cmsNotesEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsNotesEdit_Click(object sender, EventArgs e) {
          EditNotesItem();
        }

        /// <summary>
        /// Handles the Click event of the cmsNotesDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cmsNotesDelete_Click(object sender, EventArgs e) {
          DeleteNotesItem();
        }

        /// <summary>
        /// Handles the DoubleClick event of the txtNote control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtNote_DoubleClick(object sender, EventArgs e) {
          if (txtNote.Text == "") {
            AddNotesItem();

          } else {
            EditNotesItem();
          }
        }

        /// <summary>
        /// Handles the AfterSelect event of the tvNotes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.TreeViewEventArgs"/> instance containing the event data.</param>
        private void tvNotes_AfterSelect(object sender, TreeViewEventArgs e) {
          DisplayNote();
        }

        /// <summary>
        /// Handles the DoubleClick event of the tvNotes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tvNotes_DoubleClick(object sender, EventArgs e) {
          EditNotesItem();
        }
      #endregion Notes Interface
    #endregion Notes

    #region Interface
    /// <summary>
    /// Handles the Shown event of the frmPlanner control. (Subject to Options settings)
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void PlannerForm_Shown(object sender, EventArgs e) {
      if (Settings.Default.Planner_HideOnStartup) {
        ShowHideForm(false);
      }
    }

    /// <summary>
    /// Handles the MouseDoubleClick event of the nciPlanner control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
    private void nciPlanner_MouseDoubleClick(object sender, MouseEventArgs e) {
        ShowHideForm(true);
    }

    /// <summary>
    /// Handles the Resize event of the frmPlanner control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void PlannerForm_Resize(object sender, EventArgs e) {
      if (this.WindowState == FormWindowState.Normal) {
        ShowHideForm(true);

      } else if (this.WindowState == FormWindowState.Minimized) {
        ShowHideForm(false);
      }
    }

    /// <summary>
    /// Handles the Click event of the tsbAdd control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void tsbAdd_Click(object sender, EventArgs e) {
      switch (tbcMain.SelectedTab.Name) {
        case "tbTimeSheet":
          AddTimeSheetItem();
          break;
        case "tbTodo":
          AddTodoItem();
          break;
        case "tbNotes":
          AddNotesItem();
          break;
      }
    }

    /// <summary>
    /// Handles the Click event of the tsbInsert control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void tsbInsert_Click(object sender, EventArgs e) {
      switch (tbcMain.SelectedTab.Name) {
        case "tbTimeSheet":
          InsertTimeSheetItem();
          break;
      }
    }

    /// <summary>
    /// Handles the Click event of the tsbEdit control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void tsbEdit_Click(object sender, EventArgs e) {
      switch (tbcMain.SelectedTab.Name) {
        case "tbTimeSheet":
          EditTimeSheetItem();
          break;
        case "tbTodo":
          EditTodoItem();
          break;
        case "tbNotes":
          EditNotesItem();
          break;
      }
    }

    /// <summary>
    /// Handles the Click event of the tsbDelete control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void tsbDelete_Click(object sender, EventArgs e) {
      switch (tbcMain.SelectedTab.Name) {
        case "tbTimeSheet":
          DeleteTimeSheetItem();
          break;
        case "tbTodo":
          DeleteTodoItem();
          break;
        case "tbNotes":
          DeleteNotesItem();
          break;
      }
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the tbcMain control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void tbcMain_SelectedIndexChanged(object sender, EventArgs e) {
      SetToolBarAccess();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileClose control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileClose_Click(object sender, EventArgs e) {
      this.Close();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileTimeSheetAdd control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileTimeSheetAdd_Click(object sender, EventArgs e) {
      AddTimeSheetItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileTimeSheetEdit control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileTimeSheetEdit_Click(object sender, EventArgs e) {
      EditTimeSheetItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileTimeSheetDelete control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileTimeSheetDelete_Click(object sender, EventArgs e) {
      DeleteTimeSheetItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileTimeSheetInsert control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileTimeSheetInsert_Click(object sender, EventArgs e) {
      InsertTimeSheetItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileTodoAdd control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileTodoAdd_Click(object sender, EventArgs e) {
      AddTodoItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileTodoEdit control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileTodoEdit_Click(object sender, EventArgs e) {
      EditTodoItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileTodoDelete control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileTodoDelete_Click(object sender, EventArgs e) {
      DeleteTodoItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileNotesAdd control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileNotesAdd_Click(object sender, EventArgs e) {
      AddNotesItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileNotesEdit control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileNotesEdit_Click(object sender, EventArgs e) {
      EditNotesItem();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerFileNotesDelete control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerFileNotesDelete_Click(object sender, EventArgs e) {
      DeleteNotesItem();
    }

    /// <summary>
    /// Handles the Click event of the msMainToolsOptions control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerToolsOptions_Click(object sender, EventArgs e) {
      ShowOptionsForm();
    }

    /// <summary>
    /// Handles the Click event of the msPlannerToolsCategories control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerToolsCategories_Click(object sender, EventArgs e) {
      ShowCategoriesForm();
    }

    /// <summary>
    /// Handles the Click event of the msMainHelpAbout control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void msPlannerHelpAbout_Click(object sender, EventArgs e) {
      ShowAboutForm();
    }

    /// <summary>
    /// Handles the Click event of the cmsPlannerShow control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void cmsPlannerShow_Click(object sender, EventArgs e) {
      ShowHideForm(true);
    }

    /// <summary>
    /// Handles the Click event of the cmsPlannerTimeSheet control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void cmsPlannerTimeSheet_Click(object sender, EventArgs e) {
      AddTimeSheetItemFromContextMenu();
      ShowHideForm(true);
    }

    /// <summary>
    /// Handles the Click event of the cmsPlannerTodo control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void cmsPlannerTodo_Click(object sender, EventArgs e) {
      AddTodoItem();
      ShowHideForm(true);
    }

    /// <summary>
    /// Handles the Click event of the cmsPlannerNotes control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void cmsPlannerNotes_Click(object sender, EventArgs e) {
      AddNotesItem();
      ShowHideForm(true);
    }

    /// <summary>
    /// Handles the Click event of the cmsPlannerSettings control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void cmsPlannerOptions_Click(object sender, EventArgs e) {
      ShowHideForm(true);
      ShowOptionsForm();
    }

    /// <summary>
    /// Handles the Click event of the cmsPlannerClose control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void cmsPlannerClose_Click(object sender, EventArgs e) {
      this.Close();
    }

    /// <summary>
    /// Handles the Click event of the cmsPlannerAbout control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void cmsPlannerAbout_Click(object sender, EventArgs e) {
      ShowAboutForm();
    }
    #endregion Interface
  }
}