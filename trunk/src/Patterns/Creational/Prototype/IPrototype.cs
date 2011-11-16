namespace Design.Patterns.Creational.Prototype
{
    public interface IPrototype<T>
    {
        #region Methods

        T Clone();

        #endregion Methods
    }
}