namespace Design.Patterns.Behavioural.Interpreter
{
    public class Minus : IExpression
    {
        #region Fields

        private int value;

        #endregion Fields

        #region Constructors

        public Minus(IExpression left, IExpression right)
        {
            this.Left = left;
            this.Right = right;
        }

        #endregion Constructors

        #region Properties

        public IExpression Left
        {
            get; private set;
        }

        public IExpression Right
        {
            get; private set;
        }

        #endregion Properties

        #region Methods

        public int Interpret()
        {
            return this.Left.Interpret() - this.Right.Interpret();
        }

        #endregion Methods
    }
}