using System;
using System.Collections.Generic;
using System.Text;

namespace Planner.Components {
  /// <summary>
  /// Notes object
  /// </summary>
  public class Notes {
    private string _GUID      = string.Empty;
    private string _note      = string.Empty;
    private DateTime _date;

    #region Accessors
    public string GUID {
      get { return _GUID; }
      set { _GUID = value; }
    }
    public string Note {
      get { return _note; }
      set { _note = value; }
    }
    public DateTime Date {
      get { return _date; }
      set { _date = value; }
    }
    #endregion Accessors
  }
}
