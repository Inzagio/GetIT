using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfConsoleCraft
{
   
    class Monster
    {
        public int HealthPoints {get;}
        public string Name { get; }
        public int Damage { get; set; }

        public Monster(string name)
        {
            HealthPoints = 25;
            Name = name;
            Damage = Damage;
        }

       
    }
}
