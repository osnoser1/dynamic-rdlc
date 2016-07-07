namespace PeriodicTable.Report.Rdl
{
    public class RightBorder : Border
    {
        protected override string BorderName
        {
            get
            {
                return "Right" + base.BorderName;
            }
        }
    }
}
