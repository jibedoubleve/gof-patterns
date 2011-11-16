namespace Design.Patterns.Creational.AbstractFactory
{
    public class Money
    {
        #region Constructors

        public Money(string currency)
        {
            this.Currency = currency;
        }

        #endregion Constructors

        #region Properties

        public string Currency
        {
            get;
            private set;
        }

        #endregion Properties
    }
}