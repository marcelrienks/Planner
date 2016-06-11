using System;
using System.Collections.Generic;
using System.Text;
using Planner.Components;

namespace Planner.Persistence {
  /// <summary>
  /// Holds data for the Planner Project
  /// </summary>
  public class Data{
    private List<ToDo> _todoList                        = null;
    private List<TimeSheetDay> _timeSheetDayList        = null;
    private List<Notes> _notesList                      = null;
    private List<MainCategories> _mainCategoriesList    = null;
    private List<SubCategories> _subCategoriesList      = null;

    #region Accessors
    public List<ToDo> TodoList {
      get { return _todoList; }
      set { _todoList = value; }
    }
    public List<TimeSheetDay> TimeSheetDayList {
      get { return _timeSheetDayList; }
      set { _timeSheetDayList = value; }
    }
    public List<Notes> NotesList {
      get { return _notesList; }
      set { _notesList = value; }
    }
    public List<MainCategories> MainCategoriesList {
      get { return _mainCategoriesList; }
      set { _mainCategoriesList = value; }
    }
    public List<SubCategories> SubCategoriesList {
      get { return _subCategoriesList; }
      set { _subCategoriesList = value; }
    }
    #endregion Accessors

    /// <summary>
    /// Constructor for Data class
    /// </summary>
    public Data(){
      TodoList              = new List<ToDo>();
      TimeSheetDayList      = new List<TimeSheetDay>();
      NotesList             = new List<Notes>();
      MainCategoriesList    = new List<MainCategories>();
      SubCategoriesList     = new List<SubCategories>();
    }
  }
}
