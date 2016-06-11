using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Planner.Components;
using Planner.Persistence;

namespace Planner.Controls {
  /// <summary>
  /// TimeSheet item Form
  /// </summary>
  public partial class TimeSheetItemForm : Form {
    private TimeSheet _timeSheetItem                      = null;
    private TimeSheetDay _timeSheetDayItem                = null;
    private CategoriesControl _categoriesControl          = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="frmTimeSheetItem"/> class.
    /// </summary>
    /// <param name="timeSheet">The time sheet.</param>
    public TimeSheetItemForm(ref TimeSheet timeSheet, TimeSheetDay timeSheetDay) {
      InitializeComponent();
      _timeSheetItem            = timeSheet;
      _timeSheetDayItem         = timeSheetDay;
      _categoriesControl        = new CategoriesControl();
      SetUpTimeSheetItemForm();
    }

    /// <summary>
    /// Sets the up time sheet item form. (Subject to Options settings)
    /// </summary>
    private void SetUpTimeSheetItemForm(){
      if (!Properties.Settings.Default.TimeSheet_EnableCategories) {
        cboMainCategory.Enabled = false;
        cboSubCategory.Enabled = false;

      } else {
        PopulateCategories();
      }

      if (!Properties.Settings.Default.TimeSheet_EnableTodoItemLink) {
        cboTodoLink.Enabled = false;

      } else {
        PopulateTodoItems();
      }

      if (_timeSheetItem.Task != ""){
        PopulateTimeSheet();
      }
    }

    /// <summary>
    /// Populates the categories.
    /// </summary>
    private void PopulateCategories(){
      for (int ct = 0; ct < Persist.Data.MainCategoriesList.Count; ct++) {
        cboMainCategory.Items.Add(Persist.Data.MainCategoriesList[ct].Category);
      }

      for (int ct = 0; ct < Persist.Data.SubCategoriesList.Count; ct++) {
        cboSubCategory.Items.Add(Persist.Data.SubCategoriesList[ct].Category);
      }
    }

    /// <summary>
    /// Populates the todo items.
    /// </summary>
    private void PopulateTodoItems(){
      for (int ct = 0; ct < Persist.Data.TodoList.Count; ct++) {
        if (!Persist.Data.TodoList[ct].Complete) {
          cboTodoLink.Items.Add(Persist.Data.TodoList[ct].Task);
        }
      }
    }

    /// <summary>
    /// Populates the time sheet.
    /// </summary>
    private void PopulateTimeSheet(){
      txtTask.Text              = Utilities.CleanMultiLines(_timeSheetItem.Task);
      cboTodoLink.Text          = TodoControl.FindTodoItem(_timeSheetItem.TodoTaskGuid);
      cboMainCategory.Text      = CategoriesControl.FindMainCategory(_timeSheetItem.MainCategoryGuid);
      cboSubCategory.Text       = CategoriesControl.FindSubCategory(_timeSheetItem.SubCategoryGuid);
      mtxtStartTime.Text        = _timeSheetItem.StartTime.TimeOfDay.ToString();
      mtxtEndTime.Text          = _timeSheetItem.EndTime.TimeOfDay.ToString();
    }

    /// <summary>
    /// Sets the time sheet task.
    /// </summary>
    private void SetTimeSheetTask(){
      if (txtTask.Text == "") {
        txtTask.Text = cboTodoLink.SelectedItem.ToString();
      }
    }

    /// <summary>
    /// Saves this instance.
    /// </summary>
    private void Save(){
      bool status = false;

      if ((txtTask.Text != "") && (mtxtStartTime.Text != "  :  :")){
        if (_timeSheetItem.GUID == "") {
          _timeSheetItem.GUID                      = Utilities.GetNewGUID();
        }

        _timeSheetItem.Date                        = _timeSheetDayItem.Day;
        _timeSheetItem.Task                        = txtTask.Text;
        _timeSheetItem.TodoTaskGuid                = TodoControl.FindTodoItemsGuid(cboTodoLink.Text);
        _timeSheetItem.MainCategoryGuid            = CategoriesControl.FindMainCategoriesGuid(cboMainCategory.Text);
        _timeSheetItem.SubCategoryGuid             = CategoriesControl.FindSubCategoriesGuid(cboSubCategory.Text);
        _timeSheetItem.StartTime                   = Convert.ToDateTime(mtxtStartTime.Text);

        if ((mtxtEndTime.Text != "  :  :") & (mtxtEndTime.Text != "00:00:00")) {
          _timeSheetItem.EndTime                   = Convert.ToDateTime(mtxtEndTime.Text);
          _timeSheetItem.EndTime                   = _timeSheetItem.EndTime.AddSeconds(1.0);              //to ensure that the start date is before the end date
          _timeSheetItem.JobTime                   = TimeSheetControl.CalculateJobTime(_timeSheetItem);

          if (_timeSheetItem.JobTime != "--:--:--") {
            status = true;

          } else {
            status = false;
            MessageBox.Show("End time is before Start time.", "SAVE",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

        } else {
          _timeSheetItem.EndTime       = new DateTime();
          _timeSheetItem.JobTime       = "--:--:--";
          status = true;
        }

      } else {
        MessageBox.Show("Please ensure that there is a Task & Start Time!", "SAVE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	    }

      if (status) {
        this.Close();
      }
    }

    /// <summary>
    /// Clears the time sheet object.
    /// </summary>
    private void ClearTimeSheetObject(){
      _timeSheetItem = null;
    }

    /// <summary>
    /// Closes the form.
    /// </summary>
    private void CloseForm(){
      ClearTimeSheetObject();
      this.Close();
    }

    #region Interface
      /// <summary>
      /// Handles the Click event of the btnSave control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnSave_Click(object sender, EventArgs e) {
        Save();
      }

      /// <summary>
      /// Handles the Click event of the btnCancel control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnCancel_Click(object sender, EventArgs e) {
        CloseForm();
      }

      /// <summary>
      /// Handles the Click event of the btnStartNow control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnStartNow_Click(object sender, EventArgs e) {
        mtxtStartTime.Text      = DateTime.Now.TimeOfDay.ToString();
      }

      /// <summary>
      /// Handles the Click event of the btnEndNow control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnEndNow_Click(object sender, EventArgs e) {
        mtxtEndTime.Text        = DateTime.Now.TimeOfDay.ToString();
      }

      /// <summary>
      /// Handles the Enter event of the txtTask control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void txtTask_Enter(object sender, EventArgs e) {
        txtTask.SelectAll();
      }

      /// <summary>
      /// Handles the SelectedIndexChanged event of the cboTodoLink control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void cboTodoLink_SelectedIndexChanged(object sender, EventArgs e) {
        SetTimeSheetTask();
      }
    #endregion Interface
  }
}