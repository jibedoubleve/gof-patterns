namespace Design.Patterns.Behavioural.ChainOfResponsability
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