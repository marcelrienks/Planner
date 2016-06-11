namespace Planner.Controls {
  partial class TimeSheetItemForm {
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.lblEndDate = new System.Windows.Forms.Label();
      this.lblTask = new System.Windows.Forms.Label();
      this.txtTask = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnStartNow = new System.Windows.Forms.Button();
      this.btnEndNow = new System.Windows.Forms.Button();
      this.mtxtEndTime = new System.Windows.Forms.MaskedTextBox();
      this.mtxtStartTime = new System.Windows.Forms.MaskedTextBox();
      this.cboMainCategory = new System.Windows.Forms.ComboBox();
      this.cboSubCategory = new System.Windows.Forms.ComboBox();
      this.lblMainCategory = new System.Windows.Forms.Label();
      this.lblSubCategory = new System.Windows.Forms.Label();
      this.lblTodoLink = new System.Windows.Forms.Label();
      this.cboTodoLink = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(726, 179);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(645, 179);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // lblEndDate
      // 
      this.lblEndDate.AutoSize = true;
      this.lblEndDate.Location = new System.Drawing.Point(6, 163);
      this.lblEndDate.Name = "lblEndDate";
      this.lblEndDate.Size = new System.Drawing.Size(58, 13);
      this.lblEndDate.TabIndex = 19;
      this.lblEndDate.Text = "Start Time:";
      // 
      // lblTask
      // 
      this.lblTask.AutoSize = true;
      this.lblTask.Location = new System.Drawing.Point(6, 78);
      this.lblTask.Name = "lblTask";
      this.lblTask.Size = new System.Drawing.Size(34, 13);
      this.lblTask.TabIndex = 16;
      this.lblTask.Text = "Task:";
      // 
      // txtTask
      // 
      this.txtTask.Location = new System.Drawing.Point(76, 66);
      this.txtTask.Multiline = true;
      this.txtTask.Name = "txtTask";
      this.txtTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtTask.Size = new System.Drawing.Size(725, 84);
      this.txtTask.TabIndex = 0;
      this.txtTask.Enter += new System.EventHandler(this.txtTask_Enter);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 189);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 23;
      this.label1.Text = "End Time:";
      // 
      // btnStartNow
      // 
      this.btnStartNow.Location = new System.Drawing.Point(133, 154);
      this.btnStartNow.Name = "btnStartNow";
      this.btnStartNow.Size = new System.Drawing.Size(50, 23);
      this.btnStartNow.TabIndex = 2;
      this.btnStartNow.Text = "Now";
      this.btnStartNow.UseVisualStyleBackColor = true;
      this.btnStartNow.Click += new System.EventHandler(this.btnStartNow_Click);
      // 
      // btnEndNow
      // 
      this.btnEndNow.Location = new System.Drawing.Point(133, 183);
      this.btnEndNow.Name = "btnEndNow";
      this.btnEndNow.Size = new System.Drawing.Size(50, 23);
      this.btnEndNow.TabIndex = 4;
      this.btnEndNow.Text = "Now";
      this.btnEndNow.UseVisualStyleBackColor = true;
      this.btnEndNow.Click += new System.EventHandler(this.btnEndNow_Click);
      // 
      // mtxtEndTime
      // 
      this.mtxtEndTime.Location = new System.Drawing.Point(76, 184);
      this.mtxtEndTime.Mask = "00:00:00";
      this.mtxtEndTime.Name = "mtxtEndTime";
      this.mtxtEndTime.Size = new System.Drawing.Size(51, 20);
      this.mtxtEndTime.TabIndex = 3;
      // 
      // mtxtStartTime
      // 
      this.mtxtStartTime.Location = new System.Drawing.Point(76, 156);
      this.mtxtStartTime.Mask = "00:00:00";
      this.mtxtStartTime.Name = "mtxtStartTime";
      this.mtxtStartTime.Size = new System.Drawing.Size(51, 20);
      this.mtxtStartTime.TabIndex = 1;
      // 
      // cboMainCategory
      // 
      this.cboMainCategory.FormattingEnabled = true;
      this.cboMainCategory.Location = new System.Drawing.Point(76, 12);
      this.cboMainCategory.Name = "cboMainCategory";
      this.cboMainCategory.Size = new System.Drawing.Size(300, 21);
      this.cboMainCategory.TabIndex = 8;
      // 
      // cboSubCategory
      // 
      this.cboSubCategory.FormattingEnabled = true;
      this.cboSubCategory.Location = new System.Drawing.Point(501, 12);
      this.cboSubCategory.Name = "cboSubCategory";
      this.cboSubCategory.Size = new System.Drawing.Size(300, 21);
      this.cboSubCategory.TabIndex = 9;
      // 
      // lblMainCategory
      // 
      this.lblMainCategory.AutoSize = true;
      this.lblMainCategory.Location = new System.Drawing.Point(6, 15);
      this.lblMainCategory.Name = "lblMainCategory";
      this.lblMainCategory.Size = new System.Drawing.Size(52, 13);
      this.lblMainCategory.TabIndex = 26;
      this.lblMainCategory.Text = "Category:";
      // 
      // lblSubCategory
      // 
      this.lblSubCategory.AutoSize = true;
      this.lblSubCategory.Location = new System.Drawing.Point(424, 15);
      this.lblSubCategory.Name = "lblSubCategory";
      this.lblSubCategory.Size = new System.Drawing.Size(74, 13);
      this.lblSubCategory.TabIndex = 27;
      this.lblSubCategory.Text = "Sub Category:";
      // 
      // lblTodoLink
      // 
      this.lblTodoLink.AutoSize = true;
      this.lblTodoLink.Location = new System.Drawing.Point(6, 42);
      this.lblTodoLink.Name = "lblTodoLink";
      this.lblTodoLink.Size = new System.Drawing.Size(35, 13);
      this.lblTodoLink.TabIndex = 28;
      this.lblTodoLink.Text = "Todo:";
      // 
      // cboTodoLink
      // 
      this.cboTodoLink.FormattingEnabled = true;
      this.cboTodoLink.Location = new System.Drawing.Point(76, 39);
      this.cboTodoLink.Name = "cboTodoLink";
      this.cboTodoLink.Size = new System.Drawing.Size(725, 21);
      this.cboTodoLink.TabIndex = 29;
      this.cboTodoLink.SelectedIndexChanged += new System.EventHandler(this.cboTodoLink_SelectedIndexChanged);
      // 
      // TimeSheetItemForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(806, 208);
      this.ControlBox = false;
      this.Controls.Add(this.cboTodoLink);
      this.Controls.Add(this.lblTodoLink);
      this.Controls.Add(this.lblSubCategory);
      this.Controls.Add(this.lblMainCategory);
      this.Controls.Add(this.cboSubCategory);
      this.Controls.Add(this.cboMainCategory);
      this.Controls.Add(this.mtxtStartTime);
      this.Controls.Add(this.mtxtEndTime);
      this.Controls.Add(this.btnEndNow);
      this.Controls.Add(this.btnStartNow);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtTask);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lblEndDate);
      this.Controls.Add(this.lblTask);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "TimeSheetItemForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Time Sheet Item";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblEndDate;
    private System.Windows.Forms.Label lblTask;
    private System.Windows.Forms.TextBox txtTask;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnStartNow;
    private System.Windows.Forms.Button btnEndNow;
    private System.Windows.Forms.MaskedTextBox mtxtEndTime;
    private System.Windows.Forms.MaskedTextBox mtxtStartTime;
    private System.Windows.Forms.ComboBox cboMainCategory;
    private System.Windows.Forms.ComboBox cboSubCategory;
    private System.Windows.Forms.Label lblMainCategory;
    private System.Windows.Forms.Label lblSubCategory;
    private System.Windows.Forms.Label lblTodoLink;
    private System.Windows.Forms.ComboBox cboTodoLink;
  }
}