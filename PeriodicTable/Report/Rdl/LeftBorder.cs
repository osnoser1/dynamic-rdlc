﻿namespace PeriodicTable.Report.Rdl
{
    public class LeftBorder : Border
    {
        protected override string BorderName
        {
            get
            {
                return "Left" + base.BorderName;
            }
        }
    }
}
