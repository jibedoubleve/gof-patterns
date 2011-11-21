namespace Design.Patterns.Behavioural.Iterator
{
    public interface IAggregate<T>
    {
        #region Properties

        int Count
        {
            get;
        }

        T this[int index]
        {
            get;
        }

        #endregion Properties

        #region Methods

        IIterator<T> CreateIterator();

        #endregion Methods
    }
}