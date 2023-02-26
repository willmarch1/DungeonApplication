using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Vacuum : Monster
    {
        public bool IsPluggedIn { get; set; }

        public Vacuum(string name, int block, int hitChance, int maxLife, string description, int maxDamage, int minDamage, bool isPluggedIn)
            : base(name, block, hitChance, maxLife, description, maxDamage, minDamage)
        {
            IsPluggedIn = isPluggedIn;
        }
        public Vacuum()
        {
            MaxLife = 15;
            MaxDamage = 5;
            Life= 15;
            MinDamage = 1;
            HitChance = 40;
            Block = 8;
            Name = "Vicious Vacuum";
            Description = "A sworn nemesis of the Cat, the Vicious Vacuum will stop at nothing to end the collection" +
                "of shedded hair once and for all. The V.V. doesn't need to be plugged in to operate, but use caution" +
                "if it is.";
            IsPluggedIn = false;
        }
        public override string ToString()
        {
            return base.ToString() + (IsPluggedIn ? "Electrical current is ACTIVE" : "No electrical current detected");
        }
        public override int CalculateHitChance()
        {
            int calculatedHitChance = HitChance;
            if (IsPluggedIn)
            {
                calculatedHitChance = 50;
            }
            return calculatedHitChance;
        }







    }
}
