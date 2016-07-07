using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Group : IElement
    {
        private static int index;
        private readonly string name;
        private readonly GroupExpressions groupExpressions;
        private readonly string rdlName;

        public Group(GroupExpressions groupExpressions)
        {
            this.rdlName = typeof(Group).GetShortName();
            this.name = this.rdlName + ++index;
            this.groupExpressions = groupExpressions;
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
            return new XElement(this.rdlName, new XAttribute("Name", this.name), this.groupExpressions.Element);
        }
    }
}
