namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class Body : ReportItemsContainer
    {
        protected override XElement Build()
        {
            var result = new XElement(typeof(Body).GetShortName(), this.ReportItems.Element);
            this.ConfigureContainerHeight(result);
            return result;
        }
    }
}
