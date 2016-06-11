namespace Planner.Controls {
  partial class CategoriesForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
      this.lstMainCategories = new System.Windows.Forms.ListBox();
      this.lstSubCategories = new System.Windows.Forms.ListBox();
      this.btnAddMainCategory = new System.Windows.Forms.Button();
      this.btnAddSubCategory = new System.Windows.Forms.Button();
      this.btnDeleteMainCategory = new System.Windows.Forms.Button();
      this.btnDeleteSubCategory = new System.Windows.Forms.Button();
      this.txtMainCategory = new System.Windows.Forms.TextBox();
      this.txtSubCategory = new System.Windows.Forms.TextBox();
      this.lblAddNewMainCategory = new System.Windows.Forms.Label();
      this.lblAddNewSubCategory = new System.Windows.Forms.Label();
      this.tbcCategories = new System.Windows.Forms.TabControl();
      this.tbMainCategories = new System.Windows.Forms.TabPage();
      this.tbSubCategories = new System.Windows.Forms.TabPage();
      this.tbcCategories.SuspendLayout();
      this.tbMainCategories.SuspendLayout();
      this.tbSubCategories.SuspendLayout();
      this.SuspendLayout();
      // 
      // lstMainCategories
      // 
      this.lstMainCategories.FormattingEnabled = true;
      this.lstMainCategories.Location = new System.Drawing.Point(6, 6);
      this.lstMainCategories.Name = "lstMainCategories";
      this.lstMainCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.lstMainCategories.Size = new System.Drawing.Size(335, 212);
      this.lstMainCategories.TabIndex = 0;
      // 
      // lstSubCategories
      // 
      this.lstSubCategories.FormattingEnabled = true;
      this.lstSubCategories.Location = new System.Drawing.Point(6, 6);
      this.lstSubCategories.Name = "lstSubCategories";
      this.lstSubCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.lstSubCategories.Size = new System.Drawing.Size(335, 212);
      this.lstSubCategories.TabIndex = 1;
      // 
      // btnAddMainCategory
      // 
      this.btnAddMainCategory.Location = new System.Drawing.Point(6, 275);
      this.btnAddMainCategory.Name = "btnAddMainCategory";
      this.btnAddMainCategory.Size = new System.Drawing.Size(75, 23);
      this.btnAddMainCategory.TabIndex = 1;
      this.btnAddMainCategory.Text = "Add";
      this.btnAddMainCategory.UseVisualStyleBackColor = true;
      this.btnAddMainCategory.Click += new System.EventHandler(this.btnAddMainCategory_Click);
      // 
      // btnAddSubCategory
      // 
      this.btnAddSubCategory.Location = new System.Drawing.Point(6, 275);
      this.btnAddSubCategory.Name = "btnAddSubCategory";
      this.btnAddSubCategory.Size = new System.Drawing.Size(75, 23);
      this.btnAddSubCategory.TabIndex = 1;
      this.btnAddSubCategory.Text = "Add";
      this.btnAddSubCategory.UseVisualStyleBackColor = true;
      this.btnAddSubCategory.Click += new System.EventHandler(this.btnAddSubCategory_Click);
      // 
      // btnDeleteMainCategory
      // 
      this.btnDeleteMainCategory.Location = new System.Drawing.Point(87, 275);
      this.btnDeleteMainCategory.Name = "btnDeleteMainCategory";
      this.btnDeleteMainCategory.Size = new System.Drawing.Size(75, 23);
      this.btnDeleteMainCategory.TabIndex = 2;
      this.btnDeleteMainCategory.Text = "Delete";
      this.btnDeleteMainCategory.UseVisualStyleBackColor = true;
      this.btnDeleteMainCategory.Click += new System.EventHandler(this.btnDeleteMainCategory_Click);
      // 
      // btnDeleteSubCategory
      // 
      this.btnDeleteSubCategory.Location = new System.Drawing.Point(87, 275);
      this.btnDeleteSubCategory.Name = "btnDeleteSubCategory";
      this.btnDeleteSubCategory.Size = new System.Drawing.Size(75, 23);
      this.btnDeleteSubCategory.TabIndex = 2;
      this.btnDeleteSubCategory.Text = "Delete";
      this.btnDeleteSubCategory.UseVisualStyleBackColor = true;
      this.btnDeleteSubCategory.Click += new System.EventHandler(this.btnDeleteSubCategory_Click);
      // 
      // txtMainCategory
      // 
      this.txtMainCategory.Location = new System.Drawing.Point(6, 249);
      this.txtMainCategory.Name = "txtMainCategory";
      this.txtMainCategory.Size = new System.Drawing.Size(335, 20);
      this.txtMainCategory.TabIndex = 0;
      this.txtMainCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMainCategory_KeyPress);
      // 
      // txtSubCategory
      // 
      this.txtSubCategory.Location = new System.Drawing.Point(6, 249);
      this.txtSubCategory.Name = "txtSubCategory";
      this.txtSubCategory.Size = new System.Drawing.Size(335, 20);
      this.txtSubCategory.TabIndex = 0;
      this.txtSubCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubCategory_KeyPress);
      // 
      // lblAddNewMainCategory
      // 
      this.lblAddNewMainCategory.AutoSize = true;
      this.lblAddNewMainCategory.Location = new System.Drawing.Point(3, 233);
      this.lblAddNewMainCategory.Name = "lblAddNewMainCategory";
      this.lblAddNewMainCategory.Size = new System.Drawing.Size(51, 13);
      this.lblAddNewMainCategory.TabIndex = 9;
      this.lblAddNewMainCategory.Text = "Add New";
      // 
      // lblAddNewSubCategory
      // 
      this.lblAddNewSubCategory.AutoSize = true;
      this.lblAddNewSubCategory.Location = new System.Drawing.Point(3, 233);
      this.lblAddNewSubCategory.Name = "lblAddNewSubCategory";
      this.lblAddNewSubCategory.Size = new System.Drawing.Size(51, 13);
      this.lblAddNewSubCategory.TabIndex = 11;
      this.lblAddNewSubCategory.Text = "Add New";
      // 
      // tbcCategories
      // 
      this.tbcCategories.Controls.Add(this.tbMainCategories);
      this.tbcCategories.Controls.Add(this.tbSubCategories);
      this.tbcCategories.Location = new System.Drawing.Point(12, 12);
      this.tbcCategories.Name = "tbcCategories";
      this.tbcCategories.SelectedIndex = 0;
      this.tbcCategories.Size = new System.Drawing.Size(357, 330);
      this.tbcCategories.TabIndex = 3;
      this.tbcCategories.SelectedIndexChanged += new System.EventHandler(this.tbcCategories_SelectedIndexChanged);
      // 
      // tbMainCategories
      // 
      this.tbMainCategories.Controls.Add(this.lstMainCategories);
      this.tbMainCategories.Controls.Add(this.btnAddMainCategory);
      this.tbMainCategories.Controls.Add(this.btnDeleteMainCategory);
      this.tbMainCategories.Controls.Add(this.lblAddNewMainCategory);
      this.tbMainCategories.Controls.Add(this.txtMainCategory);
      this.tbMainCategories.Location = new System.Drawing.Point(4, 22);
      this.tbMainCategories.Name = "tbMainCategories";
      this.tbMainCategories.Padding = new System.Windows.Forms.Padding(3);
      this.tbMainCategories.Size = new System.Drawing.Size(349, 304);
      this.tbMainCategories.TabIndex = 0;
      this.tbMainCategories.Text = "Main Categories";
      this.tbMainCategories.UseVisualStyleBackColor = true;
      // 
      // tbSubCategories
      // 
      this.tbSubCategories.Controls.Add(this.lstSubCategories);
      this.tbSubCategories.Controls.Add(this.lblAddNewSubCategory);
      this.tbSubCategories.Controls.Add(this.btnAddSubCategory);
      this.tbSubCategories.Controls.Add(this.btnDeleteSubCategory);
      this.tbSubCategories.Controls.Add(this.txtSubCategory);
      this.tbSubCategories.Location = new System.Drawing.Point(4, 22);
      this.tbSubCategories.Name = "tbSubCategories";
      this.tbSubCategories.Padding = new System.Windows.Forms.Padding(3);
      this.tbSubCategories.Size = new System.Drawing.Size(349, 304);
      this.tbSubCategories.TabIndex = 1;
      this.tbSubCategories.Text = "Sub Categories";
      this.tbSubCategories.UseVisualStyleBackColor = true;
      // 
      // CategoriesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(378, 351);
      this.Controls.Add(this.tbcCategories);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CategoriesForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Categories";
      this.tbcCategories.ResumeLayout(false);
      this.tbMainCategories.ResumeLayout(false);
      this.tbMainCategories.PerformLayout();
      this.tbSubCategories.ResumeLayout(false);
      this.tbSubCategories.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstMainCategories;
    private System.Windows.Forms.ListBox lstSubCategories;
    private System.Windows.Forms.Button btnAddMainCategory;
    private System.Windows.Forms.Button btnAddSubCategory;
    private System.Windows.Forms.Button btnDeleteMainCategory;
    private System.Windows.Forms.Button btnDeleteSubCategory;
    private System.Windows.Forms.TextBox txtMainCategory;
    private System.Windows.Forms.TextBox txtSubCategory;
    private System.Windows.Forms.Label lblAddNewMainCategory;
    private System.Windows.Forms.Label lblAddNewSubCategory;
    private System.Windows.Forms.TabControl tbcCategories;
    private System.Windows.Forms.TabPage tbMainCategories;
    private System.Windows.Forms.TabPage tbSubCategories;
  }
}