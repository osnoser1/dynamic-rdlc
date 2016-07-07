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

        public XElement Element => Build();

        protected virtual XElement Build()
        {
            var result = new XElement(typeof(Style).GetShortName());
            ConfigureBorder(result);
            ConfigureTopBorder(result);
            ConfigureBottomBorder(result);
            ConfigureLeftBorder(result);
            ConfigureRightBorder(result);
            ConfigureBackgroundColor(result);
            ConfigureBackgroundImage(result);
            return result;
        }

        private void ConfigureBorder(XElement style)
        {
            if (Border != null)
            {
                style.Add(Border.Element);
            }
        }

        private void ConfigureTopBorder(XElement style)
        {
            if (TopBorder != null)
            {
                style.Add(TopBorder.Element);
            }
        }

        private void ConfigureBottomBorder(XElement style)
        {
            if (BottomBorder != null)
            {
                style.Add(BottomBorder.Element);
            }
        }

        private void ConfigureLeftBorder(XElement style)
        {
            if (LeftBorder != null)
            {
                style.Add(LeftBorder.Element);
            }
        }

        private void ConfigureRightBorder(XElement style)
        {
            if (RightBorder != null)
            {
                style.Add(RightBorder.Element);
            }
        }

        private void ConfigureBackgroundColor(XElement style)
        {
            if (BackgroundColor != null)
            {
                style.Add(new XElement("BackgroundColor", BackgroundColor));
            }
        }

        private void ConfigureBackgroundImage(XElement style)
        {
            if (BackgroundImage != null)
            {
                style.Add(BackgroundImage.Element);
            }
        }
    }
}