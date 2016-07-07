namespace DynamicRdlc.Rdl
{
    public class GroupExpressions : CollectionOf<GroupExpression>, IElement
    {
        public GroupExpressions(GroupExpression groupExpression)
            : base(groupExpression)
        {
        }

        protected sealed override string GetRdlName()
        {
            return typeof(GroupExpressions).GetShortName();
        }
    }
}
