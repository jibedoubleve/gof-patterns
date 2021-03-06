﻿namespace Design.Patterns.Behavioural.ChainOfResponsibility
{
    using System;

    public class Order
    {
        #region Constructors

        public Order(Destination level, string message)
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

        public Destination Level
        {
            get;
            private set;
        }

        public string Message
        {
            get;
            private set;
        }

        #endregion Properties
    }
}