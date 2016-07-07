namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class TextRun : IElement
    {
        public string Value { get; set; }

        public string FontFamily { get; set; }

        public Point FontSize { get; set; }

        public FontWeight FontWeight { get; set; }

        public string Color { get; set; }

        public MarkupType MarkupType { get; set; }

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        private XElement Build()
        {
            var result = new XElement(typeof(TextRun).GetShortName(), new XElement("Value", this.Value));
            this.ConfigureMarkupType(result);
            this.ConfigureStyle(result);
            return result;
        }

        private void ConfigureStyle(XElement textRun)
        {
            var style = new XElement("Style");

            if (this.FontFamily != null)
            {
                style.Add(new XElement("FontFamily", this.FontFamily));
            }

            if (this.FontSize != null)
            {
                style.Add(new XElement("FontSize", this.FontSize));
            }

            if (this.FontWeight != FontWeight.Default)
            {
                style.Add(new XElement("FontWeight", this.FontWeight));
            }

            if (this.Color != null)
            {
                style.Add(new XElement("Color", this.Color));
            }

            if (style.HasElements)
            {
                textRun.Add(style);
            }
        }

        private void ConfigureMarkupType(XElement textRun)
        {
            if (this.MarkupType != MarkupType.None)
            {
                textRun.Add(new XElement("MarkupType", this.MarkupType));
            }
        }
    }
}
