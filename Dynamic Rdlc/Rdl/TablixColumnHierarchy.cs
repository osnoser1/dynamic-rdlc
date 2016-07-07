using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class TablixColumnHierarchy
    {
        private readonly TablixMembers _tablixMembers;

        public TablixColumnHierarchy(TablixMembers tablixMembers)
        {
            _tablixMembers = tablixMembers;
        }

        public Inch Height => _tablixMembers.Size;

        public XElement Element => Build();

        private XElement Build() => new XElement(typeof(TablixColumnHierarchy).GetShortName(), _tablixMembers.Element);
    }
}