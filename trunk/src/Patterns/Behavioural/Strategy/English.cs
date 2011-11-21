
namespace Design.Patterns.Behavioural.Strategy
{
    public class English : ILanguage
    {
        #region ILanguage Members

        public string SayHello()
        {
            return "Hello";
        }

        public string SayBye()
        {
            return "Bye";
        }

        #endregion
    }
}
