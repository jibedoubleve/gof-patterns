namespace Design.Patterns.Behavioural.ChainOfResponsability
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