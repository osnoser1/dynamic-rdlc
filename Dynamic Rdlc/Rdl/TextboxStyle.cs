using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class TextboxStyle : Style
    {
        public TextboxStyle()
        {
            PaddingLeft = new Point(2);
            PaddingRight = new Point(2);
            PaddingTop = new Point(2);
            PaddingBottom = new Point(2);
        }

        public Point PaddingLeft { get; set; }

        public Point PaddingRight { get; set; }

        public Point PaddingTop { get; set; }

        public Point PaddingBottom { get; set; }

        public VerticalAlign VerticalAlign { get; set; }

        protected override XElement Build()
        {
            var result = base.Build();
            ConfigurePaddingTop(result);
            ConfigurePaddingBottom(result);
            ConfigurePaddingLeft(result);
            ConfigurePaddingRight(result);
            ConfigureVerticalAlign(result);
            return result;
        }

        private void ConfigurePaddingTop(XElement textboxStyle)
        {
            if (PaddingTop != null)
            {
                textboxStyle.Add(new XElement("PaddingTop", PaddingTop));
            }
        }

        private void ConfigurePaddingBottom(XElement textboxStyle)
        {
            if (PaddingBottom != null)
            {
                textboxStyle.Add(new XElement("PaddingBottom", PaddingBottom));
            }
        }

        private void ConfigurePaddingLeft(XElement textboxStyle)
        {
            if (PaddingLeft != null)
            {
                textboxStyle.Add(new XElement("PaddingLeft", PaddingLeft));
            }
        }

        private void ConfigurePaddingRight(XElement textboxStyle)
        {
            if (PaddingRight != null)
            {
                textboxStyle.Add(new XElement("PaddingRight", PaddingRight));
            }
        }

        private void ConfigureVerticalAlign(XElement textboxStyle)
        {
            if (VerticalAlign != VerticalAlign.Default)
            {
                textboxStyle.Add(new XElement("VerticalAlign", VerticalAlign));
            }
        }
    }
}