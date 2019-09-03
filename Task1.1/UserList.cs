using System.Collections.Generic;
using System.Linq;

namespace Task1._1
{
    class UserList
    {
        private readonly List<User> _users;

        public User GetUserById(uint id)
        {
            return _users.Single(u => u.Id == id);
        }

        public User GetUserByName(string name)
        {
            return _users.Single(u => u.Name == name);
        }

        public IReadOnlyCollection<User> GetAllUsers()
        {
            return _users;
        }

        public IReadOnlyCollection<User> GetRicherUsers(uint n)
        {
            return _users.ToList().FindAll(u => u.Salary > n);
        }

        public IReadOnlyCollection<User> GetPoorerUsers(uint n)
        {
            return _users.ToList().FindAll(u => u.Salary < n);
        }

        public IReadOnlyCollection<User> GetRangeUsers(uint n1, uint n2)
        {
            return _users.ToList().FindAll(u => u.Salary >= n1 && u.Salary <= n2);
        }

        public UserList(IReadOnlyCollection<User> users)
        {
            if (_users == null)
                _users = new List<User>();

            _users.AddRange(users);
        }
    }
}
