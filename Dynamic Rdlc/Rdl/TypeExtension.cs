using System;

namespace DynamicRdlc.Rdl
{
    public static class TypeExtension
    {
        public static string GetShortName(this Type type)
        {
            var s = type.ToString();
            return s.Substring(s.LastIndexOf('.') + 1);
        }
    }
}
