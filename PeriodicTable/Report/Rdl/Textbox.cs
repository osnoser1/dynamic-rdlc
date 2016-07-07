namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class Textbox : ReportItem
    {
        private static int index;
        private readonly string name;
        private readonly Paragraphs paragraphs = new Paragraphs();
        private readonly string rdlName;

        public Textbox(Paragraph paragraph)
        {
            this.rdlName = typeof(Textbox).GetShortName();
            this.name = this.rdlName + ++index;
            this.AddParagraph(paragraph);
        }

        public TextboxStyle TextboxStyle { get; set; }

        public void AddParagraph(Paragraph paragraph)
        {
            this.paragraphs.Add(paragraph);
        }

        protected override XElement Build()
        {
            var result = new XElement(
                this.rdlName,
                new XAttribute("Name", this.name),
                new XElement("CanGrow", true),
                new XElement("KeepTogether", true),
                this.paragraphs.Element);
            this.ConfigureTextboxStyle(result);
            this.ConfigureTop(result);
            this.ConfigureLeft(result);
            this.ConfigureHeight(result);
            this.ConfigureWidth(result);

            return result;
        }

        private void ConfigureTextboxStyle(XElement textbox)
        {
            if (this.TextboxStyle != null)
            {
                textbox.Add(this.TextboxStyle.Element);
            }
        }
    }
}
