using System;
using System.Collections.Generic;
using System.Text;
using Planner.Components;
using Planner.Persistence;

namespace Planner.Controls {
  /// <summary>
  /// Control for the TimeSheet items
  /// </summary>
  public class TimeSheetControl {

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeSheet"/> class.
    /// </summary>
    public TimeSheetControl(){
    }

    /// <summary>
    /// Finds the index of the time sheet day.
    /// </summary>
    /// <param name="timeSheetDay">The time sheet day.</param>
    /// <returns></returns>
    public int FindTimeSheetDayIndex(string guid){
      int result = -1;
      
      for (int ct = 0; ct < Persistence.Persist.Data.TimeSheetDayList.Count; ct++) {
        if (guid == Persistence.Persist.Data.TimeSheetDayList[ct].GUID) {
          result = ct;
        }
      }
      return result;
    }

    /// <summary>
    /// Finds the index of the time sheet item.
    /// </summary>
    /// <param name="timeSheetItem">The time sheet item.</param>
    /// <param name="timeSheetDayIndex">Index of the time sheet day.</param>
    /// <returns></returns>
    public int FindTimeSheetItemIndex(string itemGuid, string dayGuid){
      int result = -1;
      int dayIndex = FindTimeSheetDayIndex(dayGuid);

      for (int ct = 0; ct < Persistence.Persist.Data.TimeSheetDayList[dayIndex].TimeSheetList.Count; ct++) {
        if (itemGuid == Persistence.Persist.Data.TimeSheetDayList[dayIndex].TimeSheetList[ct].GUID) {
          result = ct;
        }
      }
      return result;
    }

    /// <summary>
    /// Adds the specified time sheet item.
    /// </summary>
    /// <param name="timeSheetItem">The time sheet item.</param>
    /// <param name="timeSheetDay">The time sheet day.</param>
    public void Add(TimeSheet timeSheetItem, TimeSheetDay timeSheetDay){
      int dayIndex                          = FindTimeSheetDayIndex(timeSheetDay.GUID);

      if (dayIndex != -1) {
        Persistence.Persist.Data.TimeSheetDayList[dayIndex].TimeSheetList.Add(timeSheetItem);
      } else {
        Persistence.Persist.Data.TimeSheetDayList.Add(timeSheetDay);
        Persist();
        dayIndex                            = FindTimeSheetDayIndex(timeSheetDay.GUID);
        Persistence.Persist.Data.TimeSheetDayList[dayIndex].Day      = timeSheetDay.Day;
        Persistence.Persist.Data.TimeSheetDayList[dayIndex].TimeSheetList.Add(timeSheetItem);
      }
      Persist();
    }

    /// <summary>
    /// Edits the specified time sheet item.
    /// </summary>
    /// <param name="timeSheetItem">The time sheet item.</param>
    /// <param name="day">The day.</param>
    /// <param name="timeSheetItemIndex">Index of the time sheet item.</param>
    public bool Edit(TimeSheet timeSheetItem, TimeSheetDay timeSheetDay) {
      bool status                 = false;
      int timeSheetDayIndex       = FindTimeSheetDayIndex(timeSheetDay.GUID);
      int index                   = FindTimeSheetItemIndex(timeSheetItem.GUID, timeSheetDay.GUID);

      if (index != -1) {
        Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[index]       = timeSheetItem;
        Persist();
        status                    = true;
      }

      return status;
    }

    /// <summary>
    /// Deletes the specified day.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <param name="timeSheetItemIndex">Index of the time sheet item.</param>
    public void Delete(string guid, TimeSheetDay timeSheetDay) {
      int timeSheetDayIndex       = FindTimeSheetDayIndex(timeSheetDay.GUID);
      int index                   = FindTimeSheetItemIndex(guid, timeSheetDay.GUID);

      Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.RemoveAt(index);
      if (Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count == 0) {
        Persistence.Persist.Data.TimeSheetDayList.RemoveAt(timeSheetDayIndex);
      }
      Persist();
    }

    /// <summary>
    /// Inserts the specified time sheet item.
    /// </summary>
    /// <param name="timeSheetItem">The time sheet item.</param>
    /// <param name="timeSheetDay">The time sheet day.</param>
    /// <param name="insertPosition">The insert position.</param>
    public void Insert(TimeSheet timeSheetItem, TimeSheetDay timeSheetDay, TimeSheet insertPosition){
      int timeSheetDayIndex       = FindTimeSheetDayIndex(timeSheetDay.GUID);
      int index                   = FindTimeSheetItemIndex(insertPosition.GUID, timeSheetDay.GUID);

      Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Insert(index, timeSheetItem);
      Persist();
    }

    /// <summary>
    /// Sets the last time sheet items end time Or gets the next time sheet items start time. (Subject to Options settings)
    /// </summary>
    /// <param name="day">The day.</param>
    /// <returns></returns>
    public DateTime SetLastTimeSheetItemsEndTime(TimeSheetDay timeSheetDayItem){
      int timeSheetDayIndex       = FindTimeSheetDayIndex(timeSheetDayItem.GUID);

      DateTime result             = DateTime.Now;
      if (timeSheetDayIndex != -1) {
        if (Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count > 0) {
          DateTime validation     = new DateTime();
          if (Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1].EndTime == validation) {
            if (Properties.Settings.Default.TimeSheet_SetEndTime) {
              Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1].EndTime      = result;
              Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1].JobTime      = TimeSheetControl.CalculateJobTime(Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1]);
            }
            Persist();

          } else {
            if (Properties.Settings.Default.TimeSheet_SetStartTime) {
              result      = Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1].EndTime;
            }
	        }
        }
      }
      return result;
    }

    /// <summary>
    /// Sets the last time sheet items end time Or gets the next time sheet items start time. (Subject to Options settings)
    /// </summary>
    /// <param name="timeSheetItem">The time sheet item.</param>
    /// <param name="timeSheetDayItem">The time sheet day item.</param>
    /// <returns></returns>
    public DateTime SetLastTimeSheetItemsEndTime(TimeSheet timeSheetItem, TimeSheetDay timeSheetDayItem){
      int timeSheetDayIndex       = FindTimeSheetDayIndex(timeSheetDayItem.GUID);

      DateTime result             = new DateTime();
      if (timeSheetDayIndex != -1) {
        if (Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count > 0) {
          DateTime validation     = new DateTime();

          if (Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1].EndTime == validation) {
            if (Properties.Settings.Default.TimeSheet_SetEndTime) {
              Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1].EndTime      = timeSheetItem.StartTime;
              Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1].JobTime      = TimeSheetControl.CalculateJobTime(Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1]);
              result              = Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList[Persistence.Persist.Data.TimeSheetDayList[timeSheetDayIndex].TimeSheetList.Count - 1].EndTime;
            }
            Persist();
          }
        }
      }
      return result;
    }

    /// <summary>
    /// Gets the index from date.
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns></returns>
    public int[] GetIndexFromDate(DateTime[] dates){
      int[] result        = new int[dates.Length];

      for (int ct1 = 0; ct1 < dates.Length; ct1++) {
        result[ct1]       = -1;

        for (int ct2 = 0; ct2 < Persistence.Persist.Data.TimeSheetDayList.Count; ct2++) {
          if ((dates[ct1].Year == Persistence.Persist.Data.TimeSheetDayList[ct2].Day.Year) && (dates[ct1].Month == Persistence.Persist.Data.TimeSheetDayList[ct2].Day.Month) && (dates[ct1].Day == Persistence.Persist.Data.TimeSheetDayList[ct2].Day.Day)) {
            result[ct1]   = ct2;
          }
        }
      }
      return result;
    }

    /// <summary>
    /// Calculates the job time.
    /// </summary>
    /// <param name="timeSheetItem">The time sheet item.</param>
    /// <returns></returns>
    public static string CalculateJobTime(TimeSheet timeSheetItem){
      string result = string.Empty;

      if (timeSheetItem.EndTime.TimeOfDay > timeSheetItem.StartTime.TimeOfDay) {
        result = Convert.ToString(timeSheetItem.EndTime.TimeOfDay - timeSheetItem.StartTime.TimeOfDay).Substring(0, 8);
      } else {
        result = "--:--:--";
      }

      return result;
    }

    /// <summary>
    /// Gets the display name of the time sheet. (Subject to Options settings)
    /// </summary>
    /// <returns></returns>
    public string GetTimeSheetDisplayName(TimeSheet timeSheetItem){
      string result       = string.Empty;

      if (Properties.Settings.Default.TimeSheet_ShowJobTime) {
        if (timeSheetItem.Task.Length > 80) {
          result            = timeSheetItem.Task.Substring(0, 80) + "...";

        } else {
          result            = timeSheetItem.Task.Substring(0, timeSheetItem.Task.Length);
        }

      } else {
        if (timeSheetItem.Task.Length > 90) {
          result            = timeSheetItem.Task.Substring(0, 90) + "...";

        } else {
          result            = timeSheetItem.Task.Substring(0, timeSheetItem.Task.Length);
        }
      }

      int enterKey        = result.IndexOf("\n");
      if (enterKey != -1) {
        result            = result.Substring(0, enterKey);
        result            = result + "...";
      }
      return result;
    }

    /// <summary>
    /// Persistince.Persists this instance.
    /// </summary>
    private void Persist() {
      Persistence.Persist.PersistData();
    }
  }
}