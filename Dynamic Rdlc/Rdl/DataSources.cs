using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class DataSources : IElement
    {
        public const string DataSourceName = "Elements";

        public XElement Element => Build();

        private static XElement Build() => new XElement(
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