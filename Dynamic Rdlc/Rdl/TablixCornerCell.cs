namespace DynamicRdlc.Rdl
{
    public class TablixCornerCell : ParentOf<CellContents>
    {
        public TablixCornerCell(CellContents item)
            : base(item)
        {
        }

        protected sealed override string GetRdlName() => typeof(TablixCornerCell).GetShortName();
    }
}