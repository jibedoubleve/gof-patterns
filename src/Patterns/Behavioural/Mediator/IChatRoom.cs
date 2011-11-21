namespace Design.Patterns.Behavioural.Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IChatRoom
    {
        #region Methods

        void NotifyAll(string msg);

        void Register(IUser user);

        #endregion Methods
    }
}