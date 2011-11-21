namespace Design.Patterns.Behavioural.Visitor
{
    public class Manager : IEmployee
    {
        #region Constructors

        public Manager()
        {
            this.Salary = 1500;
            this.Vacations = 20;
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