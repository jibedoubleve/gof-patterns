namespace Design.Patterns.Behavioural.ChainOfResponsability
{
    public class Colonel : Soldier
    {
        #region Constructors

        public Colonel(ISoldier superior)
            : base(Level.Colonel)
        {
            this.Superior = superior;
        }

        #endregion Constructors
    }
}