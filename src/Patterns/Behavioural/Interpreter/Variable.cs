namespace Design.Patterns.Behavioural.Interpreter
{
    public class Variable : IExpression
    {
        #region Constructors

        public Variable(int value)
        {
            this.value = value;
        }

        #endregion Constructors

        #region Methods

        public int Interpret() { return this.value; }

        #endregion Methods

        #region IExpression Members


        private int value;

        #endregion
    }
}