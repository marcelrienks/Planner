namespace Planner.Controls {
  partial class OptionsForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
      this.gpTimeSheet = new System.Windows.Forms.GroupBox();
      this.chkSetTodoCompleteOnEndTime = new System.Windows.Forms.CheckBox();
      this.chkEnableTodoItemLink = new System.Windows.Forms.CheckBox();
      this.chkEnableCategories = new System.Windows.Forms.CheckBox();
      this.chkOpenQuickAdd = new System.Windows.Forms.CheckBox();
      this.chkCalcTotalTime = new System.Windows.Forms.CheckBox();
      this.chkShowJobTime = new System.Windows.Forms.CheckBox();
      this.chkSetStartTime = new System.Windows.Forms.CheckBox();
      this.chkSetEndTime = new System.Windows.Forms.CheckBox();
      this.gpNotes = new System.Windows.Forms.GroupBox();
      this.chkAppendDateToNote = new System.Windows.Forms.CheckBox();
      this.chkAddDateToName = new System.Windows.Forms.CheckBox();
      this.btnApply = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.gpPlanner = new System.Windows.Forms.GroupBox();
      this.chkMinimizeToSystemTray = new System.Windows.Forms.CheckBox();
      this.chkHideOnStartup = new System.Windows.Forms.CheckBox();
      this.gpTimeSheet.SuspendLayout();
      this.gpNotes.SuspendLayout();
      this.gpPlanner.SuspendLayout();
      this.SuspendLayout();
      // 
      // gpTimeSheet
      // 
      this.gpTimeSheet.Controls.Add(this.chkSetTodoCompleteOnEndTime);
      this.gpTimeSheet.Controls.Add(this.chkEnableTodoItemLink);
      this.gpTimeSheet.Controls.Add(this.chkEnableCategories);
      this.gpTimeSheet.Controls.Add(this.chkOpenQuickAdd);
      this.gpTimeSheet.Controls.Add(this.chkCalcTotalTime);
      this.gpTimeSheet.Controls.Add(this.chkShowJobTime);
      this.gpTimeSheet.Controls.Add(this.chkSetStartTime);
      this.gpTimeSheet.Controls.Add(this.chkSetEndTime);
      this.gpTimeSheet.Location = new System.Drawing.Point(12, 80);
      this.gpTimeSheet.Name = "gpTimeSheet";
      this.gpTimeSheet.Size = new System.Drawing.Size(334, 204);
      this.gpTimeSheet.TabIndex = 0;
      this.gpTimeSheet.TabStop = false;
      this.gpTimeSheet.Text = "Time Sheet";
      // 
      // chkSetTodoCompleteOnEndTime
      // 
      this.chkSetTodoCompleteOnEndTime.AutoSize = true;
      this.chkSetTodoCompleteOnEndTime.Location = new System.Drawing.Point(6, 65);
      this.chkSetTodoCompleteOnEndTime.Name = "chkSetTodoCompleteOnEndTime";
      this.chkSetTodoCompleteOnEndTime.Size = new System.Drawing.Size(246, 17);
      this.chkSetTodoCompleteOnEndTime.TabIndex = 9;
      this.chkSetTodoCompleteOnEndTime.Text = "Set linked Todo item Complete on End time set";
      this.chkSetTodoCompleteOnEndTime.UseVisualStyleBackColor = true;
      // 
      // chkEnableTodoItemLink
      // 
      this.chkEnableTodoItemLink.AutoSize = true;
      this.chkEnableTodoItemLink.Location = new System.Drawing.Point(6, 180);
      this.chkEnableTodoItemLink.Name = "chkEnableTodoItemLink";
      this.chkEnableTodoItemLink.Size = new System.Drawing.Size(154, 17);
      this.chkEnableTodoItemLink.TabIndex = 8;
      this.chkEnableTodoItemLink.Text = "Enable linking to Todo item";
      this.chkEnableTodoItemLink.UseVisualStyleBackColor = true;
      // 
      // chkEnableCategories
      // 
      this.chkEnableCategories.AutoSize = true;
      this.chkEnableCategories.Location = new System.Drawing.Point(6, 157);
      this.chkEnableCategories.Name = "chkEnableCategories";
      this.chkEnableCategories.Size = new System.Drawing.Size(112, 17);
      this.chkEnableCategories.TabIndex = 7;
      this.chkEnableCategories.Text = "Enable Categories";
      this.chkEnableCategories.UseVisualStyleBackColor = true;
      // 
      // chkOpenQuickAdd
      // 
      this.chkOpenQuickAdd.AutoSize = true;
      this.chkOpenQuickAdd.Location = new System.Drawing.Point(6, 134);
      this.chkOpenQuickAdd.Name = "chkOpenQuickAdd";
      this.chkOpenQuickAdd.Size = new System.Drawing.Size(195, 17);
      this.chkOpenQuickAdd.TabIndex = 5;
      this.chkOpenQuickAdd.Text = "Open Quick Add from context menu";
      this.chkOpenQuickAdd.UseVisualStyleBackColor = true;
      // 
      // chkCalcTotalTime
      // 
      this.chkCalcTotalTime.AutoSize = true;
      this.chkCalcTotalTime.Location = new System.Drawing.Point(6, 88);
      this.chkCalcTotalTime.Name = "chkCalcTotalTime";
      this.chkCalcTotalTime.Size = new System.Drawing.Size(187, 17);
      this.chkCalcTotalTime.TabIndex = 6;
      this.chkCalcTotalTime.Text = "Calculate selected days Total time";
      this.chkCalcTotalTime.UseVisualStyleBackColor = true;
      // 
      // chkShowJobTime
      // 
      this.chkShowJobTime.AutoSize = true;
      this.chkShowJobTime.Location = new System.Drawing.Point(6, 111);
      this.chkShowJobTime.Name = "chkShowJobTime";
      this.chkShowJobTime.Size = new System.Drawing.Size(136, 17);
      this.chkShowJobTime.TabIndex = 4;
      this.chkShowJobTime.Text = "Show Job Time column";
      this.chkShowJobTime.UseVisualStyleBackColor = true;
      // 
      // chkSetStartTime
      // 
      this.chkSetStartTime.AutoSize = true;
      this.chkSetStartTime.Location = new System.Drawing.Point(6, 42);
      this.chkSetStartTime.Name = "chkSetStartTime";
      this.chkSetStartTime.Size = new System.Drawing.Size(251, 17);
      this.chkSetStartTime.TabIndex = 3;
      this.chkSetStartTime.Text = "Set Quick Add\'s Start time to last items End time";
      this.chkSetStartTime.UseVisualStyleBackColor = true;
      // 
      // chkSetEndTime
      // 
      this.chkSetEndTime.AutoSize = true;
      this.chkSetEndTime.Location = new System.Drawing.Point(6, 19);
      this.chkSetEndTime.Name = "chkSetEndTime";
      this.chkSetEndTime.Size = new System.Drawing.Size(169, 17);
      this.chkSetEndTime.TabIndex = 2;
      this.chkSetEndTime.Text = "Set last items End time on Add";
      this.chkSetEndTime.UseVisualStyleBackColor = true;
      // 
      // gpNotes
      // 
      this.gpNotes.Controls.Add(this.chkAppendDateToNote);
      this.gpNotes.Controls.Add(this.chkAddDateToName);
      this.gpNotes.Location = new System.Drawing.Point(12, 290);
      this.gpNotes.Name = "gpNotes";
      this.gpNotes.Size = new System.Drawing.Size(334, 65);
      this.gpNotes.TabIndex = 2;
      this.gpNotes.TabStop = false;
      this.gpNotes.Text = "Notes";
      // 
      // chkAppendDateToNote
      // 
      this.chkAppendDateToNote.AutoSize = true;
      this.chkAppendDateToNote.Location = new System.Drawing.Point(6, 42);
      this.chkAppendDateToNote.Name = "chkAppendDateToNote";
      this.chkAppendDateToNote.Size = new System.Drawing.Size(212, 17);
      this.chkAppendDateToNote.TabIndex = 9;
      this.chkAppendDateToNote.Text = "Append the Date to the end of the note";
      this.chkAppendDateToNote.UseVisualStyleBackColor = true;
      // 
      // chkAddDateToName
      // 
      this.chkAddDateToName.AutoSize = true;
      this.chkAddDateToName.Location = new System.Drawing.Point(6, 19);
      this.chkAddDateToName.Name = "chkAddDateToName";
      this.chkAddDateToName.Size = new System.Drawing.Size(171, 17);
      this.chkAddDateToName.TabIndex = 8;
      this.chkAddDateToName.Text = "Add Date to Name in tree view";
      this.chkAddDateToName.UseVisualStyleBackColor = true;
      // 
      // btnApply
      // 
      this.btnApply.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.btnApply.Location = new System.Drawing.Point(190, 361);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(75, 23);
      this.btnApply.TabIndex = 10;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(271, 361);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // gpPlanner
      // 
      this.gpPlanner.Controls.Add(this.chkMinimizeToSystemTray);
      this.gpPlanner.Controls.Add(this.chkHideOnStartup);
      this.gpPlanner.Location = new System.Drawing.Point(12, 12);
      this.gpPlanner.Name = "gpPlanner";
      this.gpPlanner.Size = new System.Drawing.Size(334, 62);
      this.gpPlanner.TabIndex = 5;
      this.gpPlanner.TabStop = false;
      this.gpPlanner.Text = "Planner";
      // 
      // chkMinimizeToSystemTray
      // 
      this.chkMinimizeToSystemTray.AutoSize = true;
      this.chkMinimizeToSystemTray.Location = new System.Drawing.Point(6, 38);
      this.chkMinimizeToSystemTray.Name = "chkMinimizeToSystemTray";
      this.chkMinimizeToSystemTray.Size = new System.Drawing.Size(139, 17);
      this.chkMinimizeToSystemTray.TabIndex = 1;
      this.chkMinimizeToSystemTray.Text = "Minimize to System Tray";
      this.chkMinimizeToSystemTray.UseVisualStyleBackColor = true;
      // 
      // chkHideOnStartup
      // 
      this.chkHideOnStartup.AutoSize = true;
      this.chkHideOnStartup.Location = new System.Drawing.Point(6, 19);
      this.chkHideOnStartup.Name = "chkHideOnStartup";
      this.chkHideOnStartup.Size = new System.Drawing.Size(160, 17);
      this.chkHideOnStartup.TabIndex = 0;
      this.chkHideOnStartup.Text = "Auto hide Planner on startup";
      this.chkHideOnStartup.UseVisualStyleBackColor = true;
      // 
      // OptionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(358, 396);
      this.Controls.Add(this.gpPlanner);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnApply);
      this.Controls.Add(this.gpNotes);
      this.Controls.Add(this.gpTimeSheet);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Options";
      this.Load += new System.EventHandler(this.OptionsForm_Load);
      this.gpTimeSheet.ResumeLayout(false);
      this.gpTimeSheet.PerformLayout();
      this.gpNotes.ResumeLayout(false);
      this.gpNotes.PerformLayout();
      this.gpPlanner.ResumeLayout(false);
      this.gpPlanner.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gpTimeSheet;
    private System.Windows.Forms.GroupBox gpNotes;
    private System.Windows.Forms.CheckBox chkAddDateToName;
    private System.Windows.Forms.CheckBox chkAppendDateToNote;
    private System.Windows.Forms.Button btnApply;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.CheckBox chkSetEndTime;
    private System.Windows.Forms.CheckBox chkSetStartTime;
    private System.Windows.Forms.CheckBox chkShowJobTime;
    private System.Windows.Forms.CheckBox chkOpenQuickAdd;
    private System.Windows.Forms.GroupBox gpPlanner;
    private System.Windows.Forms.CheckBox chkHideOnStartup;
    private System.Windows.Forms.CheckBox chkCalcTotalTime;
    private System.Windows.Forms.CheckBox chkMinimizeToSystemTray;
    private System.Windows.Forms.CheckBox chkEnableCategories;
    private System.Windows.Forms.CheckBox chkEnableTodoItemLink;
    private System.Windows.Forms.CheckBox chkSetTodoCompleteOnEndTime;
  }
}