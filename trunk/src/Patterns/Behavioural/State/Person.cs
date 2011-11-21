namespace Design.Patterns.Behavioural.State
{
    public class Person
    {
        #region Constructors

        public Person(Account account)
        {
            this.Account = account;
        }

        #endregion Constructors

        #region Properties

        public Account Account
        {
            get;
            private set;
        }

        public Richness Richness
        {
            get
            {
                if (this.Account.Amount <= 100) return Richness.Poor;
                else if (this.Account.Amount > 100 && this.Account.Amount <= 1000) return Richness.Average;
                else if (this.Account.Amount > 1000 && this.Account.Amount <= 10000) return Richness.Rich;
                else return Richness.ShockinglyRich;
            }
        }

        #endregion Properties
    }
}