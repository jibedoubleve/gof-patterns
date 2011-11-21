namespace Design.Patterns.Behavioural.Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IUser
    {
        #region Properties

        string Message
        {
            get; set;
        }

        string Name
        {
            get;
        }

        #endregion Properties
    }
}