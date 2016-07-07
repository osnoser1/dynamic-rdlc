using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public abstract class ReportItemsContainer : ReportItem
    {
        protected readonly ReportItems ReportItems = new ReportItems();

        private ReportItem _lastReportItem;

        public void AddReportItem(ReportItem reportItem)
        {
            ReportItems.Add(reportItem);
            _lastReportItem = reportItem;
        }

        protected void ConfigureContainerHeight(XElement reportItemsContainer)
        {
            var height = _lastReportItem == null ? new Inch(0) : _lastReportItem.NextTop;
            reportItemsContainer.Add(new XElement("Height", height));
        }
    }
}