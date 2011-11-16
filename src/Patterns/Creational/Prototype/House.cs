namespace Design.Patterns.Creational.Prototype
{
    public class House : IPrototype<House>
    {
        #region Constructors

        public House(string name, int doorCount, int windowCount)
        {
            this.Name = name;
            this.DoorCount = doorCount;
            this.WindowCount = windowCount;
        }

        #endregion Constructors

        #region Properties

        public int DoorCount
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public int WindowCount
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public House Clone()
        {
            return new House(this.Name, this.DoorCount, this.WindowCount);
        }

        #endregion Methods
    }
}