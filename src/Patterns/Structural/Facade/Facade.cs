namespace Design.Patterns.Structural.Facade
{
    public class Facade
    {
        #region Fields

        private SubsystemA subsystemA;
        private SubsystemB subsystemB;

        #endregion Fields

        #region Constructors

        public Facade()
        {
            this.subsystemA = new SubsystemA();
            this.subsystemB = new SubsystemB();
        }

        #endregion Constructors

        #region Methods

        public string GetLetters()
        {
            return this.subsystemA.GetA() + this.subsystemB.GetB();
        }

        #endregion Methods
    }
}