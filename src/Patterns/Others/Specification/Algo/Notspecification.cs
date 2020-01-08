namespace Design.Patterns.Specification.Algo
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        #region Constructors

        public NotSpecification(ISpecification<T> operand)
        {
            Operand = operand;
        }

        #endregion Constructors

        #region Properties

        public ISpecification<T> Operand { get; private set; }

        #endregion Properties

        #region Methods

        public override bool Evaluate(T candidate) => !Operand.Evaluate(candidate);

        #endregion Methods
    }
}