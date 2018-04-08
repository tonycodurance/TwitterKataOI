using System;
using System.Collections.Generic;

namespace TwitterKataOI
{
    public class UserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            if (_users == null)
                _users = new List<User>();
        }

        public virtual void Add(User user)
        {
            _users.Add(user);
        }

        public List<User> GetUsers()
        {
            return _users;
        }
    }
}