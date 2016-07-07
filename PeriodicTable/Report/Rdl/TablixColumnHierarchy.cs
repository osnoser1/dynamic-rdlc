namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class TablixColumnHierarchy
    {
        private readonly TablixMembers tablixMembers;

        public TablixColumnHierarchy(TablixMembers tablixMembers)
        {
            this.tablixMembers = tablixMembers;
        }

        public Inch Height
        {
            get
            {
                return this.tablixMembers.Size;
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
            return new XElement(typeof(TablixColumnHierarchy).GetShortName(), this.tablixMembers.Element);
        }
    }
}
