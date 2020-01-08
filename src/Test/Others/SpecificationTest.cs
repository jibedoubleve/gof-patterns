using Design.Patterns.Specification.Rules;
using NUnit.Framework;

namespace Design.Test.Others
{
    [TestFixture]
    public class SpecificationTest
    {
        #region Methods

        /// <summary>
        /// More infomation about this pattern here
        /// https://en.m.wikipedia.org/wiki/Specification_pattern
        /// </summary>
        /// <remarks>
        /// Be aware this pattern has strong disadvantages. Think before using it blindly
        /// </remarks>
        [Test]
        public void CanUseSpecificatio()
        {
            //rules
            var gt = new GreaterThan(5);
            var lt = new LowerThan(10);
            var isNeg = new IsNegative();

            //expression
            var exp1 = (gt & lt) | isNeg;
            var exp2 = !((gt & lt) | isNeg);

            //result
            var r1 = exp1.Evaluate(6);
            var r2 = exp2.Evaluate(6);

            Assert.That(r1, Is.True);
            Assert.That(r2, Is.False);
        }

        #endregion Methods
    }
}