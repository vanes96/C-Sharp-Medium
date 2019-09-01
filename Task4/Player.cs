namespace Task4
{
    class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Weapon Weapon { get; private set; }
        public Movement Movement { get; private set; }
        public void Move()
        {
            //Do move 
            // Movement.Do()
        }

        public void Attack()
        {
            //attack
            // If (Weapon.IsReloading()) ...
        }
    }
}
