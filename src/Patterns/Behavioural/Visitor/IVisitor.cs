namespace Design.Patterns.Behavioural.Visitor
{
    public interface IVisitor
    {
        #region Properties

        int Total
        {
            get;
        }

        #endregion Properties

        #region Methods

        void Visit(IEmployee visitee);

        #endregion Methods
    }
}