using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTaskManager
{
  public class WorkerToggle : IDisposable
  {
    private Action<bool> toggle;
    private bool value;

    public WorkerToggle(Action<bool> toggle, bool value = true)
    {
      this.toggle = toggle;
      this.value = value;
      toggle(value);
    }

    void IDisposable.Dispose()
    {
      value = !value;
      toggle(value);
    }
  }
}
