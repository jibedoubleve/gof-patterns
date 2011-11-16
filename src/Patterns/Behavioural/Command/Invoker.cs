namespace Design.Patterns.Behavioural.Command
{
    using System.Collections.Generic;

    public class Invoker
    {
        #region Fields

        private List<ICommand> commands = new List<ICommand>();
        private List<int> results = new List<int>();

        #endregion Fields

        #region Properties

        public int[] Result
        {
            get
            {
                return this.results.ToArray();
            }
        }

        #endregion Properties

        #region Methods

        public void AddCommand(ICommand command)
        {
            this.commands.Add(command);
        }

        public void Invoke()
        {
            this.results = new List<int>();
            foreach (var command in this.commands)
            {
                if (command != null)
                {
                    command.Run();
                    this.results.Add(command.Result);
                }
            }
        }

        #endregion Methods
    }
}