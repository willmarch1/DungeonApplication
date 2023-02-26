using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class LaserPointer : Monster
    {
        public LaserPointer(string name, int block, int hitChance, int maxLife, string description, int maxDamage, int minDamage)
             : base(name, block, hitChance, maxLife, description, maxDamage, minDamage)
        {

        }

        public LaserPointer()
        {
            MaxLife = 25;
            MaxDamage = 7;
            Life = 25;
            MinDamage = 2;
            HitChance = 45;
            Block = 15;
            Name = "Lacerating Laser Pointer";
            Description = "A quick enemy. Makes for a good match for the Cat, but can the Cat finally catch it?";
        }

        public override string ToString()
        {
            return base.ToString();
        }






    }
}
