using Design.Patterns.Specification.Algo;

namespace Design.Patterns.Specification.Rules
{
    public class IsNegative : CompositeSpecification<int>
    {
        #region Methods

        public override bool Evaluate(int candidate) => candidate < 0;

        #endregion Methods
    }
}