namespace Design.Patterns.Creational.AbstractFactory
{
    public class LowerCaseFactory : IFactory
    {
        #region Methods

        public Money Dollar()
        {
            return new Money("dollar");
        }

        public Money Euro()
        {
            return new Money("euro");
        }

        #endregion Methods
    }
}