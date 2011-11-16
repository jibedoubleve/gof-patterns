namespace Design.Test.Creational
{
    using Design.Patterns.Creational.Builder;

    using NUnit.Framework;

    [TestFixture]
    public class BuilderTest
    {
        #region Methods

        [Test]
        public void CanBuildCar()
        {
            string name = "mon garage";

            var builder = new CarBuilder();
            var car = new Garage(name).Build(builder);

            Assert.AreEqual("car", car.Name.ToLower());
            Assert.AreEqual(name, car.Garage);
            Assert.AreEqual(4, car.WheelCount);
        }

        [Test]
        public void CanBuildMotorbike()
        {
            string name = "mon garage";

            var builder = new MotorbikeBuilder();
            var motorbike = new Garage(name).Build(builder);

            Assert.AreEqual("motorbike", motorbike.Name.ToLower());
            Assert.AreEqual(name, motorbike.Garage);
            Assert.AreEqual(2, motorbike.WheelCount);
        }

        #endregion Methods
    }
}