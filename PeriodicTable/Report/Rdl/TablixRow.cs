namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class TablixRow : IElement
    {
        private readonly TablixCells tablixCells;

        public TablixRow(Inch height, TablixCells tablixCells)
        {
            this.Height = height;
            this.tablixCells = tablixCells;
        }

        public Inch Height { get; private set; }
        
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
                typeof(TablixRow).GetShortName(),
                new XElement("Height", this.Height),
                this.tablixCells.Element);
        }
    }
}
