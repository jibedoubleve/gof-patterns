namespace Design.Test.Structural
{
    using Design.Patterns.Structural.Adapter;

    using NUnit.Framework;

    [TestFixture]
    public class AdapterTest
    {
        #region Methods

        [Test]
        public void CanCalculateAverage()
        {
            Average average = new Average();
            average.Add(1);
            average.Add(2);
            average.Add(3);

            Assert.AreEqual(2, average.Calculate());
        }

        [Test]
        public void CanDivide()
        {
            var division = new Division(10, 5);
            Assert.AreEqual(2, division.Calculate());
        }

        [Test]
        public void CanSum()
        {
            var sum = new Sum();
            sum.Add(1);
            sum.Add(2);
            sum.Add(3);

            Assert.AreEqual(3, sum.Count);
            Assert.AreEqual(6, sum.Calculate());
        }

        [Test]
        public void ObjectAdapter()
        {
            var translator = new Translator();

            Assert.AreEqual("Bonjour", translator.Greetings(new French()));
            Assert.AreEqual("Hello", translator.Greetings(new English()));
        }

        #endregion Methods
    }
}