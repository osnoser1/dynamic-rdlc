using System.Linq;

namespace DynamicRdlc.Rdl
{
    public class TablixRows : CollectionOf<TablixRow>, IElement
    {
        public TablixRows()
        {
        }

        public TablixRows(TablixRow tablixRow)
        {
            Add(tablixRow);
        }

        public Inch Height
        {
            get
            {
                var result = new Inch(0);
                return Collection.Aggregate(result, (current, tablixRow) => current + tablixRow.Height);
            }
        }

        protected sealed override string GetRdlName() => typeof(TablixRows).GetShortName();
    }
}