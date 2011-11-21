
namespace Design.Patterns.Behavioural.Strategy
{
    public class Speaker : ILanguage
    {
        private ILanguage language;
        public Speaker(ILanguage language)
        {
            this.language = language;
        }

        #region ILanguage Members

        public string SayHello()
        {
            return this.language.SayHello();
        }

        public string SayBye()
        {
            return this.language.SayBye();
        }

        #endregion
    }
}
