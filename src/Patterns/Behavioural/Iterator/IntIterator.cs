namespace Design.Patterns.Behavioural.Iterator
{
    public class IntIterator : IIterator<int>
    {
        #region Fields

        private IAggregate<int> aggregate;
        private int index = -1;

        #endregion Fields

        #region Constructors

        public IntIterator(IntAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        #endregion Constructors

        #region Properties

        public int Current
        {
            get { return this.aggregate[index]; }
        }

        public bool IsDone
        {
            get { return index >= 0 && index < this.aggregate.Count; }
        }

        #endregion Properties

        #region Methods

        public bool Next()
        {
            this.index++;
            return this.IsDone;
        }

        public bool Previous()
        {
            this.index--;
            return this.IsDone;
        }

        public void Reset()
        {
            index = -1;
        }

        #endregion Methods
    }
}