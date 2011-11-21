namespace Design.Patterns.Behavioural.Interpreter
{
    public class Plus : IExpression
    {
        public IExpression Left { get; private set; }
        public IExpression Right { get; private set; }
        public Plus(IExpression left, IExpression right)
        {
            this.Left = left;
            this.Right = right;
        }
        #region Methods

        public int Interpret()
        {
            return this.Left.Interpret() + this.Right.Interpret();
        }

        #endregion Methods

        #region IExpression Members


        private int value;

        #endregion
    }
}