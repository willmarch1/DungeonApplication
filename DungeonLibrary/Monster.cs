using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //Fields
        private int _minDamage;
        private int _maxDamage;
        private string _description;

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= _maxDamage ? value : 1; }
        }
       
        //Properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }

       
        //Constructors (CTORS)
        public Monster(int block, int hitChance, string name, int maxLife, string description, int maxDamage) :base (block, hitChance, name, maxLife)
        {
            MaxDamage= maxDamage;
            Description = description;
        }
        //Methods
        public override string ToString()

        {
            string description = Description.ToString();
            return base.ToString() + $"Description: {description}";

        }



    }
}
