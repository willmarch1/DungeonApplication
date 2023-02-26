using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class RabidRat : Monster
    {
        public bool IsRatty { get; set; }
        public RabidRat(string name, int block, int hitChance, int maxLife, string description, int maxDamage, int minDamage, bool isRatty)
            : base(name, block, hitChance, maxLife, description, maxDamage, minDamage)
        {
            IsRatty = isRatty;
        }

        public RabidRat()
        {
            MaxLife = 10;
            MaxDamage = 4;
            Life = 10;
            MinDamage = 0;
            HitChance = 35;
            Block = 7;
            Name = "Rabid Rat";
            Description = "Ground Zero for the start of rabies in rats, this one seeks revenge for the turmoil" +
                "Cats have caused rats for centuries...";
            IsRatty = false;
        }
        public override string ToString()
        {
            return base.ToString() + (IsRatty ? "Feeling avengeful, wants blood" : "Just woke up, but still mad");
        }
        public override int CalculateBlock()
        {
            int calculatedBlock = Block;
            if (IsRatty)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}
