using System.Collections.Generic;
using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public abstract class CollectionOf<T> where T : IElement
    {
        protected CollectionOf()
        {
            Collection = new List<T>();
        }

        protected CollectionOf(T item)
            : this()
        {
            Add(item);
        }

        public XElement Element => Build();

        protected List<T> Collection { get; }

        public void Add(T item) => Collection.Add(item);

        protected abstract string GetRdlName();

        protected virtual XElement Build()
        {
            var result = new XElement(GetRdlName());
            foreach (var item in Collection)
            {
                result.Add(item.Element);
            }

            return result.HasElements ? result : null;
        }
    }
}