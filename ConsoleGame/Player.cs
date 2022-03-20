using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Player
    {
        private string name;
        private float health;
        private float damage;

        public Player (string name, float health, float damage)
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

        public float SetHealth(float damage)
        {
            health -= damage;
            return health;
        }
    }
}
