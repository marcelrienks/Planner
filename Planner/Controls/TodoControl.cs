using System;
using System.Collections.Generic;
using System.Text;
using Planner.Persistence;
using Planner.Components;

namespace Planner.Controls {
  /// <summary>
  /// Control for the Todo Items
  /// </summary>
  public class TodoControl {
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Todo"/> class.
    /// </summary>
    public TodoControl() {
    }

    /// <summary>
    /// Finds the index of the todo.
    /// </summary>
    /// <param name="todo">The todo.</param>
    /// <returns></returns>
    public int FindTodoIndex(string guid){
      int result      = -1;

      for (int ct = 0; ct < Persistence.Persist.Data.TodoList.Count; ct++) {
        if (guid == Persistence.Persist.Data.TodoList[ct].GUID) {
          result      = ct;
        }
      }
      return result;
    }

    /// <summary>
    /// Finds the todo items GUID.
    /// </summary>
    /// <returns></returns>
    public static string FindTodoItemsGuid(string todoItemTask){
      string result       = string.Empty;

      for (int ct = 0; ct < Persistence.Persist.Data.TodoList.Count; ct++) {
        if (todoItemTask == Persistence.Persist.Data.TodoList[ct].Task) {
          result          = Persistence.Persist.Data.TodoList[ct].GUID;
        }
      }
      return result;
    }

    /// <summary>
    /// Finds the todo item.
    /// </summary>
    /// <param name="guid">The GUID.</param>
    /// <returns></returns>
    public static string FindTodoItem(string guid){
      string result       = string.Empty;

      for (int ct = 0; ct < Persistence.Persist.Data.TodoList.Count; ct++) {
        if (guid == Persistence.Persist.Data.TodoList[ct].GUID) {
          result          = Persistence.Persist.Data.TodoList[ct].Task;
        }
      }
      return result;
    }

    /// <summary>
    /// Adds the specified todo.
    /// </summary>
    /// <param name="todo">The todo.</param>
    public void Add(ToDo todoItem) {
      Persistence.Persist.Data.TodoList.Add(todoItem);
      Persist();
    }

    /// <summary>
    /// Edits the specified todo item.
    /// </summary>
    /// <param name="todoItem">The todo item.</param>
    /// <param name="index">The index.</param>
    public bool Edit(ToDo todoItem) {
      bool status             = false;
      int index               = FindTodoIndex(todoItem.GUID);

      if (index != -1) {
        Persistence.Persist.Data.TodoList[index]       = todoItem;
        Persist();
        status                              = true;
      }

      return status;
    }

    /// <summary>
    /// Deletes the specified index.
    /// </summary>
    /// <param name="index">The index.</param>
    public void Delete(string guid) {
      int index = FindTodoIndex(guid);
      Persistence.Persist.Data.TodoList.RemoveAt(index);
      Persist();
    }

    /// <summary>
    /// Changes the task status.
    /// </summary>
    /// <param name="guid">The GUID.</param>
    public bool ChangeTaskStatus(string guid) {
      bool result                               = false;

      int index                                 = FindTodoIndex(guid);
      Persistence.Persist.Data.TodoList[index].Complete    = !(Persistence.Persist.Data.TodoList[index].Complete);
      result                                    = Persistence.Persist.Data.TodoList[index].Complete;
      Persist();
      return result;
    }

    /// <summary>
    /// Gets the display name of the time sheet.
    /// </summary>
    /// <returns></returns>
    public string GetTodoItemDisplayName(ToDo todoItem){
      string result       = string.Empty;

      if (todoItem.Desc.Length > 60) {
        result            = todoItem.Desc.Substring(0, 60) + "...";
      } else {
        result            = todoItem.Desc.Substring(0, todoItem.Desc.Length);
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