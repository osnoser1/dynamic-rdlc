namespace DynamicRdlc.Rdl
{
    public class TablixColumn : ParentOf<Width>
    {
        public TablixColumn(Width item)
            : base(item)
        {
        }

        public Inch Width => Item.Value;

        protected sealed override string GetRdlName() => typeof(TablixColumn).GetShortName();
    }
}