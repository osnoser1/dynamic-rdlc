using System.Collections.Generic;
using System.Xml.Linq;

namespace DynamicRdlc.Utils
{
    public static class XElementExtensions
    {
        public static List<XElement> AddIfNotNull<T>(this List<XElement> list, XName name, T value)
        {
            if (value != null)
            {
                list.Add(new XElement(name, value));
            }
            return list;
        }

        public static XElement AddIfNotNull<T>(this XElement element, XName name, T value)
        {
            if (value != null)
            {
                element.Add(new XElement(name, value));
            }
            return element;
        }

    }
}