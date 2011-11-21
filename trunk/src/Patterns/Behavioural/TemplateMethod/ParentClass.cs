namespace Design.Patterns.Behavioural.TemplateMethod
{
    public abstract class ParentClass
    {
        #region Methods

        public string Write()
        {
            return string.Format("Hello world. Today: {0}"
                , this.WriteToday());
        }

        public abstract string WriteToday();

        #endregion Methods
    }
}