namespace Design.Patterns.Behavioural.Visitor
{
    public class President : IEmployee
    {
        #region Constructors

        public President()
        {
            this.Salary = 2000;
            this.Vacations = 19;
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