namespace Design.Test.Structural
{
    using Design.Patterns.Structural.Decorator;

    using NUnit.Framework;

    [TestFixture]
    public class DecoratorTest
    {
        #region Methods

        [Test]
        public void CanUseAddition()
        {
            var operation = new Operation(10, 2);
            var result = new Addition(operation).Run();

            Assert.AreEqual(12, result);
        }

        [Test]
        public void CanUserMultiplication()
        {
            var operation = new Operation(10, 2);
            var result = new Multiplication(operation).Run();

            Assert.AreEqual(20, result);
        }

        #endregion Methods
    }
}