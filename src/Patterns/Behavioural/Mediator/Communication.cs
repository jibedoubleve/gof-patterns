namespace Design.Patterns.Behavioural.Mediator
{
    public class Communication
    {
        #region Constructors

        public Communication(IUser left, IUser right)
        {
            this.Left = left;
            this.Right = right;
        }

        #endregion Constructors

        #region Properties

        public IUser Left
        {
            get;
            private set;
        }

        public IUser Right
        {
            get;
            private set;
        }
        public void Say(string msg)
        {
            this.Left.Message = string.Format("{0} says {1} to {2}"
                , this.Left.Name
                , msg
                , this.Right.Name);
        }
        #endregion Properties
    }
}