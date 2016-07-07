using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class BackgroundImage : IElement
    {
        private readonly BackgroundRepeat _backgroundRepeat;
        private readonly Source _source;
        private readonly string _value;

        public BackgroundImage(Source source, BackgroundRepeat backgroundRepeat, string value)
        {
            _source = source;
            _backgroundRepeat = backgroundRepeat;
            _value = value;
        }

        public XElement Element => Build();

        private XElement Build() => new XElement(
            typeof(BackgroundImage).GetShortName(),
            new XElement("Source", _source),
            new XElement("BackgroundRepeat", _backgroundRepeat),
            new XElement("Value", _value));
    }
}