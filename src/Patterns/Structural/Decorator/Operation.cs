namespace Design.Patterns.Structural.Decorator
{
    public class Operation
    {
        #region Constructors

        public Operation(int operatorA, int operatorB)
        {
            this.OperatorA = operatorA;
            this.OperatorB = operatorB;
        }

        #endregion Constructors

        #region Properties

        public int OperatorA
        {
            get; private set;
        }

        public int OperatorB
        {
            get; private set;
        }

        #endregion Properties
    }
}