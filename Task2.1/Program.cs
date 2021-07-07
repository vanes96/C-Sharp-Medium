using System;

namespace Task2._1
{
    class Program
    {
        static void Main (string[] args)
        {
            Combat cmb = new Combat();
            cmb.TakeDamage(4);
            Console.ReadKey();
        }

        class Combat : Human
        {
            private int _armor;

            protected override void ReceiveDamage(int damage)
            {
                ReduceHealth(damage - _armor);
                Console.WriteLine("Наследник");
            }    
        }

        class Human
        {
            private int _health;
            private int _agility;

            private void Die()
            {
                Console.WriteLine("Я умер");
            }

            protected void ReduceHealth(int deltaHealth)
            {
                _health -= deltaHealth;
            }

            protected virtual void ReceiveDamage(int damage)
            {
                ReduceHealth(damage / _agility);
                Console.WriteLine("Родитель");
            }

            public void TakeDamage(int damage)
            {
                ReceiveDamage(damage);

                if (_health <= 0)
                    Die();
            }
        }
    }
}
