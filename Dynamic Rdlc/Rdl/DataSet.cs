using System.Collections.Generic;
using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class DataSet : IElement
    {
        private static int index;

        private readonly List<string> fields;
        private readonly string rdlName;

        public DataSet()
        {
            this.rdlName = typeof(DataSet).GetShortName();
            this.Name = this.rdlName + ++index;
            this.fields = new List<string>();
        }

        public string Name { get; private set; }

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        public void AddField(string field)
        {
            this.fields.Add(field);
        }

        private XElement Build()
        {
            var f = new XElement("Fields");
            var dataSet = new XElement(
                this.rdlName,
                new XAttribute("Name", this.Name),
                new XElement(
                    "Query",
                    new XElement("DataSourceName", DataSources.DataSourceName),
                    new XElement("CommandText")),
                f);
            foreach (var field in this.fields)
            {
                f.Add(new XElement(
                    "Field",
                    new XAttribute("Name", field),
                    new XElement("DataField", field)));
            }

            return dataSet;
        }
    }
}
