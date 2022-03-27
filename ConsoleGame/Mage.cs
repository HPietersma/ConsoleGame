using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Mage : superClasses.Enemy
    {
        private int magicDamage;
        private int range;

        public Mage(int magicDamage, int range, string name, float health, float damage) : base (name, health, damage)
        {
            this.magicDamage = magicDamage;
            this.range = range;
        }

    }
}
