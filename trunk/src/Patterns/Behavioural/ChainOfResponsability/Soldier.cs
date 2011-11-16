namespace Design.Patterns.Behavioural.ChainOfResponsability
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Soldier : ISoldier
    {
        #region Constructors

        public Soldier(Level level)
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

        protected Level Level
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