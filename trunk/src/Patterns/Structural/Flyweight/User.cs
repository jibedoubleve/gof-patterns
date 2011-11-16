namespace Design.Patterns.Structural.Flyweight
{
    using System;

    public class NonCachedUser : IUser
    {
        #region Constructors

        public NonCachedUser(string id)
        {
            this.Id = id;
            this.IsFromCache = false;
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
            private set;
        }

        public string LastName
        {
            get;
            set;
        }

        #endregion Properties
    }
}