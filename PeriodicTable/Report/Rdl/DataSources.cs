namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class DataSources : IElement
    {
        public const string DataSourceName = "Elements";

        public XElement Element
        {
            get
            {
                return Build();
            }
        }

        private static XElement Build()
        {
            return new XElement(
                typeof(DataSources).GetShortName(),
                new XElement(
                    "DataSource",
                    new XAttribute("Name", DataSourceName),
                    new XElement(
                        "ConnectionProperties",
                        new XElement("DataProvider", "ListOfT"),
                        new XElement("ConnectString"))));
        }
    }
}
