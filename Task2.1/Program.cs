using System;

namespace Task2._1
{
    class Program
    {
        class Combat : Human
        {
            private int _armor;

            public override void TakeDamage(int damage)
            {
                _health -= damage - _armor;

                if (_health <= 0)
                    Die();
            }
        }

        class Human
        {
            protected int _health;
            private int _agility;

            protected void Die()
            {
                Console.WriteLine("Я умер");
            }

            public virtual void TakeDamage(int damage)
            {
                _health -= damage / _agility;

                if (_health <= 0)
                    Die();
            }
        }
    }
}
