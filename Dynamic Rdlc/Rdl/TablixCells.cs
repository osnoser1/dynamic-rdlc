namespace DynamicRdlc.Rdl
{
    public class TablixCells : CollectionOf<TablixCell>, IElement
    {
        public TablixCells(TablixCell tablixCell)
            : base(tablixCell)
        {
        }

        public TablixCells()
        {
        }

        protected sealed override string GetRdlName() => typeof(TablixCells).GetShortName();
    }
}