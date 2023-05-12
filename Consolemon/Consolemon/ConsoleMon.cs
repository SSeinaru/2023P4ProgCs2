using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolemon
{
    internal class ConsoleMon
    {
        internal int health = 200;
        internal int energy = 12;
        internal string name = "Joe";

        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }
        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
    
}
