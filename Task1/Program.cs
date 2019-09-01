namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1 example
            UserList users = new UserList(new string[] {"Ivan", "Petr", "Olga", "Anna", "Dariana" }, new uint[] { 500, 300, 450, 200, 220 }, 5);

            User user1 = users.GetUserById(1);
            User user2 = users.GetUserByName("Petr");
            var allUsers = users.GetAllUsers();
            var richUsers = users.GetRicherUsers(300);
            var poorUsers = users.GetPoorerUsers(300);
            var rangeUsers = users.GetRangeUsers(250, 460);
        }
    }
}
