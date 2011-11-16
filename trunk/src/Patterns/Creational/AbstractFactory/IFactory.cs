namespace Design.Patterns.Creational.AbstractFactory
{
    public interface IFactory
    {
        #region Methods

        Money Dollar();

        Money Euro();

        #endregion Methods
    }
}