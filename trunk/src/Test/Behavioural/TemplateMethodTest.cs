namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.TemplateMethod;

    using NUnit.Framework;

    [TestFixture]
    public class TemplateMethodTest
    {
        #region Methods

        [Test]
        public void CanUseTemplateMethod()
        {
            var childClass = new ChildClass();
            childClass.Write();

            //Assertion is useless: check the code to understand
        }

        #endregion Methods
    }
}