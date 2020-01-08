namespace Design.Patterns.Specification.Algo
{
    public interface ISpecification<T>
    {
        #region Methods

        ISpecification<T> And(ISpecification<T> right);

        bool Evaluate(T candidate);

        ISpecification<T> Not();

        ISpecification<T> Or(ISpecification<T> right);

        #endregion Methods
    }
}