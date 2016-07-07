namespace DynamicRdlc.Rdl
{
    public class ReportSections : CollectionOf<ReportSection>, IElement
    {
        protected sealed override string GetRdlName() => typeof(ReportSections).GetShortName();
    }
}