using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Group : IElement
    {
        private static int _index;
        private readonly GroupExpressions _groupExpressions;
        private readonly string _name;
        private readonly string _rdlName;

        public Group(GroupExpressions groupExpressions)
        {
            _rdlName = typeof(Group).GetShortName();
            _name = _rdlName + ++_index;
            _groupExpressions = groupExpressions;
        }

        public XElement Element => Build();

        private XElement Build()
            =>
                _groupExpressions != null
                    ? new XElement(_rdlName, new XAttribute("Name", _name), _groupExpressions.Element)
                    : new XElement(_rdlName, new XAttribute("Name", _name));
    }
}