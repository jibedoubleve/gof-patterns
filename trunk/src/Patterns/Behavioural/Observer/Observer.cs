namespace Design.Patterns.Behavioural.Observer
{
    public class Observer : IObserver
    {
        #region Properties

        public string Message
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public void Execute(string message)
        {
            this.Message = message;
        }

        #endregion Methods
    }
}