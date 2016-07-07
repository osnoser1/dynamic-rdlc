using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Rectangle : ReportItemsContainer
    {
        private static int index;
        private readonly string name;
        private readonly string rdlName;

        public Rectangle()
        {
            this.rdlName = typeof(Rectangle).GetShortName();
            this.name = this.rdlName + ++index;
        }

        protected override XElement Build()
        {
            var result = new XElement(
                this.rdlName,
                new XAttribute("Name", this.name),
                new XElement("KeepTogether", true),
                this.ReportItems.Element);
            this.ConfigureTop(result);
            this.ConfigureLeft(result);
            this.ConfigureWidth(result);
            this.ConfigureContainerHeight(result);

            return result;
        }
    }
}
