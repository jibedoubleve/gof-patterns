namespace Design.Patterns.Creational.Builder
{
    public class CarBuilder : IBuilder
    {
        #region Methods

        public Vehicle Build(string garage)
        {
            return new Vehicle()
            {
                Name = "Car",
                Garage = garage,
                WheelCount = 4,
            };
        }

        #endregion Methods
    }
}