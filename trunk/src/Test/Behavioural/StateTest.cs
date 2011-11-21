namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.State;

    using NUnit.Framework;

    [TestFixture]
    public class StateTest
    {
        #region Methods

        [Test]
        public void CanUseState()
        {
            var person = new Person(new Account(10));

            Assert.AreEqual(Richness.Poor, person.Richness);

            person.Account.Deposit(100);
            Assert.AreEqual(Richness.Average, person.Richness);

            person.Account.Deposit(1000);
            Assert.AreEqual(Richness.Rich, person.Richness);

            person.Account.Deposit(10000);
            Assert.AreEqual(Richness.ShockinglyRich, person.Richness);
        }

        #endregion Methods
    }
}