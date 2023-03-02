using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

       public Monster() { }
        

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
            Monster r1 = new("Rabid Rat", block: 7, hitChance: 90, maxLife: 20, maxDamage: 4, minDamage: 0, description: "Ground Zero for the start of rabies in Rats, this one seeks revenge for the turmoil Cats have\ncaused Rats for centuries...");
            Monster r2 = new("Rabid Rat++", block: 8, hitChance: 90, maxLife: 24, maxDamage: 4, minDamage: 1, description: "Ground Zero for the start of rabies in Rats, this one seeks revenge for the turmoil Cats have\ncaused Rats for centuries...\n ***  ++ indicates buffed stats!  ***");

            Monster v1 = new("Vicious Vacuum", block: 8, hitChance: 85,  maxLife: 22, maxDamage: 5, minDamage: 1, description: "A sworn nemesis of the Cat, the Vicious Vacuum will stop at nothing to end the collection of shedded\nhair once and for all.");
            Monster v2 = new("Vicious Vacuum++", block: 8, hitChance:85, maxLife: 28, maxDamage: 6, minDamage: 6, description: "A sworn nemesis of the Cat, the Vicious Vacuum will stop at nothing to end the collection of shedded\nhair once and for all.\n ***  ++ indicates buffed stats!  ***");

            Monster l1 = new("Laserating Laser Pointer", block: 15, hitChance: 70, maxLife: 25, maxDamage: 6, minDamage: 1, description: "A quick enemy. Makes for a good match for a Cat, but can Charlie finally catch it?");
            Monster l2 = new("Laserating Laser Pointer", block: 15, hitChance: 75, maxLife: 25, maxDamage: 7, minDamage: 2, description: "A quick enemy. Makes for a good match for a Cat, but can Charlie finally catch it?\n ***  ++ indicates buffed stats!  ***");

            Monster g1 = new("Growling Gracie",block: 15, hitChance: 75, maxLife: 30, maxDamage: 7, minDamage: 4, description: "A vicious, mouth-foaming, eyes bulging, barking, determined to kill 4.8 pound Chihuahua.\nStill, somehowcute. DO NOT UNDERESTIMATE!");
            Monster g2 = new("Growling Gracie++", block: 20, hitChance: 85, maxLife: 35, maxDamage: 10, minDamage: 4, description: "A vicious, mouth-foaming, eyes bulging, barking, determined to kill 4.8 pound Chihuahua.\nStill, somehowcute. DO NOT UNDERESTIMATE!\n ***  ++ indicates buffed stats!  ***");

            Monster t1 = new("Terrorizing Toddler", block: 25, hitChance: 80, maxLife: 24, maxDamage: 4, minDamage: 1, description: "A tiny human with no awareness or boundaries. This toddler has crazy eyes and a smelly diaper.");
            Monster t2 = new("Terrorizing Toddler++", block: 25, hitChance: 85, maxLife: 30, maxDamage: 6, minDamage: 3, description: "A tiny human with no awareness or boundaries. This toddler has crazy eyes and a smelly diaper. \n ***  ++ indicates buffed stats!  ***");


            //Add monsters to a collection
            List<Monster> monsters = new()
            {
                r1,r1,r1,r1,r1,r1,r1, r1, r1, r1,r1, r1, r1, r1, r1,    
                r2,
                v1,v1,v1,v1,
                v2,
                l1,l1,l1,l1,
                l2,
                g1,g1,g1,g1,
                g2,
                t1,t1,t1,t1
            };

            //Pick one at random to place in our dungeon room 
            return monsters[new Random().Next(monsters.Count)];


        }
       
    }
}
