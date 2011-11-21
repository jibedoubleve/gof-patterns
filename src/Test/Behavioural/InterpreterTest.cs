namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.Interpreter;

    using NUnit.Framework;

    [TestFixture]
    public class InterpreterTest
    {
        #region Methods

        [Test]
        public void CanBuildExpressionStack()
        {
            // (1+2) - (3-4) = 4
            //   3   -  (-1) = 4

            var a = new Plus(new Variable(1), new Variable(2));
            var b = new Minus(new Variable(3), new Variable(4));
            var result = new Minus(a, b);

            Assert.AreEqual(4, result.Interpret());
        }

        #endregion Methods
    }
}