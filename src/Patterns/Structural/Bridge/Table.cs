namespace Design.Patterns.Structural.Bridge
{
    public class Table : IMultiplicationTable
    {
        #region Fields

        private int value = 0;

        #endregion Fields

        #region Constructors

        protected Table(int multiplicator)
        {
            this.Multiplicator = multiplicator;
        }

        #endregion Constructors

        #region Properties

        protected int Multiplicator
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public int Next()
        {
            return ++value * Multiplicator;
        }

        public void Reset()
        {
            this.value = 0;
        }

        #endregion Methods
    }
}