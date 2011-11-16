namespace Design.Patterns.Behavioural.ChainOfResponsability
{
    using System;

    public class Order
    {
        #region Constructors

        public Order(Level level, string message)
        {
            this.Level = level;
            this.Message = message;
        }

        #endregion Constructors

        #region Properties

        public Type ExecutedBy
        {
            get;
            set;
        }

        public Level Level
        {
            get; private set;
        }

        public string Message
        {
            get;
            private set;
        }

        #endregion Properties
    }
}