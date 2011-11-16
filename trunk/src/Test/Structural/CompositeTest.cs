namespace Design.Test.Structural
{
    using Design.Patterns.Structural.Composite;

    using NUnit.Framework;

    [TestFixture]
    public class CompositeTest
    {
        #region Fields

        private string[] names = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l"
            , "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        #endregion Fields

        #region Methods

        [Test]
        public void CanUseComposite()
        {
            var students = new StudentCollection();

            for (int i = 0; i < names.Length; i++) { students.Add(new Student(names[i])); }

            var result = students.SayMyName();

            Assert.AreEqual(result, this.BuildResult());
        }

        private string BuildResult()
        {
            var result = string.Empty;
            foreach (var item in names) { result += "Hello, my name's " + item + " | "; }
            return result;
        }

        #endregion Methods
    }
}