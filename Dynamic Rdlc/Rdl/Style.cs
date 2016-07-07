using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public class Style : IElement
    {
        public Border Border { get; set; }

        public LeftBorder LeftBorder { get; set; }

        public RightBorder RightBorder { get; set; }

        public TopBorder TopBorder { get; set; }

        public BottomBorder BottomBorder { get; set; }

        public string BackgroundColor { get; set; }

        public BackgroundImage BackgroundImage { get; set; }

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        protected virtual XElement Build()
        {
            var result = new XElement(typeof(Style).GetShortName());
            this.ConfigureBorder(result);
            this.ConfigureTopBorder(result);
            this.ConfigureBottomBorder(result);
            this.ConfigureLeftBorder(result);
            this.ConfigureRightBorder(result);
            this.ConfigureBackgroundColor(result);
            this.ConfigureBackgroundImage(result);
            return result;
        }

        private void ConfigureBorder(XElement style)
        {
            if (this.Border != null)
            {
                style.Add(this.Border.Element);
            }
        }

        private void ConfigureTopBorder(XElement style)
        {
            if (this.TopBorder != null)
            {
                style.Add(this.TopBorder.Element);
            }
        }

        private void ConfigureBottomBorder(XElement style)
        {
            if (this.BottomBorder != null)
            {
                style.Add(this.BottomBorder.Element);
            }
        }

        private void ConfigureLeftBorder(XElement style)
        {
            if (this.LeftBorder != null)
            {
                style.Add(this.LeftBorder.Element);
            }
        }

        private void ConfigureRightBorder(XElement style)
        {
            if (this.RightBorder != null)
            {
                style.Add(this.RightBorder.Element);
            }
        }

        private void ConfigureBackgroundColor(XElement style)
        {
            if (this.BackgroundColor != null)
            {
                style.Add(new XElement("BackgroundColor", this.BackgroundColor));
            }
        }

        private void ConfigureBackgroundImage(XElement style)
        {
            if (this.BackgroundImage != null)
            {
                style.Add(this.BackgroundImage.Element);
            }
        }
    }
}
