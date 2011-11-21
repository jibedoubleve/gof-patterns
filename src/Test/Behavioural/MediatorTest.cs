namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.Mediator;

    using NUnit.Framework;

    [TestFixture]
    public class MediatorTest
    {
        #region Methods

        [Test]
        public void CanUseMediator()
        {
            var helloWorld = "Hello world";
            var left = new User("Robert");
            var right = new User("Luc");

            var com = new Communication(left, right);
            com.Say(helloWorld);

            Assert.AreEqual(string.Format("{0} says {1} to {2}", com.Left.Name, helloWorld, right.Name)
                , left.Message);
        }

        #endregion Methods
    }
}