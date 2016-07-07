using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public abstract class ParentOf<T> : IElement
    {
        protected ParentOf(T item)
        {
            Item = item;
        }

        protected T Item { get; }

        public XElement Element => Build();

        protected abstract string GetRdlName();

        protected virtual XElement Build()
        {
            var result = new XElement(GetRdlName());
            var value = Item as IElement;
            if (value != null)
            {
                result.Add(value.Element);
            }
            else
            {
                result.Add(Item);
            }

            return result;
        }
    }
}