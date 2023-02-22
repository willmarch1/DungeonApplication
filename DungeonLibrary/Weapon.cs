using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public
    public class Weapon
    {
        //Fields
        /*
         * int mindamage - cannot be less than zero or greater than max damage -do last in property
         * int for max damage - - cannot be less than 0 - assign first in ctor - do last in property
         * string for the name  of weapon
         * int for bonusHitChance
         * bool isTwoHanded
         */
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;



        //Properties 1 for each field 
        public string Name
        {
            get { return _name; }
            set { _name = value;}
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
       



        //Constructors (CTORS)
        // 1 fully qualified and one default/unqualified
        public Weapon(string name, int bonusHitChance, bool isTwoHanded, int minDamage, int maxDamage, WeaponType type)
        {
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Type = type;
        }
        public Weapon() { }

        
        
       


        //Methods
        //Nicely formatted ToString() override 
        public override string ToString()
        {
            return $"Weapon: {Name}\n" +
                   $"Bonus Hit Chance: {BonusHitChance}\n" +
                   $"Is Two Handed: {IsTwoHanded}\n" +
                   $"Min Dmg: {MinDamage}\n" +
                   $"Max Dmg: {MaxDamage}\n" +
                   $"Weapon Type {Type}\n";
                  
        }
    }
}
