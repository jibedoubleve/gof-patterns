namespace Design.Patterns.Behavioural.Memento
{
    public class Originator
    {
        #region Constructors

        public Originator(int state)
        {
            this.State = state;
        }

        #endregion Constructors

        #region Properties

        public int State
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        public Memento SaveState()
        {
            return new Memento() { State = this.State };
        }

        internal void SetState(Memento memento)
        {
            this.State = memento.State;
        }

        #endregion Methods
    }
}