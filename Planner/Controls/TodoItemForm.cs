using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Planner.Components;

namespace Planner.Controls {
  /// <summary>
  /// Todo item Form
  /// </summary>
  public partial class TodoItemForm : Form{
    private ToDo _todoItem           = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="frmToDoItem"/> class.
    /// </summary>
    /// <param name="todo">The todo.</param>
    public TodoItemForm(ref ToDo todo){
      InitializeComponent();
      _todoItem            = todo;
      SetUpTodoItemForm();
    }

    /// <summary>
    /// Sets the up todo item form.
    /// </summary>
    private void SetUpTodoItemForm(){
      if ((_todoItem.Task != "") && (_todoItem.Desc != "")){
        PopulateTodo();
      }
    }

    /// <summary>
    /// Populates the todo.
    /// </summary>
    private void PopulateTodo(){
      chbComplete.Checked       = _todoItem.Complete;
      txtTask.Text              = _todoItem.Task;
      txtDesc.Text              = Utilities.CleanMultiLines(_todoItem.Desc);
      dtpStartDate.Value        = _todoItem.StartDate;
      dtpEndDate.Value          = _todoItem.DueDate;
    }

    /// <summary>
    /// Saves this instance.
    /// </summary>
    private void Save(){
      if (txtTask.Text != ""){
        dtpEndDate.Value          = dtpEndDate.Value.AddSeconds(1.0);           //to ensure that the start date is before the end date if the same day was selected

        if (dtpStartDate.Value < dtpEndDate.Value) {
          if (_todoItem.GUID == "") {
            _todoItem.GUID         = Utilities.GetNewGUID();
          }

          _todoItem.Complete       = chbComplete.Checked;
          _todoItem.Task           = txtTask.Text;
          _todoItem.Desc           = txtDesc.Text;
          _todoItem.StartDate      = dtpStartDate.Value;
          _todoItem.DueDate        = dtpEndDate.Value;
          this.Close();

        } else {
          MessageBox.Show("Please ensure that the start date is before the end date!", "SAVE",
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

      } else {
        MessageBox.Show("Please ensure that there is a Task!", "SAVE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    /// <summary>
    /// Clears the time sheet object.
    /// </summary>
    private void ClearToDoObject(){
      _todoItem = null;
    }

    /// <summary>
    /// Closes the form.
    /// </summary>
    private void CloseForm(){
      ClearToDoObject();
      this.Close();
    }

    #region Interface
      /// <summary>
      /// Handles the Click event of the btnSave control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnSave_Click(object sender, EventArgs e){
        Save();
      }

      /// <summary>
      /// Handles the Click event of the btnCancel control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnCancel_Click(object sender, EventArgs e){
        CloseForm();
      }

      /// <summary>
      /// Handles the Enter event of the txtDesc control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void txtDesc_Enter(object sender, EventArgs e) {
        txtDesc.SelectAll();
      }

      /// <summary>
      /// Handles the Enter event of the txtTask control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void txtTask_Enter(object sender, EventArgs e) {
        txtTask.SelectAll();
      }
    #endregion Interface
  }
}