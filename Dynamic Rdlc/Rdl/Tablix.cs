using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Tablix : ReportItem
    {
        private static int index;
        private readonly string name;
        private readonly TablixCorner tablixCorner;
        private readonly TablixColumnHierarchy tablixColumnHierarchy;
        private readonly TablixRowHierarchy tablixRowHierarchy;
        private readonly TablixBody tablixBody;
        private readonly string dataSetName;
        private readonly string rdlName;

        public Tablix(
            TablixColumnHierarchy tablixColumnHierarchy,
            TablixRowHierarchy tablixRowHierarchy,
            TablixBody tablixBody,
            string dataSetName)
        {
            this.rdlName = typeof(Tablix).GetShortName();
            this.name = this.rdlName + ++index;
            this.tablixColumnHierarchy = tablixColumnHierarchy;
            this.tablixRowHierarchy = tablixRowHierarchy;
            this.tablixBody = tablixBody;
            this.dataSetName = dataSetName;
        }

        public Tablix(
            TablixCorner tablixCorner,
            TablixColumnHierarchy tablixColumnHierarchy,
            TablixRowHierarchy tablixRowHierarchy,
            TablixBody tablixBody,
            string dataSetName)
            : this(tablixColumnHierarchy, tablixRowHierarchy, tablixBody, dataSetName)
        {
            this.tablixCorner = tablixCorner;
        }

        public Style Style { get; set; }

        protected override XElement Build()
        {
            this.Height = this.tablixBody.Height + this.tablixColumnHierarchy.Height;
            this.Width = this.tablixBody.Width + this.tablixRowHierarchy.Width;
            var result = new XElement(
                this.rdlName,
                new XAttribute("Name", this.name),
                this.tablixColumnHierarchy.Element,
                this.tablixRowHierarchy.Element,
                this.tablixBody.Element,
                new XElement("DataSetName", this.dataSetName));
            this.ConfigureTablixCorner(result);
            this.ConfigureTop(result);
            this.ConfigureLeft(result);
            this.ConfigureHeight(result);
            this.ConfigureWidth(result);
            this.ConfigureStyle(result);

            return result;
        }

        private void ConfigureTablixCorner(XElement tablix)
        {
            if (this.tablixCorner != null)
            {
                tablix.Add(this.tablixCorner.Element);
            }
        }

        private void ConfigureStyle(XElement tablix)
        {
            if (this.Style != null)
            {
                tablix.Add(this.Style.Element);
            }
        }
    }
}
