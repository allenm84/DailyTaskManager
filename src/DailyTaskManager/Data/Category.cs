﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DailyTaskManager
{
  [DataContract(Name = "Category", Namespace = SaveFile.Namespace)]
  public class Category : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string Name { get; set; }
  }
}
