namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class TablixMember : IElement
    {
        private readonly Group group;
        private readonly SortExpressions sortExpressions;
        private readonly TablixHeader tablixHeader;

        public TablixMember()
        {
        }

        public TablixMember(Group group, SortExpressions sortExpressions, TablixHeader tablixHeader)
        {
            this.group = group;
            this.sortExpressions = sortExpressions;
            this.tablixHeader = tablixHeader;
        }

        public Inch Size
        {
            get
            {
                return this.tablixHeader == null ? new Inch(0) : this.tablixHeader.Size;
            }
        }
        
        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        private XElement Build()
        {
            var result = new XElement(typeof(TablixMember).GetShortName());
            this.ConfigureGroup(result);
            this.ConfigureSortExpressions(result);
            this.ConfigureTablixHeader(result);
            return result;
        }

        private void ConfigureGroup(XElement tablixMember)
        {
            if (this.group != null)
            {
                tablixMember.Add(this.group.Element);
            }
        }

        private void ConfigureSortExpressions(XElement tablixMember)
        {
            if (this.sortExpressions != null)
            {
                tablixMember.Add(this.sortExpressions.Element);
            }
        }

        private void ConfigureTablixHeader(XElement tablixMember)
        {
            if (this.tablixHeader != null)
            {
                tablixMember.Add(this.tablixHeader.Element);
            }
        }
    }
}
