using Common.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Common.Storage
{
    public class UserStorage : KeyValueStorage<User>
    {
        public UserStorage()
        {
            items = new Dictionary<string, User>();
        }

        public User AddNew(User newUser)
        {
            items.Add(newUser.Id, newUser);
            return newUser;
        }

        public override User FindByName(string name)
        {
            return items.FirstOrDefault(item => item.Value.Username == name).Value;
        }
    }
}
