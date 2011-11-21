namespace Design.Patterns.Behavioural.State
{
    public class Account
    {
        #region Constructors

        public Account(int amount)
        {
            this.Amount = amount;
        }

        #endregion Constructors

        #region Properties

        public int Amount
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public void Deposit(int value)
        {
            this.Amount += value;
        }

        #endregion Methods
    }
}