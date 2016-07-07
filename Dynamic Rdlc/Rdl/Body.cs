using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Body : ReportItemsContainer
    {
        protected override XElement Build()
        {
            var result = new XElement(typeof(Body).GetShortName(), ReportItems.Element);
            ConfigureContainerHeight(result);
            return result;
        }
    }
}