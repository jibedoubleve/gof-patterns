namespace Design.Test.Structural
{
    using Design.Patterns.Structural.Facade;

    using NUnit.Framework;

    [TestFixture]
    public class FacadeTest
    {
        #region Methods

        [Test]
        public void CanUseFacade()
        {
            var facade = new Facade();
            Assert.AreEqual("AB", facade.GetLetters());
        }

        #endregion Methods
    }
}