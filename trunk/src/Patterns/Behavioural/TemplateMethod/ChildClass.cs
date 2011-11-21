namespace Design.Patterns.Behavioural.TemplateMethod
{
    using System;

    public class ChildClass : ParentClass
    {
        #region Methods

        public override string WriteToday()
        {
            return DateTime.Today.ToString();
        }

        #endregion Methods
    }
}