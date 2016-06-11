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
  /// Notes item Form
  /// </summary>
  public partial class NotesItemForm : Form {
    private Notes _notesItem      = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="frmTimeSheetItem"/> class.
    /// </summary>
    /// <param name="timeSheet">The time sheet.</param>
    public NotesItemForm(ref Notes notes) {
      InitializeComponent();
      _notesItem            = notes;
      SetUpNotesItemForm();
    }

    /// <summary>
    /// Sets the up notes item form.
    /// </summary>
    private void SetUpNotesItemForm(){
      if (_notesItem.Note != ""){
        PopulateNotes();
      }
    }

    /// <summary>
    /// Populates the time sheet.
    /// </summary>
    private void PopulateNotes(){
      dtpDate.Value             = _notesItem.Date;
      txtNote.Text              = _notesItem.Note;
    }

    /// <summary>
    /// Saves this instance.
    /// </summary>
    private void Save(){
      if (txtNote.Text != ""){
        if (_notesItem.GUID == "") {
          _notesItem.GUID          = Utilities.GetNewGUID();
        }

        _notesItem.Date            = dtpDate.Value;
        _notesItem.Note            = txtNote.Text;
        this.Close();
      } else{
        MessageBox.Show("Please ensure that there is a Note!", "SAVE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	    }
    }

    /// <summary>
    /// Clears the time sheet object.
    /// </summary>
    private void ClearNotesObject(){
      _notesItem = null;
    }

    /// <summary>
    /// Closes the form.
    /// </summary>
    private void CloseForm(){
      ClearNotesObject();
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
      /// Handles the Enter event of the txtTask control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void txtNote_Enter(object sender, EventArgs e) {
        txtNote.SelectAll();
      }
    #endregion Interface
  }
}