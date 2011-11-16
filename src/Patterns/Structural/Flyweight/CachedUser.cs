namespace Design.Patterns.Structural.Flyweight
{
    using System;

    public class CachedUser : IUser
    {
        #region Constructors

        internal CachedUser(string id)
        {
            this.Id = id;
        }

        #endregion Constructors

        #region Properties

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
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        #endregion Properties
    }
}