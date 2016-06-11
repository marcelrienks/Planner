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
  /// Categories Form
  /// </summary>
  public partial class CategoriesForm : Form {
    private CategoriesControl _categoriesControl       = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="Categories"/> class.
    /// </summary>
    public CategoriesForm() {
      InitializeComponent();
      _categoriesControl       = new CategoriesControl();
      SetUpCategoriesForm();
    }

    /// <summary>
    /// Sets the up categories form.
    /// </summary>
    private void SetUpCategoriesForm(){
      if ((Persistence.Persist.Data.MainCategoriesList.Count > 0) || (Persistence.Persist.Data.SubCategoriesList.Count > 0)) {
        PopulateCategories();
      }
    }

    /// <summary>
    /// Populates the categories.
    /// </summary>
    private void PopulateCategories(){
      txtMainCategory.Text = "";
      txtSubCategory.Text = "";

      lstMainCategories.Items.Clear();
      lstSubCategories.Items.Clear();

      for (int ct = 0; ct < Persistence.Persist.Data.MainCategoriesList.Count; ct++) {
        lstMainCategories.Items.Add(Persistence.Persist.Data.MainCategoriesList[ct].Category);
      }

      for (int ct = 0; ct < Persistence.Persist.Data.SubCategoriesList.Count; ct++) {
        lstSubCategories.Items.Add(Persistence.Persist.Data.SubCategoriesList[ct].Category);
      }

      if (tbcCategories.SelectedTab == tbMainCategories) {
        SetFocus(true);
      } else {
        SetFocus(false);
      }
    }

    /// <summary>
    /// Sets focus to control.
    /// </summary>
    /// <param name="isMain">if set to <c>true</c> [is main].</param>
    private void SetFocus(bool isMain){
      if (isMain) {
        txtMainCategory.Focus();
      } else {
        txtSubCategory.Focus();
      }
    }

    /// <summary>
    /// Adds the main category.
    /// </summary>
    private void AddMainCategory(){
      if (txtMainCategory.Text != "") {
        MainCategories mainCategory       = new MainCategories();
        mainCategory.GUID                 = Utilities.GetNewGUID();
        mainCategory.Category             = txtMainCategory.Text;
        _categoriesControl.AddMainCategory(mainCategory);
      }
      PopulateCategories();
    }

    /// <summary>
    /// Deletes the main category.
    /// </summary>
    private void DeleteMainCategory(){
      for (int ct = 0; ct < lstMainCategories.SelectedItems.Count; ct++) {
        _categoriesControl.DeleteMainCategory(lstMainCategories.SelectedItems[ct].ToString());
      }
      PopulateCategories();
    }

    /// <summary>
    /// Adds the sub category.
    /// </summary>
    private void AddSubCategory(){
      if (txtSubCategory.Text != "") {
        SubCategories subCategory       = new SubCategories();
        subCategory.GUID                = Utilities.GetNewGUID();
        subCategory.Category            = txtSubCategory.Text;
        _categoriesControl.AddSubCategory(subCategory);
      }
      PopulateCategories();
    }

    /// <summary>
    /// Deletes the sub category.
    /// </summary>
    private void DeleteSubCategory(){
      for (int ct = 0; ct < lstSubCategories.SelectedItems.Count; ct++) {
        _categoriesControl.DeleteSubCategory(lstSubCategories.SelectedItems[ct].ToString());
      }
      PopulateCategories();
    }

    #region Interface
      /// <summary>
      /// Handles the Click event of the btnAddMainCategory control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnAddMainCategory_Click(object sender, EventArgs e) {
        AddMainCategory();
      }

      /// <summary>
      /// Handles the Click event of the btnDeleteMainCategory control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnDeleteMainCategory_Click(object sender, EventArgs e) {
        DeleteMainCategory();
      }

      /// <summary>
      /// Handles the Click event of the btnAddSubCategory control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnAddSubCategory_Click(object sender, EventArgs e) {
        AddSubCategory();
      }

      /// <summary>
      /// Handles the Click event of the btnDeleteSubCategory control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnDeleteSubCategory_Click(object sender, EventArgs e) {
        DeleteSubCategory();
      }

      /// <summary>
      /// Handles the Click event of the btnCancel control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void btnCancel_Click(object sender, EventArgs e) {
        this.Close();
      }

      /// <summary>
      /// Handles the KeyPress event of the txtMainCategory control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
      private void txtMainCategory_KeyPress(object sender, KeyPressEventArgs e) {
        if ((e.KeyChar.ToString() == "\r") && (txtMainCategory.Text != "")) {
          AddMainCategory();
        }
      }

      /// <summary>
      /// Handles the KeyPress event of the txtSubCategory control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
      private void txtSubCategory_KeyPress(object sender, KeyPressEventArgs e) {
        if ((e.KeyChar.ToString() == "\r") && (txtSubCategory.Text != "")) {
          AddSubCategory();
        }
      }

      /// <summary>
      /// Handles the SelectedIndexChanged event of the tbcCategories control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void tbcCategories_SelectedIndexChanged(object sender, EventArgs e) {
        if (tbcCategories.SelectedTab == tbMainCategories) {
          SetFocus(true);
        } else {
          SetFocus(false);
        }
      }
    #endregion Interface
  }
}