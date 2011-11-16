namespace Design.Patterns.Structural.Bridge
{
    using System.Collections.Generic;

    public class Counter
    {
        #region Fields

        private IMultiplicationTable table;

        #endregion Fields

        #region Constructors

        public Counter(IMultiplicationTable table)
        {
            this.table = table;
        }

        #endregion Constructors

        #region Methods

        public int[] Start()
        {
            List<int> result = new List<int>();
            this.table.Reset();

            for (int i = 0; i < 10; i++) { result.Add(this.table.Next()); }

            return result.ToArray();
        }

        #endregion Methods
    }
}