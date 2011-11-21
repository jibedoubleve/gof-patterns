namespace Design.Patterns.Behavioural.Iterator
{
    public interface IIterator<T>
    {
        #region Properties

        T Current
        {
            get;
        }

        bool IsDone
        {
            get;
        }

        #endregion Properties

        #region Methods

        bool Next();

        bool Previous();

        void Reset();

        #endregion Methods
    }
}