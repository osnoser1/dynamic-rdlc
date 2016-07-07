namespace PeriodicTable.Report.Rdl
{
    using System.Linq;

    public class TablixColumns : CollectionOf<TablixColumn>, IElement
    {
        public TablixColumns(TablixColumn tablixColumn)
            : base(tablixColumn)
        {
        }

        public Inch Width
        {
            get
            {
                var result = new Inch(0);
                return this.Collection.Aggregate(result, (current, tablixColum) => current + tablixColum.Width);
            }
        }

        protected sealed override string GetRdlName()
        {
            return typeof(TablixColumns).GetShortName();
        }
    }
}
