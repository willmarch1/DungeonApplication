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
            Monster m1 = new("Rabid Rat", block: 7, hitChance: 35, maxLife: 10, maxDamage: 4, minDamage: 0, description: "Ground Zero for the start of rabies in Rats, this one seeks revenge for the turmoil Cats have caused Rats for centuries...");
            Monster m2 = new("Vicious Vacuum", block: 8, hitChance: 40,  maxLife: 15, maxDamage: 5, minDamage: 1, description: "A sworn nemesis of the Cat, the Vicious Vacuum will stop at nothing to end the collection of shedded hair once and for all. The V.V. doesn't need to be plugged in to operate, but use caution if it is.");
            Monster m3 = new("Laserating Laser Pointer", block: 15, hitChance: 45, maxLife: 25, maxDamage: 7, minDamage: 2, description: "A quick enemy. Makes for a good match for the Cat, but can the Cat finally catch it?");
            Monster m4 = new("Growling Gracie",block: 15, hitChance: 40, maxLife: 30, maxDamage: 10, minDamage: 4, description: "A vicious, mouth-foaming, eyes bulging, barking, determined to kill 4.8 pound Chihuahua. Still, somehow cute. DO NOT UNDERESTIMATE!");
            



            //Add monsters to a collection
            List<Monster> monsters = new()
            {
                m1,
                m2, //m2,m2,m2,//gives m2 4x the chance of showing up then any other monster
                m3,
                m4,
            };

            //Pick one at random to place in our dungeon room 
            return monsters[new Random().Next(monsters.Count)];


        }

    }
}
