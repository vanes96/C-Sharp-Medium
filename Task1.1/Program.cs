namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            User ivan = new User(1, "Ivan", 500), petr = new User(2, "Petr", 301), olga = new User(3, "Olga", 450), dariana = new User(4, "Dariana", 220);
            UserList users = new UserList(new User[] { ivan, petr, olga, dariana });

            User user1 = users.GetUserById(1);
            User user2 = users.GetUserByName("Petr");
            var allUsers = users.GetAllUsers();
            var richUsers = users.GetRicherUsers(300);
            var poorUsers = users.GetPoorerUsers(300);
            var rangeUsers = users.GetRangeUsers(250, 460);
        }
    }
}
