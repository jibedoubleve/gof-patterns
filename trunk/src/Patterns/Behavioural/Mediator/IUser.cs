using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design.Patterns.Behavioural.Mediator
{
    public interface IUser
    {
        string Name { get; }
        string Message { get; set; }
    }
}
