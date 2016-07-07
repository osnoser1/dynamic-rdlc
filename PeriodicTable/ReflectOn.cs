namespace PeriodicTable
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    public static class ReflectOn<T>
    {
        public static PropertyInfo GetProperty<TResult>(Expression<Func<T, TResult>> expression)
        {
            return (PropertyInfo)GetMember(expression);
        }

        private static MemberInfo GetMember<TResult>(Expression<Func<T, TResult>> expression)
        {
            var memberExpression = (MemberExpression)expression.Body;
            return memberExpression.Member;
        }
    }
}
