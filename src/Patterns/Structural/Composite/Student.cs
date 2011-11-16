namespace Design.Patterns.Structural.Composite
{
    public class Student : IPresentation
    {
        #region Constructors

        public Student(string name)
        {
            this.Name = name;
        }

        #endregion Constructors

        #region Properties

        public string Name
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public string SayMyName()
        {
            return string.Format("Hello, my name's {0}", this.Name);
        }

        #endregion Methods
    }
}