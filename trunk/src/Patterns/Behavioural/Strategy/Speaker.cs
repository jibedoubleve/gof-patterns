namespace Design.Patterns.Behavioural.Strategy
{
    public class Speaker : ILanguage
    {
        #region Fields

        private ILanguage language;

        #endregion Fields

        #region Constructors

        public Speaker(ILanguage language)
        {
            this.language = language;
        }

        #endregion Constructors

        #region Methods

        public string SayBye()
        {
            return this.language.SayBye();
        }

        public string SayHello()
        {
            return this.language.SayHello();
        }

        #endregion Methods
    }
}