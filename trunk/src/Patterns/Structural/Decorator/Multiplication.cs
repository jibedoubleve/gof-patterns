namespace Design.Patterns.Structural.Decorator
{
    public class Multiplication : IRunnable
    {
        #region Fields

        private Operation operation;

        #endregion Fields

        #region Constructors

        public Multiplication(Operation operation)
        {
            this.operation = operation;
        }

        #endregion Constructors

        #region Methods

        public float Run()
        {
            return (float)this.operation.OperatorA * this.operation.OperatorB;
        }

        #endregion Methods
    }
}