namespace Design.Patterns.Behavioural.Visitor
{
    public class Clerk : IEmployee
    {
        #region Constructors

        public Clerk()
        {
            this.Salary = 1000;
            this.Vacations = 21;
        }

        #endregion Constructors

        #region Properties

        public int Salary
        {
            get;
            private set;
        }

        public int Vacations
        {
            get;
            private set;
        }

        #endregion Properties
    }
}