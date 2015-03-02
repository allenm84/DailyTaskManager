using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DailyTaskManager
{
  public static class PropertyName
  {
    public static string Get<TSource, TType>(Expression<Func<TSource, TType>> propertyLambda)
    {
      var info = GetPropertyInfo<TSource, TType>(propertyLambda);
      return info.Name;
    }

    public static PropertyInfo GetPropertyInfo<TSource, TType>(Expression<Func<TSource, TType>> propertyLambda)
    {
      if (propertyLambda == null)
        throw new ArgumentNullException("propertyLambda");

      var body = propertyLambda.Body;

      // make sure that we're actually accessing a property
      MemberExpression member = body as MemberExpression;
      if (member == null)
        throw new ArgumentException(string.Format("Expression '{0}' refers to a method, not a property.", propertyLambda.ToString()));

      // and that its actually a property
      PropertyInfo propInfo = member.Member as PropertyInfo;
      if (propInfo == null)
        throw new ArgumentException(string.Format("Expression '{0}' refers to a field, not a property.", propertyLambda.ToString()));

      return propInfo;
    }
  }
}
