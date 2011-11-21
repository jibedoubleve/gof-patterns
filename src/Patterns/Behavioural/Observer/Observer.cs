
namespace Design.Patterns.Behavioural.Observer
{
    public class Observer : IObserver
    {
        #region IObserver Members

        public void Execute(string message)
        {
            this.Message = message;
        }

        #endregion

        #region IObserver Members

        public string Message
        {
            get;
            private set;
        }

        #endregion
    }
}
