namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class Page : IElement
    {
        public Inch LeftMargin { get; set; }

        public Inch RightMargin { get; set; }

        public Inch TopMargin { get; set; }

        public Inch BottomMargin { get; set; }

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        private XElement Build()
        {
            return new XElement(
                typeof(Page).GetShortName(),
                new XElement("LeftMargin", this.LeftMargin),
                new XElement("RightMargin", this.RightMargin),
                new XElement("TopMargin", this.TopMargin),
                new XElement("BottomMargin", this.BottomMargin));
        }
    }
}
