namespace Design.Patterns.Creational.Singletton
{
    using System;

    public class Unique
    {
        #region Fields

        private static readonly Unique instance = new Unique();

        #endregion Fields

        #region Constructors

        private Unique()
        {
            //Every time the ctor is called, a new guid is created
            this.Guid = Guid.NewGuid();
        }

        #endregion Constructors

        #region Properties

        public static Unique Instance
        {
            get { return instance; }
        }

        public Guid Guid
        {
            get;
            private set;
        }

        #endregion Properties
    }
}