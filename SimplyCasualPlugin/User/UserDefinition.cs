using BS_Utils.Gameplay;
using JetBrains.Annotations;

namespace SimplyCasualPlugin.User
{
    public class UserDefinition
    {
        public UserInfo UserProvider()
        { 
           return GetUserInfo.GetUserAsync().GetAwaiter().GetResult();
        }
    }
}