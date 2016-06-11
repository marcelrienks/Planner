using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Planner.Persistence{
  /// <summary>
  /// Code for persisting/reading Data object to/from XML file
  /// </summary>
  public static class Persist{
    private static string _path         = string.Empty;
    private static Data _data           = null;

    #region Accessors
    public static Data Data {
      get { return _data; }
      set { _data = value; }
    }
    #endregion Accessors

    /// <summary>
    /// Constructor for Persistince.Persist class
    /// </summary>
    /// <param name="Path"></param>
    static Persist(){
      _path         = (Application.StartupPath + @"\Persistince.Persist.xml");
      Data          = new Data();
      ReadData();
    }

    /// <summary>
    /// this method persists all the data to an xml file in the startup directory
    /// </summary>
    public static void PersistData(){
      try {
        BackupData();

        XmlSerializer serializer        = new XmlSerializer(typeof(Data));
        FileStream fs                   = new FileStream(_path, FileMode.Create);
        serializer.Serialize(fs, Data);
        fs.Close();

        ReadData();
      } catch (Exception ex) {
        Utilities.ShowErrorMessage("Error Persistince.Persisting data to XML file", ex);
      }
    }

    /// <summary>
    /// this method retrives the persisted data from the xml file in the start up directory
    /// </summary>
    public static void ReadData(){
      try{
        if (File.Exists(_path)) {
          XmlSerializer serializer      = new XmlSerializer(typeof(Data));
          FileStream fs                 = new FileStream(_path, FileMode.Open);
          Data = (Data)serializer.Deserialize(fs);
          fs.Close();

        } else {
          DialogResult result           = MessageBox.Show("Error reading data from XML file, Do you want to restore a previous version?", "ERROR",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Error);
          if (result == DialogResult.Yes) {
            RestoreData();
            ReadData();

          } else {
            PersistData();
          }
        }

      } catch (Exception ex){
        Utilities.ShowErrorMessage("Error reading data from XML file.", ex);
      }
    }

    /// <summary>
    /// Backups the data persist.
    /// </summary>
    private static void BackupData() {
      if (File.Exists(_path)) {
        FileInfo fileInfo       = new FileInfo(_path);
        fileInfo.CopyTo(_path + @".bak", true);
      }
    }

    /// <summary>
    /// Restores the data persist.
    /// </summary>
    private static void RestoreData() {
      if (File.Exists(_path + @".bak")) {
        FileInfo fileInfo       = new FileInfo(_path + @".bak");
        fileInfo.CopyTo(_path, true);

      } else {
        MessageBox.Show("Error restoring previous version of XML file, a new XML file will be created.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        PersistData();
      }
    }
  }
}
