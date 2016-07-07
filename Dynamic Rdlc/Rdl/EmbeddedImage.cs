using System;
using System.IO;
using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class EmbeddedImage : IElement
    {
        private const double Dpi = 96;

        private readonly System.Drawing.Image image;
        private readonly string imageName;

        public EmbeddedImage(System.Drawing.Image image, string imageName)
        {
            this.image = image;
            this.Width = new Inch(image.Size.Width / Dpi);
            this.Height = new Inch(image.Size.Height / Dpi);
            this.imageName = imageName;
        }

        public Inch Width { get; private set; }

        public Inch Height { get; private set; }

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
                typeof(EmbeddedImage).GetShortName(),
                new XAttribute("Name", this.imageName),
                new XElement("MIMEType", "image/png"),
                new XElement("ImageData", this.ConvertToBase64String()));
        }

        private string ConvertToBase64String()
        {
            using (var ms = new MemoryStream())
            {
                this.image.Save(ms, this.image.RawFormat);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }
}
