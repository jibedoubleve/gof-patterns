namespace Design.Patterns.Behavioural.Mediator
{
    using System.Collections.Generic;

    public class ChatRoom : IChatRoom
    {
        #region Fields

        private List<IUser> users = new List<IUser>();

        #endregion Fields

        #region Methods

        public void NotifyAll(string msg)
        {
            foreach (var user in this.users)
            {
                user.Message = msg;
            }
        }

        public void Register(IUser user)
        {
            this.users.Add(user);
        }

        #endregion Methods
    }
}