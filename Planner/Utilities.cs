using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Planner {
  /// <summary>
  /// General Utilities for Planner project
  /// </summary>
  public static class Utilities {

    /// <summary>
    /// Shows the error message.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="ex">The ex.</param>
    public static void ShowErrorMessage(string message, Exception ex) {
      MessageBox.Show(message + "\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /// <summary>
    /// Gets the row indexes.
    /// </summary>
    /// <param name="rows">The rows.</param>
    /// <returns></returns>
    public static int[] GetRowIndexes(DataGridViewSelectedRowCollection rows){
      int[] result      = new int[rows.Count];

      for (int ct = 0; ct < rows.Count; ct++) {
        result[ct]      = rows[ct].Index;
      }
      result            = SortInt(result);
      return result;
    }

    /// <summary>
    /// Sorts the int.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns></returns>
    public static int[] SortInt(int[] list){
      int[] result      = new int[list.Length];

      for (int ct = 0; ct < list.Length - 1; ct++) {
        if (list[ct] > list[ct + 1]) {
          int temp      = list[ct];
          list[ct]      = list[ct + 1];
          list[ct + 1]  = temp;

          SortInt(list);
        }
      }
      result = list;
      return result;
    }

    /// <summary>
    /// Decrements the each element.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns></returns>
    public static int[] DecrementEachElement(int[] list){
      int[] result        = new int[list.Length];

      for (int ct = 0; ct < list.Length; ct++) {
          result[ct]      = list[ct] - 1;
      }
      return result;
    }

    /// <summary>
    /// Gets the dates indexed.
    /// </summary>
    /// <param name="start">The start.</param>
    /// <param name="end">The end.</param>
    /// <returns></returns>
    public static DateTime[] GetDatesIndexed(SelectionRange dateRange){
      DateTime[] result       = new DateTime[(dateRange.End.Day - dateRange.Start.Day) + 1];

      for (int ct = 0; ct < result.Length; ct++) {
        result[ct]            = dateRange.Start.AddDays(ct);
      }
      return result;
    }

    /// <summary>
    /// Calculates the totol time.
    /// </summary>
    /// <param name="time">The time.</param>
    /// <returns></returns>
    public static string CalculateTotalTime(List<string> time){
      string result             = "00:00:00";

      for (int ct = 0; ct < time.Count; ct++) {
        TimeSpan timeSpan       = Convert.ToDateTime(result).TimeOfDay + Convert.ToDateTime(time[ct]).TimeOfDay;
        result                  = timeSpan.ToString().Substring(0, 8);
      }
      return result;
    }

    /// <summary>
    /// Gets new GUID.
    /// </summary>
    /// <returns></returns>
    public static string GetNewGUID(){
      string result = string.Empty;

      Guid guid = Guid.NewGuid();
      result = guid.ToString();

      return result;
    }

    /// <summary>
    /// Cleans the return carages from multi lines text.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    public static string CleanMultiLines(string data){
      string result = string.Empty;

      data = data.Replace("\n", "\r\n");

      result = data;
      return result;
    }
  }
}
