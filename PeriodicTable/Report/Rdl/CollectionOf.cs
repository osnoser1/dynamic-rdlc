namespace PeriodicTable.Report.Rdl
{
    using System.Collections.Generic;
    using System.Xml.Linq;

    public abstract class CollectionOf<T> where T : IElement
    {
        protected CollectionOf()
        {
            this.Collection = new List<T>();
        }

        protected CollectionOf(T item)
            : this()
        {
            this.Add(item);
        }

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        protected List<T> Collection { get; private set; }

        public void Add(T item)
        {
            this.Collection.Add(item);
        }

        protected abstract string GetRdlName();

        protected virtual XElement Build()
        {
            var result = new XElement(this.GetRdlName());
            foreach (var item in this.Collection)
            {
                result.Add(item.Element);
            }

            return result.HasElements ? result : null;
        }
    }
}
