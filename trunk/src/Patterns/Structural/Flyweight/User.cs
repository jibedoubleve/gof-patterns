using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design.Patterns.Structural.Flyweight
{
    public class NonCachedUser : IUser
    {
        #region IUser Members
        public NonCachedUser(string id)
        {
            this.Id = id;
            this.IsFromCache = false;
        }
        public DateTime Birthdate
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string Id
        {
            get;
            private set;
        }

        public bool IsFromCache
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            set;
        }

        #endregion
    }
}
