using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Border : IElement
    {
        public object Style { get; set; }

        public string Color { get; set; }

        public Point Width { get; set; }

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        protected virtual string BorderName
        {
            get
            {
                return "Border";
            }
        }

        private XElement Build()
        {
            if (this.Style == null)
            {
                return null;
            }

            var result = new XElement(this.BorderName);
            result.Add(new XElement("Style", this.Style));
            if (this.Color != null)
            {
                result.Add(new XElement("Color", this.Color));
            }

            if (this.Width != null)
            {
                result.Add(new XElement("Width", this.Width));
            }

            return result;
        }
    }
}
