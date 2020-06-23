using HtmlParser.Exceptions;
using System.Linq.Expressions;
using System.Reflection;

namespace HtmlParser.Extensions
{
    public static class LambdaExtensions
    {
        public static TModel Set<TModel, TValue>(this TModel model, MemberExpression memberExpression, TValue value)
        {
            if (!(memberExpression.Member is PropertyInfo propertyInfo))
            {
                throw new PropertyNotFoundException(memberExpression.Member.Name, model.GetType());
            }

            object target = model.GetTarget(memberExpression.Expression);
            propertyInfo.SetValue(target, value, null);
            return model;
        }

        private static object GetTarget(this object model, Expression expr)
        {
            switch (expr.NodeType)
            {
                case ExpressionType.Parameter:
                    return model;
                case ExpressionType.MemberAccess:
                    var memberExpression = (MemberExpression)expr;
                    if (!(memberExpression.Member is PropertyInfo propertyInfo))
                    {
                        throw new PropertyNotFoundException(memberExpression.Member.Name, model.GetType());
                    }
                    object target = model.GetTarget(memberExpression.Expression);
                    return propertyInfo.GetValue(target, null);
                default:
                    throw new NotPropertyException(model.GetType());
            }
        }
    }
}
