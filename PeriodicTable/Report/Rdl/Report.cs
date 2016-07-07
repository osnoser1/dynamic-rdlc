namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class Report
    {
        private readonly DataSources datasources = new DataSources();
        private readonly DataSets dataSets = new DataSets();
        private readonly ReportSections reportSections = new ReportSections();
        private readonly EmbeddedImages embeddedImages = new EmbeddedImages();

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        public void AddDataSet(DataSet dataSet)
        {
            this.dataSets.Add(dataSet);
        }

        public void AddReportSection(ReportSection reportSection)
        {
            this.reportSections.Add(reportSection);
        }

        public void AddEmbeddedImage(EmbeddedImage embeddedImage)
        {
            this.embeddedImages.Add(embeddedImage);
        }

        private static void AddNamespace(XElement report)
        {
            XNamespace ns = "http://schemas.microsoft.com/sqlserver/reporting/2010/01/reportdefinition";
            foreach (var e in report.DescendantsAndSelf())
            {
                if (e.Name != null && e.Name.NamespaceName == string.Empty)
                {
                    e.Name = ns + e.Name.LocalName;
                }
            }
        }

        private XElement Build()
        {
            var result = new XElement(
                typeof(Report).GetShortName(),
                this.datasources.Element,
                this.dataSets.Element,
                this.reportSections.Element,
                this.embeddedImages.Element);
            AddNamespace(result);
            return result;
        }
    }
}
