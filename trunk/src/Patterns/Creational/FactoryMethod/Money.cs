namespace Design.Patterns.Creational.FactoryMethod
{
    public class Money
    {
        #region Constructors

        private Money(string currency, int value)
        {
            this.Currency = currency;
            this.Value = value;
        }

        #endregion Constructors

        #region Properties

        public string Currency
        {
            get;
            private set;
        }

        public int Value
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public static Money Dollar(int value)
        {
            return new Money("dollar", value);
        }

        public static Money Euro(int value)
        {
            return new Money("euro", value);
        }

        #endregion Methods
    }
}