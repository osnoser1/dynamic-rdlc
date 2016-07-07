namespace PeriodicTable.Report.Rdl
{
    using System.Xml.Linq;

    public interface IElement
    {
        XElement Element { get; }
    }
}
