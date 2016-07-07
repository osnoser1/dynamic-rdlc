using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class TablixBody
    {
        private readonly TablixColumns tablixColumns;
        private readonly TablixRows tablixRows;

        public TablixBody(TablixColumns tablixColumns, TablixRows tablixRows)
        {
            this.tablixColumns = tablixColumns;
            this.tablixRows = tablixRows;
        }

        public Inch Height
        {
            get
            {
                return this.tablixRows.Height;
            }
        }

        public Inch Width
        {
            get
            {
                return this.tablixColumns.Width;
            }
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
            return new XElement(typeof(TablixBody).GetShortName(), this.tablixColumns.Element, this.tablixRows.Element);
        }
    }
}
