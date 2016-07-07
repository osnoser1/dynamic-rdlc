using System.Linq;

namespace DynamicRdlc.Rdl
{
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
                return Collection.Aggregate(result, (current, tablixColum) => current + tablixColum.Width);
            }
        }

        protected sealed override string GetRdlName() => typeof(TablixColumns).GetShortName();
    }
}