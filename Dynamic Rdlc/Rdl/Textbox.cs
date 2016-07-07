using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Textbox : ReportItem
    {
        private static int _index;
        private readonly string _name;
        private readonly Paragraphs _paragraphs = new Paragraphs();
        private readonly string _rdlName;

        public Textbox(Paragraph paragraph)
        {
            _rdlName = typeof(Textbox).GetShortName();
            _name = _rdlName + ++_index;
            AddParagraph(paragraph);
        }

        public TextboxStyle TextboxStyle { get; set; }

        public void AddParagraph(Paragraph paragraph) => _paragraphs.Add(paragraph);

        protected override XElement Build()
        {
            var result = new XElement(
                _rdlName,
                new XAttribute("Name", _name),
                new XElement("CanGrow", true),
                new XElement("KeepTogether", true),
                _paragraphs.Element);
            ConfigureTextboxStyle(result);
            ConfigureTop(result);
            ConfigureLeft(result);
            ConfigureHeight(result);
            ConfigureWidth(result);

            return result;
        }

        private void ConfigureTextboxStyle(XElement textbox)
        {
            if (TextboxStyle != null)
            {
                textbox.Add(TextboxStyle.Element);
            }
        }
    }
}