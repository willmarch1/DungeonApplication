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
        public Monster(string name, int block, int hitChance, int maxLife, string description, int maxDamage, int minDamage) :base (block, hitChance, name, maxLife)
        {
            MaxDamage= maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        //Methods
        public override string ToString()

        {
            string description = Description.ToString();
            return base.ToString() + $"Description: {description}";

        }
        public override int CalculateDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }

        public static Monster GetMonster()
        {
            //Create a variety of monsters
            Monster m1 = new("White Rabbit", block: 20, hitChance: 50, maxLife: 25, maxDamage: 8, minDamage: 2, description: "Thats not ordinary rabbit! Look at the bones!");
            Monster m2 = new("Dracula", block: 8, hitChance: 70,  maxLife: 30, maxDamage: 8, minDamage: 1, description: "Father of all the undead.!");
            Monster m3 = new("Mikey", block: 10, hitChance: 50, maxLife: 25, maxDamage: 4, minDamage: 1, description: "He is no longer a teenager, he is still a mutant turtle.");
            Monster m4 = new("Smaug",block: 20, hitChance: 65, maxLife: 20, maxDamage: 15, minDamage: 1, description: "The last great dragon.");



            //Add monsters to a collection
            List<Monster> monsters = new()
            {
                m1,
                m2,m2,m2,m2,//gives m2 4x the chance of showing up then any other monster
                m3,
                m4,
            };

            //Pick one at random to place in our dungeon room 
            return monsters[new Random().Next(monsters.Count)];


        }

    }
}
