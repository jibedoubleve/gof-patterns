namespace Design.Patterns.Structural.Decorator
{
    public class Addition : IRunnable
    {
        #region Fields

        private Operation operation;

        #endregion Fields

        #region Constructors

        public Addition(Operation operation)
        {
            this.operation = operation;
        }

        #endregion Constructors

        #region Methods

        public float Run()
        {
            return (float)operation.OperatorA + operation.OperatorB;
        }

        #endregion Methods
    }
}