using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Border : IElement
    {
        public object Style { get; set; }

        public string Color { get; set; }

        public Point Width { get; set; }

        protected virtual string BorderName => "Border";

        public XElement Element => Build();

        private XElement Build()
        {
            if (Style == null)
            {
                return null;
            }

            var result = new XElement(BorderName);
            result.Add(new XElement("Style", Style));
            if (Color != null)
            {
                result.Add(new XElement("Color", Color));
            }

            if (Width != null)
            {
                result.Add(new XElement("Width", Width));
            }

            return result;
        }
    }
}