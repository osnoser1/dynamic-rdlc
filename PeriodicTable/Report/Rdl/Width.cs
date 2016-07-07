namespace PeriodicTable.Report.Rdl
{
    public class Width : ParentOf<Inch>
    {
        public Width(Inch item)
            : base(item)
        {
        }

        public Inch Value
        {
            get
            {
                return this.Item;
            }
        }

        protected sealed override string GetRdlName()
        {
            return typeof(Width).GetShortName();
        }
    }
}
