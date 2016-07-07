using System;
using System.Drawing;
using System.IO;
using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class EmbeddedImage : IElement
    {
        private const double Dpi = 96;

        private readonly Image _image;
        private readonly string _imageName;

        public EmbeddedImage(Image image, string imageName)
        {
            _image = image;
            Width = new Inch(image.Size.Width/Dpi);
            Height = new Inch(image.Size.Height/Dpi);
            _imageName = imageName;
        }

        public Inch Width { get; private set; }

        public Inch Height { get; private set; }

        public XElement Element => Build();

        private XElement Build() => new XElement(
            typeof(EmbeddedImage).GetShortName(),
            new XAttribute("Name", _imageName),
            new XElement("MIMEType", "image/png"),
            new XElement("ImageData", ConvertToBase64String()));

        private string ConvertToBase64String()
        {
            using (var ms = new MemoryStream())
            {
                _image.Save(ms, _image.RawFormat);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }
}