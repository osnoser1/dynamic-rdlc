using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Tablix : ReportItem
    {
        private static int _index;
        private readonly string _dataSetName;
        private readonly string _name;
        private readonly string _rdlName;
        private readonly TablixBody _tablixBody;
        private readonly TablixColumnHierarchy _tablixColumnHierarchy;
        private readonly TablixCorner _tablixCorner;
        private readonly TablixRowHierarchy _tablixRowHierarchy;

        public Tablix(
            TablixColumnHierarchy tablixColumnHierarchy,
            TablixRowHierarchy tablixRowHierarchy,
            TablixBody tablixBody,
            string dataSetName)
        {
            _rdlName = typeof(Tablix).GetShortName();
            _name = _rdlName + ++_index;
            _tablixColumnHierarchy = tablixColumnHierarchy;
            _tablixRowHierarchy = tablixRowHierarchy;
            _tablixBody = tablixBody;
            _dataSetName = dataSetName;
        }

        public Tablix(
            TablixCorner tablixCorner,
            TablixColumnHierarchy tablixColumnHierarchy,
            TablixRowHierarchy tablixRowHierarchy,
            TablixBody tablixBody,
            string dataSetName)
            : this(tablixColumnHierarchy, tablixRowHierarchy, tablixBody, dataSetName)
        {
            _tablixCorner = tablixCorner;
        }

        public Style Style { get; set; }

        protected override XElement Build()
        {
            Height = _tablixBody.Height + _tablixColumnHierarchy.Height;
            Width = _tablixBody.Width + _tablixRowHierarchy.Width;
            var result = new XElement(
                _rdlName,
                new XAttribute("Name", _name),
                _tablixColumnHierarchy.Element,
                _tablixRowHierarchy.Element,
                _tablixBody.Element,
                new XElement("DataSetName", _dataSetName));
            ConfigureTablixCorner(result);
            ConfigureTop(result);
            ConfigureLeft(result);
            ConfigureHeight(result);
            ConfigureWidth(result);
            ConfigureStyle(result);

            return result;
        }

        private void ConfigureTablixCorner(XElement tablix)
        {
            if (_tablixCorner != null)
            {
                tablix.Add(_tablixCorner.Element);
            }
        }

        private void ConfigureStyle(XElement tablix)
        {
            if (Style != null)
            {
                tablix.Add(Style.Element);
            }
        }
    }
}