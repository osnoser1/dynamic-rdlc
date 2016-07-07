using System.Linq;

namespace DynamicRdlc.Rdl
{
    public class TablixMembers : CollectionOf<TablixMember>, IElement
    {
        public TablixMembers()
        {
        }

        public TablixMembers(TablixMember tablixMember)
            : base(tablixMember)
        {
        }

        public Inch Size
        {
            get
            {
                var result = new Inch(0);
                return Collection.Aggregate(result, (current, tablixMember) => current + tablixMember.Size);
            }
        }

        protected sealed override string GetRdlName() => typeof(TablixMembers).GetShortName();
    }
}