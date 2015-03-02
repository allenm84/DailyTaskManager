using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTaskManager
{
  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public class SaveFile : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    public const string Namespace = "http://www.mapa.com/apps/DailyTaskManager";

    static string filepath;
    static DataContractSerializer dcs;
    static SaveFile instance;

    static SaveFile()
    {
      dcs = new DataContractSerializer(typeof(SaveFile));
      filepath = Path.Combine(Application.StartupPath, "saved.xml");
    }

    public static SaveFile Instance { get { return instance; } }
    public static bool IsLoaded { get { return (instance != null); } }
    public static event EventHandler Loaded;

    public static void Load()
    {
      SaveFile s = null;
      if (File.Exists(filepath))
      {
        using (var stream = File.OpenRead(filepath))
        {
          s = dcs.ReadObject(stream) as SaveFile;
        }
      }

      instance = (s ?? new SaveFile());
      instance.Initialize();

      if (Loaded != null)
      {
        Loaded(instance, EventArgs.Empty);
      }
    }

    public static void Save()
    {
      using (var stream = new MemoryStream())
      {
        dcs.WriteObject(stream, instance);
        File.WriteAllBytes(filepath, stream.ToArray());
      }
    }

    private void Initialize()
    {
      if (Categories == null) Categories = new List<Category>();
      if (Tasks == null) Tasks = new List<TaskItem>();
      if (Days == null) Days = new Dictionary<DateTime, List<DailyTaskItem>>();
      if (Dialogs == null) Dialogs = new Dictionary<string, Size>();
      if (Volume == null) Volume = 0.1f;
    }

    private SaveFile() { }

    [DataMember]
    public List<Category> Categories { get; set; }
    [DataMember]
    public List<TaskItem> Tasks { get; set; }
    [DataMember]
    public Dictionary<DateTime, List<DailyTaskItem>> Days { get; set; }
    [DataMember]
    public Dictionary<string, Size> Dialogs { get; set; }
    [DataMember]
    public float? Volume { get; set; }
  }
}
