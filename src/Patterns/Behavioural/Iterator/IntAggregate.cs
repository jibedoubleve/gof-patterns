namespace Design.Patterns.Behavioural.Iterator
{
    using System.Collections.Generic;

    public class IntAggregate : IAggregate<int>
    {
        #region Fields

        private List<int> list = new List<int>();

        #endregion Fields

        #region Properties

        public int Count
        {
            get { return this.list.Count; }
        }

        #endregion Properties

        #region Indexers

        public int this[int index]
        {
            get { return this.list[index]; }
        }

        #endregion Indexers

        #region Methods

        public void Add(int value)
        {
            this.list.Add(value);
        }

        public IIterator<int> CreateIterator()
        {
            return new IntIterator(this);
        }

        #endregion Methods
    }
}