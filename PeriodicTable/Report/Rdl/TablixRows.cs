namespace PeriodicTable.Report.Rdl
{
    using System.Linq;

    public class TablixRows : CollectionOf<TablixRow>, IElement
    {
        public TablixRows()
        {
        }

        public TablixRows(TablixRow tablixRow)
        {
            this.Add(tablixRow);
        }

        public Inch Height
        {
            get
            {
                var result = new Inch(0);
                return this.Collection.Aggregate(result, (current, tablixRow) => current + tablixRow.Height);
            }
        }

        protected sealed override string GetRdlName()
        {
            return typeof(TablixRows).GetShortName();
        }
    }
}
