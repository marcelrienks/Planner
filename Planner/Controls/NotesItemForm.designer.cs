namespace Planner.Controls {
  partial class NotesItemForm {
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
      this.lblDate = new System.Windows.Forms.Label();
      this.lblNote = new System.Windows.Forms.Label();
      this.dtpDate = new System.Windows.Forms.DateTimePicker();
      this.txtNote = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(558, 243);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(477, 243);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Location = new System.Drawing.Point(6, 18);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(33, 13);
      this.lblDate.TabIndex = 18;
      this.lblDate.Text = "Date:";
      // 
      // lblNote
      // 
      this.lblNote.AutoSize = true;
      this.lblNote.Location = new System.Drawing.Point(6, 45);
      this.lblNote.Name = "lblNote";
      this.lblNote.Size = new System.Drawing.Size(33, 13);
      this.lblNote.TabIndex = 16;
      this.lblNote.Text = "Note:";
      // 
      // dtpDate
      // 
      this.dtpDate.Location = new System.Drawing.Point(76, 12);
      this.dtpDate.Name = "dtpDate";
      this.dtpDate.Size = new System.Drawing.Size(200, 20);
      this.dtpDate.TabIndex = 3;
      // 
      // txtNote
      // 
      this.txtNote.AcceptsReturn = true;
      this.txtNote.Location = new System.Drawing.Point(76, 38);
      this.txtNote.Multiline = true;
      this.txtNote.Name = "txtNote";
      this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtNote.Size = new System.Drawing.Size(557, 199);
      this.txtNote.TabIndex = 0;
      // 
      // NotesItemForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(645, 272);
      this.ControlBox = false;
      this.Controls.Add(this.txtNote);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.lblNote);
      this.Controls.Add(this.dtpDate);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "NotesItemForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Notes Item";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Label lblNote;
    private System.Windows.Forms.DateTimePicker dtpDate;
    private System.Windows.Forms.TextBox txtNote;
  }
}