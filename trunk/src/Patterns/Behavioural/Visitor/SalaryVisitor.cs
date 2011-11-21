namespace Design.Patterns.Behavioural.Visitor
{
    public class SalaryVisitor : IVisitor
    {
        #region Properties

        public int Total
        {
            get; private set;
        }

        #endregion Properties

        #region Methods

        public void Visit(IEmployee visitee)
        {
            this.Total += visitee.Salary;
        }

        #endregion Methods
    }
}