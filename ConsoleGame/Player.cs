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
        private int flasks;
        private int flaskHealing;

        public Player (string name, float health, float damage, int flasks, int flaskHealing)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.flasks = flasks;
            this.flaskHealing = flaskHealing;
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

        public int GetFlasks()
        {
            return flasks;
        }

        public int GetFlaskHealing()
        {
            if (flasks > 0)
            {
                return flaskHealing;
            }
            else
            {
                return 0;
            }
        }

        public void SetHealth(float damage)
        {
            health -= damage;
        }

        public void SetFlasks()
        {
            if (flasks > 0)
            {
               flasks -= 1;
               health += flaskHealing;
            }
        }
    }
}
