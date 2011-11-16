namespace Design.Patterns.Behavioural.ChainOfResponsibility
{
    class General : Soldier
    {
        #region Constructors

        public General()
            : base(Level.General)
        {
            this.Superior = null;
        }

        #endregion Constructors
    }
}