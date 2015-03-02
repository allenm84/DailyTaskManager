using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DailyTaskManager
{
  [DataContract(Name = "Duration", Namespace = SaveFile.Namespace)]
  public class Duration : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public int Minutes { get; set; }
    [DataMember]
    public int Hours { get; set; }
    [DataMember]
    public int Days { get; set; }
    [DataMember]
    public int Weeks { get; set; }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      if (Weeks > 0)
      {
        sb.AppendFormat("{0}w", Weeks);
      }
      if (Days > 0)
      {
        sb.AppendFormat("{0}d", Days);
      }
      if (Hours > 0)
      {
        sb.AppendFormat("{0}h", Hours);
      }
      if (Minutes > 0)
      {
        sb.AppendFormat("{0}m", Minutes);
      }
      return sb.ToString();
    }
  }
}
