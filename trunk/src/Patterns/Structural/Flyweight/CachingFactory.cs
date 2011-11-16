namespace Design.Patterns.Structural.Flyweight
{
    using System.Collections.Generic;

    public class CachingFactory
    {
        #region Fields

        private static Dictionary<string, CachedUser> repository = new Dictionary<string, CachedUser>();

        #endregion Fields

        #region Methods

        public static IUser GetUser(string id)
        {
            if (repository.ContainsKey(id))
            {
                repository[id].IsFromCache = true;
                return repository[id];
            }
            else
            {
                var user = new CachedUser(id);
                user.IsFromCache = false;
                repository.Add(id, user);
                return user;
            }
        }

        #endregion Methods
    }
}