namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class ReportSection : IElement
    {
        private readonly Body body = new Body();
        private readonly Inch width = new Inch(6.5);
        private readonly Page page = new Page
                                         {
                                             LeftMargin = new Inch(1),
                                             RightMargin = new Inch(1),
                                             TopMargin = new Inch(1),
                                             BottomMargin = new Inch(1)
                                         };

        public ReportSection()
        {            
        }

        public ReportSection(Body body)
        {
            this.body = body;
        }


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
                typeof(ReportSection).GetShortName(),
                this.body.Element,
                this.page.Element,
                new XElement("Width", this.width));
        }
    }
}
