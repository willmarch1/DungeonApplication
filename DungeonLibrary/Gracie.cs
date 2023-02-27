using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Gracie : Monster
    {
        public bool IsHungry { get; set; }
        public Gracie(string name, int block, int hitChance, int maxLife, string description, int maxDamage, int minDamage, bool isHungry)
            : base(name, block, hitChance, maxLife, description, maxDamage, minDamage)
        {
            IsHungry = isHungry;
        }

        public Gracie()
        {
            MaxLife = 30;
            MaxDamage = 10;
            Life = 30;
            MinDamage = 4;
            HitChance = 40;
            Block = 15;
            Name = "Growling Gracie";
            Description = "A vicious, mouth-foaming, eyes bulging, barking, determined to kill 4.8 pound Chihuahua. Still, somehow cute. DO NOT UNDERESTIMATE!";
            IsHungry = false;
        }
        public override string ToString()
        {
            return base.ToString() + (IsHungry ? "Hasn't eaten in three hours and NOT happy about it." : "Just had a couple treats, full but not satisfied");
        }

        public override int CalculateHitChance()
        {
            int calculatedHitchance = HitChance;
            if (IsHungry)
            {
                calculatedHitchance = 55;
            }
            return calculatedHitchance;
        }
        

    }
}
