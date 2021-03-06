﻿namespace DynamicRdlc.Rdl
{
    public class TablixCornerRow : ParentOf<TablixCornerCell>
    {
        public TablixCornerRow(TablixCornerCell item)
            : base(item)
        {
        }

        protected sealed override string GetRdlName() => typeof(TablixCornerRow).GetShortName();
    }
}