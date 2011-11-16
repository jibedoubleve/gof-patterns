namespace Design.Test.Creational
{
    using Design.Patterns.Creational.AbstractFactory;

    using NUnit.Framework;

    [TestFixture]
    public class AbstractFactoryTest
    {
        #region Methods

        [Test]
        public void CanGetLowerCaseFactory()
        {
            IFactory factory = new LowerCaseFactory();
            var euro = factory.Euro();
            var dollar = factory.Dollar();

            Assert.AreEqual("euro", euro.Currency);
            Assert.AreEqual("dollar", dollar.Currency);
        }

        [Test]
        public void CanGetUpperCaseFactory()
        {
            IFactory factory = new UpperCaseFactory();
            var euro = factory.Euro();
            var dollar = factory.Dollar();

            Assert.AreEqual("EURO", euro.Currency);
            Assert.AreEqual("DOLLAR", dollar.Currency);
        }

        #endregion Methods
    }
}