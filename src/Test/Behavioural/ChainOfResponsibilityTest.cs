namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.ChainOfResponsibility;

    using NUnit.Framework;

    [TestFixture]
    public class ChainOfResponsibilityTest
    {
        #region Methods

        [Test]
        public void CanTestChainOfResponsibility()
        {
            var general = new General();
            var colonel = new Colonel(general);
            var captain = new Captain(colonel);

            var orderForGeneral = new Order(Level.General, "Go here");
            var orderForColonel = new Order(Level.Colonel, "Go here");
            var orderForCaptain = new Order(Level.Captain, "Go here");

            captain.Execute(orderForGeneral);
            captain.Execute(orderForColonel);
            captain.Execute(orderForCaptain);

            Assert.AreEqual(typeof(General), orderForGeneral.ExecutedBy);
            Assert.AreEqual(typeof(Colonel), orderForColonel.ExecutedBy);
            Assert.AreEqual(typeof(Captain), orderForCaptain.ExecutedBy);
        }

        #endregion Methods
    }
}