namespace Design.Patterns.Behavioural.Iterator
{
    public interface IAggregate<T>
    {
        #region Properties

        int Count
        {
            get;
        }

        IIterator<T> CreateIterator();

        T this[int index]
        {
            get;
        }

        #endregion Properties
    }
}