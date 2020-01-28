using Design.Patterns.Others;
using NUnit.Framework;

namespace Design.Test.Others
{
    [TestFixture]
    public class ReversePolishNotationTest
    {
        #region Methods

        [Test]
        [TestCase(45, "3 10 5 + *")]
        [TestCase(15, "3 4 1 2 + * +")]
        [TestCase(15, "1 2 + 4 * 3 +")]
        public void CanCalculateWithPolishNotation(double expected, string operation)
        {
            var c = new ReversePolishNotation();

            var result = c.Calculate(operation);
            Assert.That(result, Is.EqualTo(expected));
        }

        #endregion Methods
    }
}