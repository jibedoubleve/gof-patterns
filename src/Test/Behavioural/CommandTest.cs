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
            /* The invoker doesn't know anything about the receiver.
             * That's the point of the Command pattern.
             */
            var invoker = new Invoker();

            /* Invoking a ConcreteCommand will only set the property Result
             * to 42. The property Result of the Invoker is an array of each
             * result added into the Invoker through the method AddCommand
             */
            invoker.AddCommand(new Command(new Receiver()));
            invoker.AddCommand(new Command(new Receiver()));
            invoker.AddCommand(new Command(new Receiver()));

            invoker.Invoke();

            foreach (var result in invoker.Result)
            {
                Assert.AreEqual(42, result);
            }
        }

        #endregion Methods
    }
}