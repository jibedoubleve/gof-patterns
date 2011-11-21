
namespace Design.Patterns.Behavioural.Visitor
{
    public class VacationVisitor : IVisitor
    {
        #region IVisitor Members

        public void Visit(IEmployee visitee)
        {
            this.Total += visitee.Vacations;
        }
        public int Total
        {
            get;
            private set;
        }
        #endregion
    }
}
