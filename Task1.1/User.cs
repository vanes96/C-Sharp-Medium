namespace Task1._1
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
}
