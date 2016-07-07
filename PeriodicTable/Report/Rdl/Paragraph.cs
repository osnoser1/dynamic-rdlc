namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class Paragraph : ParentOf<TextRuns>
    {
        public Paragraph(TextRuns item)
            : base(item)
        {
        }

        public TextAlign TextAlign { get; set; }

        protected sealed override string GetRdlName()
        {
            return typeof(Paragraph).GetShortName();
        }

        protected override XElement Build()
        {
            var result = base.Build();
            result.Add(this.BuildStyle());
            return result;
        }

        private XElement BuildStyle()
        {
            var result = new XElement("Style");

            if (this.TextAlign != TextAlign.Default)
            {
                result.Add(new XElement("TextAlign", this.TextAlign));
            }

            return result.HasElements ? result : null;
        }
    }
}
