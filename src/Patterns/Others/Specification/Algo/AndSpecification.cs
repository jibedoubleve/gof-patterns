namespace Design.Patterns.Specification.Algo
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        #region Constructors

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            Left = left;
            Right = right;
        }

        #endregion Constructors

        #region Properties

        public ISpecification<T> Left { get; }
        public ISpecification<T> Right { get; }

        #endregion Properties

        #region Methods

        public override bool Evaluate(T candidate) => Left.Evaluate(candidate) && Right.Evaluate(candidate);

        #endregion Methods
    }
}