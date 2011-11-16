namespace Design.Test.Creational
{
    using Design.Patterns.Creational.Singletton;

    using NUnit.Framework;

    [TestFixture]
    public class SinglettonTest
    {
        #region Methods

        [Test]
        public void CanHaveOnlyOneInstance()
        {
            var one = Unique.Instance;
            var other = Unique.Instance;

            Assert.AreEqual(one.Guid, other.Guid);
        }

        #endregion Methods
    }
}