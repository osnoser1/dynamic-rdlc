using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Rectangle : ReportItemsContainer
    {
        private static int _index;
        private readonly string _name;
        private readonly string _rdlName;

        public Rectangle()
        {
            _rdlName = typeof(Rectangle).GetShortName();
            _name = _rdlName + ++_index;
        }

        protected override XElement Build()
        {
            var result = new XElement(
                _rdlName,
                new XAttribute("Name", _name),
                new XElement("KeepTogether", true),
                ReportItems.Element);
            ConfigureTop(result);
            ConfigureLeft(result);
            ConfigureWidth(result);
            ConfigureContainerHeight(result);

            return result;
        }
    }
}