namespace Design.Patterns.Behavioural.Mediator
{
    public class User : IUser
    {
        #region Constructors

        public User(string name)
        {
            this.Name = name;
            this.Message = string.Empty;
        }

        #endregion Constructors

        #region Properties

        public string Message
        {
            get;
            set;
        }

        public string Name
        {
            get;
            private set;
        }

        #endregion Properties
    }
}