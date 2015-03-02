using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTaskManager
{
  public static class DataExtensions
  {
    public static Category GetCategory(this SaveFile file, string id)
    {
      return file.Categories.SingleOrDefault(c => string.Equals(c.ID, id));
    }

    public static string GetName(this Category category)
    {
      if (category == null) return "(None)";
      return category.Name;
    }

    public static string Duplicate(this string str)
    {
      if (str == null) return null;
      return string.Copy(str);
    }

    public static Category Duplicate(this Category category)
    {
      return new Category
      {
        ID = category.ID.Duplicate(),
        Name = category.Name.Duplicate(),
      };
    }

    public static Duration Duplicate(this Duration dur)
    {
      return new Duration
      {
        Days = dur.Days,
        Hours = dur.Hours,
        Minutes = dur.Minutes,
        Weeks = dur.Weeks,
      };
    }

    public static TaskItem Duplicate(this TaskItem task)
    {
      return new TaskItem
      {
        CategoryID = task.CategoryID.Duplicate(),
        ID = task.ID.Duplicate(),
        Importance = task.Importance,
        Name = task.Name.Duplicate(),
        Span = task.Span.Duplicate(),
      };
    }
  }
}
