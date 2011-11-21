namespace Design.Patterns.Behavioural.Visitor
{
    using System.Collections.Generic;

    public class Employees
    {
        #region Fields

        private List<IEmployee> employees = new List<IEmployee>();

        #endregion Fields

        #region Methods

        public void Add(IEmployee employee)
        {
            this.employees.Add(employee);
        }

        public void Visit(IVisitor visitor)
        {
            foreach (var employee in this.employees)
            {
                visitor.Visit(employee);
            }
        }

        #endregion Methods
    }
}