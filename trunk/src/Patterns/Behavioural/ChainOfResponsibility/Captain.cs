namespace Design.Patterns.Behavioural.ChainOfResponsibility
{
    public class Captain : Soldier
    {
        #region Constructors

        public Captain(ISoldier superior)
            : base(Destination.Captain)
        {
            this.Superior = superior;
        }

        #endregion Constructors
    }
}