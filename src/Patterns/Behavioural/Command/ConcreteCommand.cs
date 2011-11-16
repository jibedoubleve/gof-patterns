namespace Design.Patterns.Behavioural.Command
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ConcreteCommand : ICommand
    {
        #region Constructors

        public ConcreteCommand()
        {
            this.Result = 0;
        }

        #endregion Constructors

        #region Properties

        public int Result
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public void Run()
        {
            this.Result = 42;
        }

        #endregion Methods
    }
}