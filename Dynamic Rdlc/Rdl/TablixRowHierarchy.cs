namespace DynamicRdlc.Rdl
{
    public class TablixRowHierarchy : ParentOf<TablixMembers>
    {
        public TablixRowHierarchy(TablixMembers item)
            : base(item)
        {
        }

        public Inch Width => Item.Size;

        protected sealed override string GetRdlName() => typeof(TablixRowHierarchy).GetShortName();
    }
}