using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Page : IElement
    {
        public Inch LeftMargin { get; set; }

        public Inch RightMargin { get; set; }

        public Inch TopMargin { get; set; }

        public Inch BottomMargin { get; set; }

        public XElement Element => Build();

        private XElement Build() => new XElement(
            typeof(Page).GetShortName(),
            new XElement("LeftMargin", LeftMargin),
            new XElement("RightMargin", RightMargin),
            new XElement("TopMargin", TopMargin),
            new XElement("BottomMargin", BottomMargin));
    }
}