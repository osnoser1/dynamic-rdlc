namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public abstract class ReportItemsContainer : ReportItem
    {
        protected readonly ReportItems ReportItems = new ReportItems();

        private ReportItem lastReportItem;

        public void AddReportItem(ReportItem reportItem)
        {
            this.ReportItems.Add(reportItem);
            this.lastReportItem = reportItem;
        }

        protected void ConfigureContainerHeight(XElement reportItemsContainer)
        {
            var height = this.lastReportItem == null ? new Inch(0) : this.lastReportItem.NextTop;
            reportItemsContainer.Add(new XElement("Height", height));
        }
    }
}
