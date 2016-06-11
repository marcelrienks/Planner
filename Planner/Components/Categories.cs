using System;
using System.Collections.Generic;
using System.Text;

namespace Planner.Components {
  /// <summary>
  /// Categories object
  /// </summary>
  public class MainCategories {
    private string _guid;
    private string _category;

    #region Accessors
    public string GUID {
      get {return _guid;}
      set {_guid = value;}
    }
    public string Category {
      get { return _category; }
      set { _category = value; }
    }
    #endregion Accessors
  }

  public class SubCategories{
    private string _guid;
    private string _category;

    #region Accessors
    public string GUID {
      get { return _guid; }
      set { _guid = value; }
    }
    public string Category {
      get { return _category; }
      set { _category = value; }
    }
    #endregion Accessors
  }
}
