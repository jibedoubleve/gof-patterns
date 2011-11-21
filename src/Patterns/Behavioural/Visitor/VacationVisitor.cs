namespace Design.Patterns.Behavioural.Visitor
{
    public class VacationVisitor : IVisitor
    {
        #region Properties

        public int Total
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public void Visit(IEmployee visitee)
        {
            this.Total += visitee.Vacations;
        }

        #endregion Methods
    }
}