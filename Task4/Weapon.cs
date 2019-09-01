using System;

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
}
