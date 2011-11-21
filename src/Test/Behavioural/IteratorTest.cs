namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.Iterator;

    using NUnit.Framework;

    [TestFixture]
    public class IteratorTest
    {
        #region Fields

        private IntAggregate collection;

        #endregion Fields

        #region Methods

        [Test]
        public void CanResetIterator()
        {
            var iterator = collection.CreateIterator();

            while (iterator.Next()) ; //Loop for nothing
            iterator.Reset();

            iterator.Next();
            Assert.AreEqual(1, iterator.Current);
        }

        [Test]
        public void CanUserIterator()
        {
            var i = 0;
            var iterator = collection.CreateIterator();
            while (iterator.Next())
            {
                Assert.AreEqual(++i, iterator.Current);
            }
        }

        [SetUp]
        public void Setup()
        {
            var i = 0;
            this.collection = new IntAggregate();
            this.collection.Add(++i);
            this.collection.Add(++i);
            this.collection.Add(++i);
            this.collection.Add(++i);
            this.collection.Add(++i);
            this.collection.Add(++i);
            this.collection.Add(++i);
            collection.Add(++i);
        }

        #endregion Methods
    }
}