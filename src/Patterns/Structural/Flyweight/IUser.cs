namespace Design.Patterns.Structural.Flyweight
{
    using System;

    public interface IUser
    {
        #region Properties

        DateTime Birthdate
        {
            get;
            set;
        }

        string FirstName
        {
            get;
            set;
        }

        string Id
        {
            get;
        }

        bool IsFromCache
        {
            get;
        }

        string LastName
        {
            get;
            set;
        }

        #endregion Properties
    }
}