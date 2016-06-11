using System;
using System.Collections.Generic;
using System.Text;
using Planner.Components;
using Planner.Persistence;

namespace Planner.Controls {
  /// <summary>
  /// Control for the Categories item
  /// </summary>
  public class CategoriesControl {

    /// <summary>
    /// Initializes a new instance of the <see cref="CategoriesControl"/> class.
    /// </summary>
    public CategoriesControl(){
    }

    /// <summary>
    /// Finds the index of the main categories.
    /// </summary>
    /// <param name="mainCategory">The main category.</param>
    /// <returns></returns>
    public int FindMainCategoriesIndex(string mainCategory){
      int result      = -1;

      for (int ct = 0; ct < Persistence.Persist.Data.MainCategoriesList.Count; ct++) {
        if (mainCategory == Persistence.Persist.Data.MainCategoriesList[ct].Category) {
          result      = ct;
        }
      }
      return result;
    }

    /// <summary>
    /// Finds the main categories GUID.
    /// </summary>
    /// <returns></returns>
    public static string FindMainCategoriesGuid(string mainCategory){
      string result       = string.Empty;

      for (int ct = 0; ct < Persistence.Persist.Data.MainCategoriesList.Count; ct++) {
        if (mainCategory == Persistence.Persist.Data.MainCategoriesList[ct].Category) {
          result          = Persistence.Persist.Data.MainCategoriesList[ct].GUID;
        }
      }
      return result;
    }

    /// <summary>
    /// Finds the main category.
    /// </summary>
    /// <param name="guid">The GUID.</param>
    /// <returns></returns>
    public static string FindMainCategory(string guid){
      string result       = string.Empty;

      for (int ct = 0; ct < Persistence.Persist.Data.MainCategoriesList.Count; ct++) {
        if (guid == Persistence.Persist.Data.MainCategoriesList[ct].GUID) {
          result          = Persistence.Persist.Data.MainCategoriesList[ct].Category;
        }
      }
      return result;
    }

    /// <summary>
    /// Finds the index of the sub categories.
    /// </summary>
    /// <param name="subCategory">The sub category.</param>
    /// <returns></returns>
    public int FindSubCategoriesIndex(string subCategory){
      int result      = -1;

      for (int ct = 0; ct < Persistence.Persist.Data.SubCategoriesList.Count; ct++) {
        if (subCategory == Persistence.Persist.Data.SubCategoriesList[ct].Category) {
          result      = ct;
        }
      }
      return result;
    }

    /// <summary>
    /// Finds the sub categories GUID.
    /// </summary>
    /// <returns></returns>
    public static string FindSubCategoriesGuid(string subCategory){
      string result       = string.Empty;

      for (int ct = 0; ct < Persistence.Persist.Data.SubCategoriesList.Count; ct++) {
        if (subCategory == Persistence.Persist.Data.SubCategoriesList[ct].Category) {
          result          = Persistence.Persist.Data.SubCategoriesList[ct].GUID;
        }
      }
      return result;
    }

    /// <summary>
    /// Finds the sub category.
    /// </summary>
    /// <param name="guid">The GUID.</param>
    /// <returns></returns>
    public static string FindSubCategory(string guid){
      string result       = string.Empty;

      for (int ct = 0; ct < Persistence.Persist.Data.SubCategoriesList.Count; ct++) {
        if (guid == Persistence.Persist.Data.SubCategoriesList[ct].GUID) {
          result          = Persistence.Persist.Data.SubCategoriesList[ct].Category;
        }
      }
      return result;
    }

    /// <summary>
    /// Adds a main category.
    /// </summary>
    /// <param name="mainCategory">The main category.</param>
    public void AddMainCategory(MainCategories mainCategory){
      Persistence.Persist.Data.MainCategoriesList.Add(mainCategory);
      Persist();
    }

    /// <summary>
    /// Adds a sub category.
    /// </summary>
    /// <param name="subCategory">The sub category.</param>
    public void AddSubCategory(SubCategories subCategory){
      Persistence.Persist.Data.SubCategoriesList.Add(subCategory);
      Persist();
    }

    /// <summary>
    /// Deletes a main category.
    /// </summary>
    /// <param name="mainCategory">The main category.</param>
    public void DeleteMainCategory(string mainCategory){
      int index       = FindMainCategoriesIndex(mainCategory);
      Persistence.Persist.Data.MainCategoriesList.RemoveAt(index);
      Persist();
    }

    /// <summary>
    /// Deletes a sub category.
    /// </summary>
    /// <param name="subCategory">The sub category.</param>
    public void DeleteSubCategory(string mainCategory){
      int index       = FindSubCategoriesIndex(mainCategory);
      Persistence.Persist.Data.SubCategoriesList.RemoveAt(index);
      Persist();
    }

    /// <summary>
    /// Persistince.Persists this instance.
    /// </summary>
    private void Persist() {
      Persistence.Persist.PersistData();
    }
  }
}