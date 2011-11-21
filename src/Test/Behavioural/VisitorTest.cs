namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.Visitor;

    using NUnit.Framework;

    [TestFixture]
    public class VisitorTest
    {
        #region Methods

        [Test]
        public void CanUserVisitor()
        {
            var employees = new Employees();
            employees.Add(new Clerk());
            employees.Add(new Manager());
            employees.Add(new President());

            var salary = new SalaryVisitor();
            employees.Visit(salary);
            Assert.AreEqual(4500, salary.Total);

            var vacation = new VacationVisitor();
            employees.Visit(vacation);
            Assert.AreEqual(60, vacation.Total);
        }

        #endregion Methods
    }
}