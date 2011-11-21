using System.Collections.Generic;
namespace Design.Patterns.Behavioural.Memento
{
    public class Caretaker
    {
        private Stack<Memento> stack = new Stack<Memento>();
        public void PushState(Originator originator)
        {
            var memento = originator.SaveState();
            this.stack.Push(memento);
        }

        public void PopState(Originator originator)
        {
            var memento = this.stack.Pop();
            originator.SetState(memento);
        }
    }
}