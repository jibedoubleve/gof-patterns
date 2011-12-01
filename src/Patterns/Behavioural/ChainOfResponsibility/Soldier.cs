namespace Design.Patterns.Behavioural.ChainOfResponsibility
{
    public abstract class Soldier : ISoldier
    {
        #region Constructors

        public Soldier(Destination level)
        {
            this.Level = level;
        }

        #endregion Constructors

        #region Properties

        public ISoldier Superior
        {
            set;
            get;
        }

        protected Destination Level
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public void Execute(Order order)
        {
            if (this.Level == order.Level) order.ExecutedBy = this.GetType();
            else if (this.Superior != null) this.Superior.Execute(order);
        }

        #endregion Methods
    }
}