using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Report
    {
        private readonly DataSets _dataSets = new DataSets();
        private readonly DataSources _datasources = new DataSources();
        private readonly EmbeddedImages _embeddedImages = new EmbeddedImages();
        private readonly ReportSections _reportSections = new ReportSections();

        public XElement Element => Build();

        public void AddDataSet(DataSet dataSet) => _dataSets.Add(dataSet);

        public void AddReportSection(ReportSection reportSection) => _reportSections.Add(reportSection);

        public void AddEmbeddedImage(EmbeddedImage embeddedImage) => _embeddedImages.Add(embeddedImage);

        private static void AddNamespace(XElement report)
        {
            XNamespace ns = "http://schemas.microsoft.com/sqlserver/reporting/2010/01/reportdefinition";
            foreach (var e in report.DescendantsAndSelf())
            {
                if (e.Name.NamespaceName == string.Empty)
                {
                    e.Name = ns + e.Name.LocalName;
                }
            }
        }

        private XElement Build()
        {
            var result = new XElement(
                typeof(Report).GetShortName(),
                _datasources.Element,
                _dataSets.Element,
                _reportSections.Element,
                _embeddedImages.Element);
            AddNamespace(result);
            return result;
        }
    }
}