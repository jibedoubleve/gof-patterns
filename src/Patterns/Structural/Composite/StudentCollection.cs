namespace Design.Patterns.Structural.Composite
{
    using System.Collections.Generic;

    public class StudentCollection : IPresentation
    {
        #region Fields

        private List<Student> students = new List<Student>();

        #endregion Fields

        #region Methods

        public void Add(Student student)
        {
            this.students.Add(student);
        }

        public string SayMyName()
        {
            var result = string.Empty;
            foreach (var student in this.students)
            {
                result += student.SayMyName() + " | ";
            }
            return result;
        }

        #endregion Methods
    }
}