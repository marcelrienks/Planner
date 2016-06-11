using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planner.Controls {
  /// <summary>
  /// Options Form
  /// </summary>
  public partial class OptionsForm : Form {

    /// <summary>
    /// Initializes a new instance of the <see cref="OptionsForm"/> class.
    /// </summary>
    public OptionsForm() {
      InitializeComponent();
    }

    /// <summary>
    /// Handles the Load event of the frmOptions control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void OptionsForm_Load(object sender, EventArgs e) {
      chkHideOnStartup.Checked                = Properties.Settings.Default.Planner_HideOnStartup;
      chkCalcTotalTime.Checked                = Properties.Settings.Default.Planner_CalcTotalTime;
      chkMinimizeToSystemTray.Checked         = Properties.Settings.Default.Planner_MinimizeToSystemTray;
      chkSetEndTime.Checked                   = Properties.Settings.Default.TimeSheet_SetEndTime;
      chkSetStartTime.Checked                 = Properties.Settings.Default.TimeSheet_SetStartTime;
      chkShowJobTime.Checked                  = Properties.Settings.Default.TimeSheet_ShowJobTime;
      chkOpenQuickAdd.Checked                 = Properties.Settings.Default.TimeSheet_OpenQuickAdd;
      chkEnableCategories.Checked             = Properties.Settings.Default.TimeSheet_EnableCategories;
      chkEnableTodoItemLink.Checked           = Properties.Settings.Default.TimeSheet_EnableTodoItemLink;
      chkSetTodoCompleteOnEndTime.Checked     = Properties.Settings.Default.TimeSheet_EnableTodoItemLink;
      chkAddDateToName.Checked                = Properties.Settings.Default.Note_AddDateToName;
      chkAppendDateToNote.Checked             = Properties.Settings.Default.Note_AppendDateToNote;
    }

    /// <summary>
    /// Applies the settings.
    /// </summary>
    private void ApplySettings(){
      Properties.Settings.Default.Planner_HideOnStartup               = chkHideOnStartup.Checked;
      Properties.Settings.Default.Planner_CalcTotalTime               = chkCalcTotalTime.Checked;
      Properties.Settings.Default.Planner_MinimizeToSystemTray        = chkMinimizeToSystemTray.Checked;
      Properties.Settings.Default.TimeSheet_SetEndTime                = chkSetEndTime.Checked;
      Properties.Settings.Default.TimeSheet_SetStartTime              = chkSetStartTime.Checked;
      Properties.Settings.Default.TimeSheet_ShowJobTime               = chkShowJobTime.Checked;
      Properties.Settings.Default.TimeSheet_OpenQuickAdd              = chkOpenQuickAdd.Checked;
      Properties.Settings.Default.TimeSheet_EnableCategories          = chkEnableCategories.Checked;
      Properties.Settings.Default.TimeSheet_EnableTodoItemLink        = chkEnableTodoItemLink.Checked;
      Properties.Settings.Default.TimeSheet_EnableTodoItemLink        = chkSetTodoCompleteOnEndTime.Checked;
      Properties.Settings.Default.Note_AddDateToName                  = chkAddDateToName.Checked;
      Properties.Settings.Default.Note_AppendDateToNote               = chkAppendDateToNote.Checked;
    }

    #region Interface
      /// <summary>
      /// Handles the Click event of the btnApply control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnApply_Click(object sender, EventArgs e) {
        ApplySettings();
        this.Close();
      }

      /// <summary>
      /// Handles the Click event of the btnCancel control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnCancel_Click(object sender, EventArgs e) {
        this.Close();
      }
    #endregion Interface
  }
}