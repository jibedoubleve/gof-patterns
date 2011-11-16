namespace Design.Patterns.Creational.Builder
{
    public class Garage
    {
        #region Constructors

        public Garage(string name)
        {
            this.Name = name;
        }

        #endregion Constructors

        #region Properties

        public string Name
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public Vehicle Build(IBuilder builder)
        {
            return builder.Build(this.Name);
        }

        #endregion Methods
    }
}