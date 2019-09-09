using System.Collections.Generic;
using System.Linq;

namespace Task1._1
{
    class UserList
    {
        private readonly IEnumerable<User> _users;

        public User GetUserById(uint id)
        {
            return _users.Single(u => u.Id == id);
        }

        public User GetUserByName(string name)
        {
            return _users.Single(u => u.Name == name);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public IEnumerable<User> GetRicherUsers(uint n)
        {
            return _users.Where(u => u.Salary > n);
        }

        public IEnumerable<User> GetPoorerUsers(uint n)
        {
            return _users.Where(u => u.Salary < n);
        }

        public IEnumerable<User> GetRangeUsers(uint n1, uint n2)
        {
            return _users.Where(u => u.Salary >= n1 && u.Salary <= n2);
        }

        public UserList(IEnumerable<User> users)
        {
            if (_users == null)
                _users = new List<User>();

            (_users as List<User>).AddRange(users);
        }
    }
}
