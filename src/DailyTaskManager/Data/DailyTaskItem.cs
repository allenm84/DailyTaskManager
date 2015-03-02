using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DailyTaskManager
{
  [DataContract(Name = "DailyTaskItem", Namespace = SaveFile.Namespace)]
  public class DailyTaskItem : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public string TaskID { get; set; }
    [DataMember]
    public int Order { get; set; }
    [DataMember]
    public Duration Span { get; set; }
    [DataMember]
    public bool Completed { get; set; }
  }
}
