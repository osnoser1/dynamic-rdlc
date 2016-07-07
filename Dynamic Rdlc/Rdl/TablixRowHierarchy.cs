namespace DynamicRdlc.Rdl
{
    public class TablixRowHierarchy : ParentOf<TablixMembers>
    {
        public TablixRowHierarchy(TablixMembers item)
            : base(item)
        {
        }

        public Inch Width
        {
            get
            {
                return this.Item.Size;
            }
        }

        protected sealed override string GetRdlName()
        {
            return typeof(TablixRowHierarchy).GetShortName();
        }
    }
}
