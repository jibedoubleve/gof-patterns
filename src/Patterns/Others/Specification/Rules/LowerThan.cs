using Design.Patterns.Specification.Algo;

namespace Design.Patterns.Specification.Rules
{
    public class LowerThan : CompositeSpecification<int>
    {
        #region Fields

        private readonly int _threshold;

        #endregion Fields

        #region Constructors

        public LowerThan(int threshold)
        {
            _threshold = threshold;
        }

        #endregion Constructors

        #region Methods

        public override bool Evaluate(int candidate) => candidate < _threshold;

        #endregion Methods
    }
}