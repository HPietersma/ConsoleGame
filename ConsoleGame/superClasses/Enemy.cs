using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.superClasses
{
    internal class Enemy
    {
        protected string name;
        protected float health;
        protected float damage;

        public Enemy(string name, float health, float damage)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }
    }
}
