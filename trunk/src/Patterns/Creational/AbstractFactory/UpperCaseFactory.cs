namespace Design.Patterns.Creational.AbstractFactory
{
    public class UpperCaseFactory : IFactory
    {
        #region Methods

        public Money Dollar()
        {
            return new Money("DOLLAR");
        }

        public Money Euro()
        {
            return new Money("EURO");
        }

        #endregion Methods
    }
}