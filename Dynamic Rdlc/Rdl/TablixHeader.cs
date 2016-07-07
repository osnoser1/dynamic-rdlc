using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class TablixHeader : IElement
    {
        private readonly CellContents _cellContents;

        public TablixHeader(Inch size, CellContents cellContents)
        {
            Size = size;
            _cellContents = cellContents;
        }

        public Inch Size { get; }

        public XElement Element => Build();

        private XElement Build() => new XElement(
            typeof(TablixHeader).GetShortName(),
            new XElement("Size", Size),
            _cellContents.Element);
    }
}