namespace Design.Test.Structural
{
    using Design.Patterns.Structural.Bridge;

    using NUnit.Framework;

    [TestFixture]
    public class BridgeTest
    {
        #region Fields

        private int[] tableBy2 = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        private int[] tableBy9 = new int[] { 9, 18, 27, 36, 45, 54, 63, 72, 81, 90 };

        #endregion Fields

        #         region Methods

        [Test]
        public void CanUseTableBy2()
        {
            var counter = new Counter(new TableBy2());

            var result = counter.Start();

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(tableBy2[i], result[i]);
            }
        }

        [Test]
        public void CanUseTableBy9()
        {
            var counter = new Counter(new TableBy9());

            var result = counter.Start();

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(tableBy9[i], result[i]);
            }
        }

        #endregion Methods
    }
}