namespace DynamicRdlc.Rdl
{
    public class GroupExpression : ParentOf<string>
    {
        public GroupExpression(string item)
            : base(item)
        {
        }

        protected sealed override string GetRdlName() => typeof(GroupExpression).GetShortName();
    }
}