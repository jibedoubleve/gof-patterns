namespace Design.Test.Creational
{
    using Design.Patterns.Creational.FactoryMethod;

    using NUnit.Framework;

    [TestFixture]
    public class FactoryMethodTest
    {
        #region Methods

        [Test]
        public void CanCreateDollar()
        {
            var dollar = Money.Dollar(10);

            Assert.AreEqual("dollar", dollar.Currency);
            Assert.AreEqual(10, dollar.Value);
        }

        [Test]
        public void CanCreateEuro()
        {
            var dollar = Money.Euro(10);

            Assert.AreEqual("euro", dollar.Currency);
            Assert.AreEqual(10, dollar.Value);
        }

        #endregion Methods
    }
}