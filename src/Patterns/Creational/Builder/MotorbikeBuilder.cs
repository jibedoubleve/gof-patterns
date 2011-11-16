namespace Design.Patterns.Creational.Builder
{
    public class MotorbikeBuilder : IBuilder
    {
        #region Methods

        public Vehicle Build(string garage)
        {
            return new Vehicle()
            {
                Name = "Motorbike",
                Garage = garage,
                WheelCount = 2,
            };
        }

        #endregion Methods
    }
}