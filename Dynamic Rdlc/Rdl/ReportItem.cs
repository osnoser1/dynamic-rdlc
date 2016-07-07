using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public abstract class ReportItem : IElement
    {
        public Inch Top { get; set; } = new Inch(0);

        public Inch Left { get; set; }

        public Inch Height { get; set; }

        public Inch Width { get; set; }

        public Inch NextTop => Top + Height;

        public XElement Element => Build();

        protected abstract XElement Build();

        protected void ConfigureTop(XElement item)
        {
            if (Top.ToString() != new Inch(0).ToString())
            {
                item.Add(new XElement("Top", Top));
            }
        }

        protected void ConfigureLeft(XElement item)
        {
            if (Left != null)
            {
                item.Add(new XElement("Left", Left));
            }
        }

        protected void ConfigureHeight(XElement item)
        {
            if (Height != null)
            {
                item.Add(new XElement("Height", Height));
            }
        }

        protected void ConfigureWidth(XElement item)
        {
            if (Width != null)
            {
                item.Add(new XElement("Width", Width));
            }
        }
    }
}