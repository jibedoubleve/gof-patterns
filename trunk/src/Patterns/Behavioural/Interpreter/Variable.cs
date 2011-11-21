namespace Design.Patterns.Behavioural.Interpreter
{
    public class Variable : IExpression
    {
        #region Fields

        private int value;

        #endregion Fields

        #region Constructors

        public Variable(int value)
        {
            this.value = value;
        }

        #endregion Constructors

        #region Methods

        public int Interpret()
        {
            return this.value;
        }

        #endregion Methods
    }
}