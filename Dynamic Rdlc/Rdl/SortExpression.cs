﻿namespace DynamicRdlc.Rdl
{
    public class SortExpression : ParentOf<Value>
    {
        public SortExpression(Value value)
            : base(value)
        {
        }

        protected sealed override string GetRdlName() => typeof(SortExpression).GetShortName();
    }
}