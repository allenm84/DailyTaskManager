using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DailyTaskManager
{
  [DataContract(Name = "Importance", Namespace = SaveFile.Namespace)]
  public enum Importance : int
  {
    [EnumMember]
    One = 1,
    [EnumMember]
    Two,
    [EnumMember]
    Three,
    [EnumMember]
    Four,
    [EnumMember]
    Five,
  }
}
