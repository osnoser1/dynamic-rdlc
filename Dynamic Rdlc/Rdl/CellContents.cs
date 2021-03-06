﻿namespace DynamicRdlc.Rdl
{
    public class CellContents : ParentOf<ReportItem>
    {
        public CellContents(ReportItem reportItem)
            : base(reportItem)
        {
        }

        protected sealed override string GetRdlName() => typeof(CellContents).GetShortName();
    }
}