using System;
using System.Collections.Generic;
using System.Text;

namespace Planner.Components {

  /// <summary>
  /// TimeSheet Object
  /// </summary>
  public class TimeSheet{
    private string _GUID                      = string.Empty;
    private DateTime _date;
    private string _task                      = string.Empty;
    private string _todoTaskGuid;
    private string _mainCategoryGuid          = string.Empty;
    private string _subCategoryGuid           = string.Empty;
    private DateTime _startTime;
    private DateTime _endTime;
    private string _jobTime                   = string.Empty;

    #region Accessors
    public string GUID {
      get { return _GUID; }
      set { _GUID = value; }
    }
    public DateTime Date {
      get { return _date; }
      set { _date = value; }
    }
    public string Task {
      get { return _task; }
      set { _task = value; }
    }
    public string TodoTaskGuid {
      get { return _todoTaskGuid; }
      set { _todoTaskGuid = value; }
    }
    public string MainCategoryGuid {
      get {return _mainCategoryGuid;}
      set {_mainCategoryGuid = value;}
    }
    public string SubCategoryGuid {
      get {return _subCategoryGuid;}
      set {_subCategoryGuid = value;}
    }
    public DateTime StartTime {
      get { return _startTime; }
      set { _startTime = value; }
    }
    public DateTime EndTime {
      get { return _endTime; }
      set { _endTime = value; }
    }
    public string JobTime {
      get { return _jobTime; }
      set { _jobTime = value; }
    }
    #endregion Accessors
  }

  /// <summary>
  /// TimeSheet day Object
  /// </summary>
  public class TimeSheetDay{
    private string _GUID                      = string.Empty;
    private DateTime _day;
    private List<TimeSheet> _timeSheetList;
    private string _daytime                   = string.Empty;
    
    public TimeSheetDay(){
      _timeSheetList      = new List<TimeSheet>();
    }

    #region Accesors
    public string GUID {
      get { return _GUID; }
      set { _GUID = value; }
    }
    public DateTime Day {
      get { return _day; }
      set { _day = value; }
    }
    public List<TimeSheet> TimeSheetList {
      get { return _timeSheetList; }
      set { _timeSheetList = value; }
    }
    public string DayTime {
      get { return _daytime; }
      set { _daytime = value; }
    }
    #endregion Accesors
  }
}
