namespace Design.Patterns.Behavioural.ChainOfResponsibility
{
    public interface ISoldier
    {
        #region Properties

        ISoldier Superior
        {
            set;
        }

        #endregion Properties

        #region Methods

        void Execute(Order order);

        #endregion Methods
    }
}