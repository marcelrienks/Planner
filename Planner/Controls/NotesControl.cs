using System;
using System.Collections.Generic;
using System.Text;
using Planner.Persistence;
using Planner.Components;
using Planner.Controls.Properties;

namespace Planner.Controls {
  /// <summary>
  /// Control for the Notes items
  /// </summary>
  public class NotesControl {

    /// <summary>
    /// Initializes a new instance of the <see cref="NotesControl"/> class.
    /// </summary>
    public NotesControl(){
    }

    /// <summary>
    /// Finds the index of the notes.
    /// </summary>
    /// <param name="note">The note.</param>
    /// <returns></returns>
    public int FindNotesIndex(string guid){
      int result      = -1;

      for (int ct = 0; ct < Persistence.Persist.Data.NotesList.Count; ct++) {
        if (guid == Persistence.Persist.Data.NotesList[ct].GUID) {
          result      = ct;
        }
      }
      return result;
    }
    
    /// <summary>
    /// Adds the specified notes item.
    /// </summary>
    /// <param name="notesItem">The notes item.</param>
    public void Add(Notes notesItem){
      Persistence.Persist.Data.NotesList.Add(notesItem);
      Persist();
    }

    /// <summary>
    /// Edits the specified notes item.
    /// </summary>
    /// <param name="notesItem">The notes item.</param>
    public bool Edit(Notes notesItem){
      bool status             = false;
      int index               = FindNotesIndex(notesItem.GUID);

      if (index != -1) {
        Persistence.Persist.Data.NotesList[index]      = notesItem;
        Persist();
        status                              = true;
      }

      return status;
    }

    /// <summary>
    /// Deletes the specified index.
    /// </summary>
    /// <param name="notesItem">The notes item.</param>
    public void Delete(string guid){
      int index       = FindNotesIndex(guid);
      Persistence.Persist.Data.NotesList.RemoveAt(index);
      Persist();
    }

    /// <summary>
    /// Gets the name of the note. (Subject to Options settings)
    /// </summary>
    /// <param name="noteItem">The note item.</param>
    /// <returns></returns>
    public string GetNoteDisplayName(Notes noteItem){
      string result       = string.Empty;

      if (noteItem.Note.Length > 30) {
        result            = noteItem.Note.Substring(0, 30) + "...";
      } else {
        result            = noteItem.Note.Substring(0, noteItem.Note.Length);
      }

      int enterKey        = result.IndexOf("\n");
      if (enterKey != -1) {
        result            = result.Substring(0, enterKey);
      }

      if (Settings.Default.Note_AddDateToName) {
        result            = noteItem.Date.ToShortDateString() + "     " + result;
      }
      return result;
    }

    /// <summary>
    /// Gets the note. (Subject to Options settings)
    /// </summary>
    /// <param name="noteItem">The note item.</param>
    /// <returns></returns>
    public string GetNote(Notes noteItem){
      string result       = string.Empty;

      result              = Utilities.CleanMultiLines(noteItem.Note);
        if (Settings.Default.Note_AppendDateToNote) {
          result          += "\r\n\r\n\r\n-----------------------------------\r\n" + noteItem.Date;
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
