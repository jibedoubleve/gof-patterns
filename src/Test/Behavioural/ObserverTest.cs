using NUnit.Framework;
using Design.Patterns.Behavioural.Observer;
namespace Design.Test.Behavioural
{
    [TestFixture]
    public class ObserverTest
    {
        [Test]
        public void CanUserObserver()
        {
            var helloWorld = "Hello world";
            var subject = new Subject();

            var observer1 = new Observer();
            var observer2 = new Observer();

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.NotifyAll(helloWorld);

            Assert.AreEqual(helloWorld, observer1.Message);
            Assert.AreEqual(helloWorld, observer2.Message);
        }
    }
}