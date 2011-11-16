namespace Design.Patterns.Creational.Builder
{
    public interface IBuilder
    {
        #region Methods

        Vehicle Build(string garage);

        #endregion Methods
    }
}