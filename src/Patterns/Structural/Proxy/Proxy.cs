namespace Design.Patterns.Structural.Proxy
{
    public class Proxy
    {
        #region Fields

        private Feature feature;

        #endregion Fields

        #region Constructors

        public Proxy(Feature feature)
        {
            this.feature = feature;
        }

        #endregion Constructors

        #region Methods

        public string GetHello()
        {
            return feature.GetHello();
        }

        #endregion Methods
    }
}