using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class ReportSection : IElement
    {
        private readonly Body _body = new Body();

        private readonly Page _page = new Page
        {
            LeftMargin = new Inch(1),
            RightMargin = new Inch(1),
            TopMargin = new Inch(1),
            BottomMargin = new Inch(1)
        };

        private readonly Inch _width = new Inch(6.5);

        public ReportSection()
        {
        }

        public ReportSection(Body body)
        {
            _body = body;
        }

        public ReportSection(Body body, Page page)
        {
            _body = body;
            _page = page;
        }

        public XElement Element => Build();

        private XElement Build() => new XElement(
            typeof(ReportSection).GetShortName(),
            _body.Element,
            _page.Element,
            new XElement("Width", _width));
    }
}