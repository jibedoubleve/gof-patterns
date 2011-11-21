namespace Design.Patterns.Behavioural.Memento
{
    using System.Collections.Generic;

    public class Caretaker
    {
        #region Fields

        private Stack<Memento> stack = new Stack<Memento>();

        #endregion Fields

        #region Methods

        public void PopState(Originator originator)
        {
            var memento = this.stack.Pop();
            originator.SetState(memento);
        }

        public void PushState(Originator originator)
        {
            var memento = originator.SaveState();
            this.stack.Push(memento);
        }

        #endregion Methods
    }
}