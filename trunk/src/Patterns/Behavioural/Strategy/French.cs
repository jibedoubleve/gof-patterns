namespace Design.Patterns.Behavioural.Strategy
{
    public class French : ILanguage
    {
        #region Methods

        public string SayBye()
        {
            return "Au revoir";
        }

        public string SayHello()
        {
            return "Bonjour";
        }

        #endregion Methods
    }
}