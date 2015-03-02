using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Repository;

namespace DailyTaskManager
{
  public static class Factory
  {
    public static void FillImportanceLookUpEdit(RepositoryItemLookUpEdit cboImportance)
    {
      cboImportance.DataSource = (
        from Importance i in System.Enum.GetValues(typeof(Importance))
        select new
        {
          Display = string.Format("{0}/5", (int)i),
          Value = i
        }).ToList();
      cboImportance.DisplayMember = "Display";
      cboImportance.ValueMember = "Value";
    }
  }
}
