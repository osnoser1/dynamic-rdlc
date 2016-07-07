using System.Xml.Linq;

namespace DynamicRdlc.Rdl
{
    public interface IElement
    {
        XElement Element { get; }
    }
}