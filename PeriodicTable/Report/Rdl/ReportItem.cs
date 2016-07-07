namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public abstract class ReportItem : IElement
    {
        private Inch top = new Inch(0);

        public Inch Top
        {
            get
            {
                return this.top;
            }

            set
            {
                this.top = value;
            }
        }

        public Inch Left { get; set; }

        public Inch Height { get; set; }

        public Inch Width { get; set; }

        public Inch NextTop
        {
            get
            {
                return this.Top + this.Height;
            }
        }

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        protected abstract XElement Build();

        protected void ConfigureTop(XElement item)
        {
            if (this.Top.ToString() != new Inch(0).ToString())
            {
                item.Add(new XElement("Top", this.Top));
            }
        }

        protected void ConfigureLeft(XElement item)
        {
            if (this.Left != null)
            {
                item.Add(new XElement("Left", this.Left));
            }
        }

        protected void ConfigureHeight(XElement item)
        {
            if (this.Height != null)
            {
                item.Add(new XElement("Height", this.Height));
            }
        }

        protected void ConfigureWidth(XElement item)
        {
            if (this.Width != null)
            {
                item.Add(new XElement("Width", this.Width));
            }
        }
    }
}
