namespace Design.Test.Structural
{
    using Design.Patterns.Structural.Flyweight;

    using NUnit.Framework;

    [TestFixture]
    public class FlyweightTest
    {
        #region Methods

        [Test]
        public void CanUseFlyweight()
        {
            var robert = "Robert";
            var dupont = "Dupont";

            IUser user = CachingFactory.GetUser("login");

            user.FirstName = robert;
            user.LastName = dupont;

            Assert.IsFalse(user.IsFromCache);
            Assert.AreEqual("login", user.Id);

            IUser other = CachingFactory.GetUser("login");

            Assert.AreEqual(other.FirstName, robert);
            Assert.AreEqual(other.LastName, dupont);
            Assert.IsTrue(other.IsFromCache);

            //I can user a non cached IUser
            var nonCahcedUser = new NonCachedUser("someId");
        }

        #endregion Methods
    }
}