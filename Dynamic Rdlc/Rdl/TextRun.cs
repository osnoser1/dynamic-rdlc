using System.Xml.Linq;
using DynamicRdlc.Utils;

namespace DynamicRdlc.Rdl
{
    public class TextRun : IElement
    {
        public string Value { get; set; }

        public string FontFamily { get; set; }

        public Point FontSize { get; set; }

        public FontWeight FontWeight { get; set; }

        public string Color { get; set; }

        public string Format { get; set; }

        public MarkupType MarkupType { get; set; }

        public XElement Element => Build();

        private XElement Build()
        {
            var result = new XElement(typeof(TextRun).GetShortName(), new XElement("Value", Value));
            ConfigureMarkupType(result);
            ConfigureStyle(result);
            return result;
        }

        private void ConfigureStyle(XElement textRun)
        {
            var style = new XElement("Style")
                .AddIfNotNull("FontFamily", FontFamily)
                .AddIfNotNull("FontSize", FontSize)
                .AddIfNotNull("Format", Format)
                .AddIfNotNull("FontWeight", FontWeight)
                .AddIfNotNull("Color", Color);

            if (style.HasElements)
            {
                textRun.Add(style);
            }
        }

        private void ConfigureMarkupType(XElement textRun)
        {
            if (MarkupType != MarkupType.None)
            {
                textRun.Add(new XElement("MarkupType", MarkupType));
            }
        }
    }
}