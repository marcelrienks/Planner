namespace Planner.Controls{
  partial class TodoItemForm{
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
      this.txtTask = new System.Windows.Forms.TextBox();
      this.txtDesc = new System.Windows.Forms.TextBox();
      this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
      this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
      this.chbComplete = new System.Windows.Forms.CheckBox();
      this.lblTask = new System.Windows.Forms.Label();
      this.lblDesc = new System.Windows.Forms.Label();
      this.lblStartDate = new System.Windows.Forms.Label();
      this.lblEndDate = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtTask
      // 
      this.txtTask.Location = new System.Drawing.Point(74, 26);
      this.txtTask.Name = "txtTask";
      this.txtTask.Size = new System.Drawing.Size(547, 20);
      this.txtTask.TabIndex = 0;
      this.txtTask.Enter += new System.EventHandler(this.txtTask_Enter);
      // 
      // txtDesc
      // 
      this.txtDesc.Location = new System.Drawing.Point(74, 52);
      this.txtDesc.Multiline = true;
      this.txtDesc.Name = "txtDesc";
      this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtDesc.Size = new System.Drawing.Size(547, 69);
      this.txtDesc.TabIndex = 1;
      this.txtDesc.Enter += new System.EventHandler(this.txtDesc_Enter);
      // 
      // dtpStartDate
      // 
      this.dtpStartDate.Location = new System.Drawing.Point(74, 127);
      this.dtpStartDate.Name = "dtpStartDate";
      this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
      this.dtpStartDate.TabIndex = 2;
      // 
      // dtpEndDate
      // 
      this.dtpEndDate.Location = new System.Drawing.Point(74, 153);
      this.dtpEndDate.Name = "dtpEndDate";
      this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
      this.dtpEndDate.TabIndex = 3;
      // 
      // chbComplete
      // 
      this.chbComplete.AutoSize = true;
      this.chbComplete.Location = new System.Drawing.Point(74, 3);
      this.chbComplete.Name = "chbComplete";
      this.chbComplete.Size = new System.Drawing.Size(70, 17);
      this.chbComplete.TabIndex = 6;
      this.chbComplete.Text = "Complete";
      this.chbComplete.UseVisualStyleBackColor = true;
      // 
      // lblTask
      // 
      this.lblTask.AutoSize = true;
      this.lblTask.Location = new System.Drawing.Point(4, 33);
      this.lblTask.Name = "lblTask";
      this.lblTask.Size = new System.Drawing.Size(34, 13);
      this.lblTask.TabIndex = 5;
      this.lblTask.Text = "Task:";
      // 
      // lblDesc
      // 
      this.lblDesc.AutoSize = true;
      this.lblDesc.Location = new System.Drawing.Point(4, 59);
      this.lblDesc.Name = "lblDesc";
      this.lblDesc.Size = new System.Drawing.Size(35, 13);
      this.lblDesc.TabIndex = 6;
      this.lblDesc.Text = "Desc:";
      // 
      // lblStartDate
      // 
      this.lblStartDate.AutoSize = true;
      this.lblStartDate.Location = new System.Drawing.Point(4, 133);
      this.lblStartDate.Name = "lblStartDate";
      this.lblStartDate.Size = new System.Drawing.Size(58, 13);
      this.lblStartDate.TabIndex = 7;
      this.lblStartDate.Text = "Start Date:";
      // 
      // lblEndDate
      // 
      this.lblEndDate.AutoSize = true;
      this.lblEndDate.Location = new System.Drawing.Point(4, 159);
      this.lblEndDate.Name = "lblEndDate";
      this.lblEndDate.Size = new System.Drawing.Size(55, 13);
      this.lblEndDate.TabIndex = 8;
      this.lblEndDate.Text = "End Date:";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(465, 150);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(546, 150);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmToDoItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(631, 182);
      this.ControlBox = false;
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lblEndDate);
      this.Controls.Add(this.lblStartDate);
      this.Controls.Add(this.lblDesc);
      this.Controls.Add(this.lblTask);
      this.Controls.Add(this.chbComplete);
      this.Controls.Add(this.dtpEndDate);
      this.Controls.Add(this.dtpStartDate);
      this.Controls.Add(this.txtDesc);
      this.Controls.Add(this.txtTask);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "frmToDoItem";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "ToDo Item";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtTask;
    private System.Windows.Forms.TextBox txtDesc;
    private System.Windows.Forms.DateTimePicker dtpStartDate;
    private System.Windows.Forms.DateTimePicker dtpEndDate;
    private System.Windows.Forms.CheckBox chbComplete;
    private System.Windows.Forms.Label lblTask;
    private System.Windows.Forms.Label lblDesc;
    private System.Windows.Forms.Label lblStartDate;
    private System.Windows.Forms.Label lblEndDate;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
  }
}