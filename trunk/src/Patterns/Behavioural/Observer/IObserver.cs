
namespace Design.Patterns.Behavioural.Observer
{
    public interface IObserver
    {
        string Message { get; }
        void Execute(string message);
    }
}
