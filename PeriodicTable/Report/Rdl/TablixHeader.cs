namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class TablixHeader : IElement
    {
        private readonly CellContents cellContents;

        public TablixHeader(Inch size, CellContents cellContents)
        {
            this.Size = size;
            this.cellContents = cellContents;
        }

        public Inch Size { get; private set; }

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
                typeof(TablixHeader).GetShortName(),
                new XElement("Size", this.Size),
                this.cellContents.Element);
        }
    }
}
