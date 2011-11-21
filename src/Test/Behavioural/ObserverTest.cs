namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.Observer;

    using NUnit.Framework;

    [TestFixture]
    public class ObserverTest
    {
        #region Methods

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

        #endregion Methods
    }
}