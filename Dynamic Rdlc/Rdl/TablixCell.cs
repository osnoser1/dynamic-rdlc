namespace DynamicRdlc.Rdl
{
    public class TablixCell : ParentOf<CellContents>
    {
        public TablixCell(CellContents item)
            : base(item)
        {
        }

        protected sealed override string GetRdlName() => typeof(TablixCell).GetShortName();
    }
}