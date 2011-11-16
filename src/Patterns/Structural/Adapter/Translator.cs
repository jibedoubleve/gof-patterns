namespace Design.Patterns.Structural.Adapter
{
    public class Translator
    {
        #region Methods

        public string Greetings(French french)
        {
            return french.DireBonjour();
        }

        public string Greetings(English english)
        {
            return english.SayHello();
        }

        #endregion Methods
    }
}