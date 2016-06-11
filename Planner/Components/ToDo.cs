using System;
using System.Collections.Generic;
using System.Text;

namespace Planner.Components{
  /// <summary>
  /// Todo Object
  /// </summary>
  public class ToDo{
    private string _GUID              = string.Empty;
    private bool _complete            = false;
    private string _task              = string.Empty;
    private string _desc              = string.Empty;
    private DateTime _startDate;
    private DateTime _DueDate;

    #region Accessors
    public string GUID {
      get { return _GUID; }
      set { _GUID = value; }
    }
    public bool Complete{
      get { return _complete; }
      set { _complete = value; }
    }
    public string Task{
      get { return _task; }
      set { _task = value; }
    }
    public string Desc{
      get { return _desc; }
      set { _desc = value; }
    }
    public DateTime StartDate{
      get { return _startDate; }
      set { _startDate = value; }
    }
    public DateTime DueDate{
      get { return _DueDate; }
      set { _DueDate = value; }
    }
    #endregion Accessors
  }
}
