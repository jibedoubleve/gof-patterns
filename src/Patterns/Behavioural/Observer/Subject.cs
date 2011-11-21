
using System.Collections.Generic;
namespace Design.Patterns.Behavioural.Observer
{
    public class Subject
    {
        public List<IObserver> observers = new List<IObserver>();
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
    }
}
