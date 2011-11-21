namespace Design.Patterns.Behavioural.Mediator
{
    public interface IUser
    {
        #region Properties

        string Message
        {
            get;
            set;
        }

        string Name
        {
            get;
        }

        #endregion Properties
    }
}