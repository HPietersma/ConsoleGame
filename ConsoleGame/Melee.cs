using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Melee : superClasses.Enemy
    {
        public Melee (string name, float health, float damage) : base (name, health, damage)
        {
            this.name = name;
            this.health = health;   
            this.damage = damage;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetDamage()
        {
            return damage;
        }

        public void SetHealth(float damage)
        {
            health -= damage;
        }
    }
}
