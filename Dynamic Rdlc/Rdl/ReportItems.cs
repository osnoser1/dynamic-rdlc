namespace DynamicRdlc.Rdl
{
    public class ReportItems : CollectionOf<ReportItem>, IElement
    {
        protected sealed override string GetRdlName() => typeof(ReportItems).GetShortName();
    }
}