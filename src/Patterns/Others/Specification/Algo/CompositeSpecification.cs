namespace Design.Patterns.Specification.Algo
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        #region Methods

        public static CompositeSpecification<T> operator !(CompositeSpecification<T> operand) => new NotSpecification<T>(operand);

        public static CompositeSpecification<T> operator &(CompositeSpecification<T> left, ISpecification<T> right) => new AndSpecification<T>(left, right);

        public static CompositeSpecification<T> operator |(CompositeSpecification<T> left, ISpecification<T> right) => new OrSpecification<T>(left, right);

        public ISpecification<T> And(ISpecification<T> right) => new AndSpecification<T>(this, right);

        public abstract bool Evaluate(T candidate);

        public ISpecification<T> Not() => new NotSpecification<T>(this);

        public ISpecification<T> Or(ISpecification<T> right) => new OrSpecification<T>(this, right);

        #endregion Methods
    }
}