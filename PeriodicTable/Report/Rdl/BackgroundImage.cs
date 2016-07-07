namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public class BackgroundImage : IElement
    {
        private readonly Source source;
        private readonly BackgroundRepeat backgroundRepeat;
        private readonly string value;

        public BackgroundImage(Source source, BackgroundRepeat backgroundRepeat, string value)
        {
            this.source = source;
            this.backgroundRepeat = backgroundRepeat;
            this.value = value;
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
            return new XElement(
                typeof(BackgroundImage).GetShortName(),
                new XElement("Source", this.source),
                new XElement("BackgroundRepeat", this.backgroundRepeat),
                new XElement("Value", this.value));
        }
    }
}
