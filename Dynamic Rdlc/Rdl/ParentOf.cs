using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public abstract class ParentOf<T> : IElement
    {
        protected ParentOf(T item)
        {
            this.Item = item;
        }

        public XElement Element
        {
            get
            {
                return this.Build();
            }
        }

        protected T Item { get; private set; }

        protected abstract string GetRdlName();

        protected virtual XElement Build()
        {
            var result = new XElement(this.GetRdlName());
            var value = this.Item as IElement;
            if (value != null)
            {
                result.Add(value.Element);
            }
            else
            {
                result.Add(this.Item);
            }

            return result;
        }
    }
}
