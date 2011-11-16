namespace Design.Patterns.Behavioural.Command
{
    public interface ICommand
    {
        #region Properties

        int Result
        {
            get;
        }

        #endregion Properties

        #region Methods

        void Run();

        #endregion Methods
    }
}