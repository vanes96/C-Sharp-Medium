using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Weapon
    {
        public float Cooldown { get; private set; }
        public int Damage { get; private set; }
        public bool IsReloading()
        {
            throw new NotImplementedException();
            // if (Cooldown...)
        }
    }

    class Movement
    {
        public float DirectionX { get; private set; }
        public float DirectionY { get; private set; }
        public float Speed { get; private set; }
    }

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
