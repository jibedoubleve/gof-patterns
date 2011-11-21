namespace Design.Test.Behavioural
{
    using NUnit.Framework;
    using Design.Patterns.Behavioural.Strategy;

    [TestFixture]
    public class StrategyTest
    {
        #region Methods

        [Test]
        public void CanUserStrategy()
        {
            var speaker = new Speaker(new French());

            Assert.AreEqual("bonjour", speaker.SayHello().ToLower());
            Assert.AreEqual("au revoir", speaker.SayBye().ToLower());

            speaker = new Speaker(new English());

            Assert.AreEqual("hello", speaker.SayHello().ToLower());
            Assert.AreEqual("bye", speaker.SayBye().ToLower());
        }

        #endregion Methods
    }
}