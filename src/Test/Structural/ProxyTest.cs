using Design.Patterns.Structural.Proxy;
using NUnit.Framework;

namespace Design.Test.Structural
{
    [TestFixture]
    public class ProxyTest
    {
        [Test]
        public void CanUserproxy()
        {
            var feature = new Feature();
            var proxy = new Proxy(feature);

            Assert.AreEqual(proxy.GetHello(), feature.GetHello()); ;
        }
    }
}
