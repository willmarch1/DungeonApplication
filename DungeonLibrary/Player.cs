using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //Fields

        //Properties
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }


        //Constructors (CTORS)
        public Player(int block, int hitChance, string name, int maxLife, Race playerRace, Weapon equippedWeapon) :base(block, hitChance, name, maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Human:
                    break;
                case Race.Robot:
                    break;
                case Race.Alien:
                    break;
                case Race.Goblin:
                    HitChance += 2;
                    break;
                case Race.Animal:
                    break;
                default:
                    break;
            }
            #endregion
        }

        public Player()
        {

        }
        //Methods
        public override string ToString()
        {
            //create a string, switch on Player Race and write some description about that race
            string description = PlayerRace.ToString();
            return base.ToString() + $"\nWeapon: {EquippedWeapon}\n" +
                $"Description: {description}";
        }
        public override int CalculateDamage()
        {
            //Create a random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //return the damage
            return damage;
        }

        public override int CalculateHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

    }
}
