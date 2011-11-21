namespace Design.Patterns.Behavioural.Observer
{
    public interface IObserver
    {
        #region Properties

        string Message
        {
            get;
        }

        #endregion Properties

        #region Methods

        void Execute(string message);

        #endregion Methods
    }
}