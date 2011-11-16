namespace Design.Patterns.Structural.Adapter
{
    using System.Collections.Generic;

    public class Sum
    {
        #region Fields

        private List<int> values = new List<int>();

        #endregion Fields

        #region Properties

        public int Count
        {
            get { return this.values.Count; }
        }

        #endregion Properties

        #region Methods

        public void Add(int item)
        {
            this.values.Add(item);
        }

        public int Calculate()
        {
            int total = 0;
            foreach (var value in this.values)
            {
                total += value;
            }
            return total;
        }

        #endregion Methods
    }
}