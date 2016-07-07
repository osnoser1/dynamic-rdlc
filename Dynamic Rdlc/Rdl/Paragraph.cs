using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Paragraph : ParentOf<TextRuns>
    {
        public Paragraph(TextRuns item)
            : base(item)
        {
        }

        public TextAlign TextAlign { get; set; }

        protected sealed override string GetRdlName() => typeof(Paragraph).GetShortName();

        protected override XElement Build()
        {
            var result = base.Build();
            result.Add(BuildStyle());
            return result;
        }

        private XElement BuildStyle()
        {
            var result = new XElement("Style");

            if (TextAlign != TextAlign.Default)
            {
                result.Add(new XElement("TextAlign", TextAlign));
            }

            return result.HasElements ? result : null;
        }
    }
}