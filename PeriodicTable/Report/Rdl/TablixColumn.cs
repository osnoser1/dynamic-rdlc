namespace PeriodicTable.Report.Rdl
{
    public class TablixColumn : ParentOf<Width>
    {
        public TablixColumn(Width item)
            : base(item)
        {
        }

        public Inch Width
        {
            get
            {
                return this.Item.Value;
            }
        }

        protected sealed override string GetRdlName()
        {
            return typeof(TablixColumn).GetShortName();
        }
    }
}
