namespace Design.Patterns.Structural.Adapter
{
    public class Division
    {
        #region Constructors

        public Division(int operatorA, int operatorB)
        {
            this.OperatorA = operatorA;
            this.OperatorB = operatorB;
        }

        public Division()
        {
        }

        #endregion Constructors

        #region Properties

        public int OperatorA
        {
            get; set;
        }

        public int OperatorB
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        public float Calculate()
        {
            return ((float)this.OperatorA) / ((float)this.OperatorB);
        }

        #endregion Methods
    }
}