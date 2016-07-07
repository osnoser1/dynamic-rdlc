using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class TextboxStyle : Style
    {
        public TextboxStyle()
        {
            this.PaddingLeft = new Point(2);
            this.PaddingRight = new Point(2);
            this.PaddingTop = new Point(2);
            this.PaddingBottom = new Point(2);
        }

        public Point PaddingLeft { get; set; }

        public Point PaddingRight { get; set; }

        public Point PaddingTop { get; set; }

        public Point PaddingBottom { get; set; }

        public VerticalAlign VerticalAlign { get; set; }

        protected override XElement Build()
        {
            var result = base.Build();
            this.ConfigurePaddingTop(result);
            this.ConfigurePaddingBottom(result);
            this.ConfigurePaddingLeft(result);
            this.ConfigurePaddingRight(result);
            this.ConfigureVerticalAlign(result);
            return result;
        }

        private void ConfigurePaddingTop(XElement textboxStyle)
        {
            if (this.PaddingTop != null)
            {
                textboxStyle.Add(new XElement("PaddingTop", this.PaddingTop));
            }
        }

        private void ConfigurePaddingBottom(XElement textboxStyle)
        {
            if (this.PaddingBottom != null)
            {
                textboxStyle.Add(new XElement("PaddingBottom", this.PaddingBottom));
            }
        }

        private void ConfigurePaddingLeft(XElement textboxStyle)
        {
            if (this.PaddingLeft != null)
            {
                textboxStyle.Add(new XElement("PaddingLeft", this.PaddingLeft));
            }
        }

        private void ConfigurePaddingRight(XElement textboxStyle)
        {
            if (this.PaddingRight != null)
            {
                textboxStyle.Add(new XElement("PaddingRight", this.PaddingRight));
            }
        }

        private void ConfigureVerticalAlign(XElement textboxStyle)
        {
            if (this.VerticalAlign != VerticalAlign.Default)
            {
                textboxStyle.Add(new XElement("VerticalAlign", this.VerticalAlign));
            }
        }
    }
}
