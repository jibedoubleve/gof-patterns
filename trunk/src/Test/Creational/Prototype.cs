namespace Design.Test.Creational
{
    using Design.Patterns.Creational.Prototype;

    using NUnit.Framework;

    [TestFixture]
    public class PrototypeTest
    {
        #region Methods

        [Test]
        public void CanClone()
        {
            var house = new House("my house", 1, 3);
            var other = house.Clone();

            Assert.AreEqual(house.DoorCount, other.DoorCount);
            Assert.AreEqual(house.WindowCount, other.WindowCount);
            Assert.AreEqual(house.Name, other.Name);
        }

        #endregion Methods
    }
}