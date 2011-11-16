namespace Design.Patterns.Structural.Adapter
{
    public class Average
    {
        #region Fields

        private Division division = new Division();
        private Sum sum = new Sum();

        #endregion Fields

        #region Methods

        public void Add(int item)
        {
            this.sum.Add(item);
        }

        public float Calculate()
        {
            this.division.OperatorA = sum.Calculate();
            this.division.OperatorB = sum.Count;
            return this.division.Calculate();
        }

        #endregion Methods
    }
}