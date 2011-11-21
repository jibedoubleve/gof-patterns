namespace Design.Patterns.Behavioural.Strategy
{
    public class English : ILanguage
    {
        #region Methods

        public string SayBye()
        {
            return "Bye";
        }

        public string SayHello()
        {
            return "Hello";
        }

        #endregion Methods
    }
}