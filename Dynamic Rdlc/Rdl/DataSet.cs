using System.Collections.Generic;
using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class DataSet : IElement
    {
        private static int _index;

        private readonly List<string> _fields;
        private readonly string _rdlName;

        public DataSet()
        {
            _rdlName = typeof(DataSet).GetShortName();
            Name = _rdlName + ++_index;
            _fields = new List<string>();
        }

        public DataSet(string name)
        {
            Name = name;
            _rdlName = typeof(DataSet).GetShortName();
            _fields = new List<string>();
        }

        public string Name { get; }

        public XElement Element => Build();

        public void AddField(string field) => _fields.Add(field);

        private XElement Build()
        {
            var f = new XElement("Fields");
            var dataSet = new XElement(
                _rdlName,
                new XAttribute("Name", Name),
                new XElement(
                    "Query",
                    new XElement("DataSourceName", DataSources.DataSourceName),
                    new XElement("CommandText")),
                f);
            foreach (var field in _fields)
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