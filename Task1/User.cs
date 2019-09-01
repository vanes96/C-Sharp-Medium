using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        public string Name { get; }
        public uint Id { get; }
        public uint Salary { get; }
        public User(uint id, string name, uint salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }

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
        public UserList(string[] names, uint[] salaries, uint count)
        {
            _users = new List<User>();
            for (uint i = 0; i < count; i++)
                _users.Add(new User(i + 1, names[i], salaries[i]));
        }
    }
}
