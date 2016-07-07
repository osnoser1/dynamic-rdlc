namespace DynamicRdlc.Rdl
{
    public class Paragraphs : CollectionOf<Paragraph>, IElement
    {
        public Paragraphs()
        {
        }

        public Paragraphs(Paragraph paragraph)
            : base(paragraph)
        {
        }

        protected sealed override string GetRdlName() => typeof(Paragraphs).GetShortName();
    }
}