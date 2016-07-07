namespace PeriodicTable.Report.Rdl
{
    public class TopBorder : Border
    {
        protected override string BorderName
        {
            get
            {
                return "Top" + base.BorderName;
            }
        }
    }
}
