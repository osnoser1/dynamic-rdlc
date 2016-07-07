using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class TablixBody
    {
        private readonly TablixColumns _tablixColumns;
        private readonly TablixRows _tablixRows;

        public TablixBody(TablixColumns tablixColumns, TablixRows tablixRows)
        {
            _tablixColumns = tablixColumns;
            _tablixRows = tablixRows;
        }

        public Inch Height => _tablixRows.Height;

        public Inch Width => _tablixColumns.Width;

        public XElement Element => Build();

        private XElement Build()
            => new XElement(typeof(TablixBody).GetShortName(), _tablixColumns.Element, _tablixRows.Element);
    }
}