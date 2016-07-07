namespace DynamicRdlc.Rdl
{
    public class Width : ParentOf<Inch>
    {
        public Width(Inch item)
            : base(item)
        {
        }

        public Inch Value => Item;

        protected sealed override string GetRdlName() => typeof(Width).GetShortName();
    }
}