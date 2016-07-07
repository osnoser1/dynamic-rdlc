namespace PeriodicTable.Report.Rdl
{
    public class ReportSections : CollectionOf<ReportSection>, IElement
    {
        protected sealed override string GetRdlName()
        {
            return typeof(ReportSections).GetShortName();
        }
    }
}
