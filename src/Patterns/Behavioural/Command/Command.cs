namespace Design.Patterns.Behavioural.Command
{
    public class Command : ICommand
    {
        #region Fields

        private Receiver receiver;

        #endregion Fields

        #region Constructors

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
            this.Result = 0;
        }

        #endregion Constructors

        #region Properties

        public int Result
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public void Run()
        {
            this.Result = this.receiver.ExecuteAction();
        }

        #endregion Methods
    }
}