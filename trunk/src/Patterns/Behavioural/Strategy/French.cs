
namespace Design.Patterns.Behavioural.Strategy
{
    public class French : ILanguage
    {
        #region ILanguage Members

        public string SayHello()
        {
            return "Bonjour";
        }

        public string SayBye()
        {
            return "Au revoir";
        }

        #endregion
    }
}
