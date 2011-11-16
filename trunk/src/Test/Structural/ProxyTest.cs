namespace Design.Test.Structural
{
    using Design.Patterns.Structural.Proxy;

    using NUnit.Framework;

    [TestFixture]
    public class ProxyTest
    {
        #region Methods

        [Test]
        public void CanUserproxy()
        {
            var feature = new Feature();
            var proxy = new Proxy(feature);

            Assert.AreEqual(proxy.GetHello(), feature.GetHello()); ;
        }

        #endregion Methods
    }
}