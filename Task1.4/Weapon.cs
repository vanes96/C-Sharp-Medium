using System;

namespace Task1._4
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
}
