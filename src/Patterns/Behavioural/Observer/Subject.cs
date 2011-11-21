namespace Design.Patterns.Behavioural.Observer
{
    using System.Collections.Generic;

    public class Subject
    {
        #region Fields

        public List<IObserver> observers = new List<IObserver>();

        #endregion Fields

        #region Methods

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void NotifyAll(string message)
        {
            foreach (var observer in this.observers)
            {
                observer.Execute(message);
            }
        }

        #endregion Methods
    }
}