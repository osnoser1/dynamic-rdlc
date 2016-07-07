using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class TablixRow : IElement
    {
        private readonly TablixCells _tablixCells;

        public TablixRow(Inch height, TablixCells tablixCells)
        {
            Height = height;
            _tablixCells = tablixCells;
        }

        public Inch Height { get; }

        public XElement Element => Build();

        private XElement Build() => new XElement(
            typeof(TablixRow).GetShortName(),
            new XElement("Height", Height),
            _tablixCells.Element);
    }
}