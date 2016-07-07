namespace DynamicRdlc.Rdl
{
    public class Value : ParentOf<string>
    {
        public Value(string item)
            : base(item)
        {
        }

        protected sealed override string GetRdlName()
        {
            return typeof(Value).GetShortName();
        }
    }
}
