namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.Command;

    using NUnit.Framework;

    [TestFixture]
    public class CommandTest
    {
        #region Methods

        [Test]
        public void CanTestCommand()
        {
            var invoker = new Invoker();

            invoker.AddCommand(new ConcreteCommand());
            invoker.AddCommand(new ConcreteCommand());
            invoker.AddCommand(new ConcreteCommand());

            invoker.Invoke();

            foreach (var result in invoker.Result)
            {
                Assert.AreEqual(42, result);
            }
        }

        #endregion Methods
    }
}