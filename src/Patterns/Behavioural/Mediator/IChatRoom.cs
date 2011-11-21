using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design.Patterns.Behavioural.Mediator
{
    public interface IChatRoom
    {
        void NotifyAll(string msg);
        void Register(IUser user);
    }
}
