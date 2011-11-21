namespace Design.Patterns.Behavioural.Visitor
{
    public interface IVisitor
    {
        #region Methods

        void Visit(IEmployee visitee);

        #endregion Methods

        int Total { get; }
    }
}