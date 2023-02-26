using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace Dungeon
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dungeon Test Harness\n\n");
            //Build and test the functionality of our library
            //Build and test a weapon
            //build and test a character - include CalcBlock(), CalcHitChance(), CalcDamage()
            Console.WriteLine("Weapons\n");
            Weapon w1 = new Weapon();

            w1.MaxDamage= 6;
            w1.MinDamage= 1;
            w1.IsTwoHanded = false;
            w1.BonusHitChance= 1;
            w1.Name = "Spiked Club";

            Console.WriteLine(w1); // can just do this instead of the CW below

            Console.WriteLine($"{w1.Name}\n" + 
                              $"Minimum damage: {w1.MinDamage}. Maximum Damage: {w1.MaxDamage}.\n" +
                              $"Bonus Hit Chance: {w1.BonusHitChance}.\n" +
                              $"2-handed weapon: {w1.IsTwoHanded}");
            
            Console.WriteLine("\n\n");


            Console.WriteLine("Characters\n");
            Player p1= new Player();

            p1.Name = "Charlie the Cat";
            p1.MaxLife = 50;
            p1.Life = 50;
            p1.HitChance = 70;
            p1.Block = 15;
            p1.PlayerRace = Race.Animal;
            p1.EquippedWeapon = w1;

            Console.WriteLine($"{p1.Name}\n" +
                              $"Max Life: {p1.MaxLife}\n" +
                              $"Hit Chance: {p1.HitChance}\n" +
                              $"Block: {p1.Block}\n");

            Console.WriteLine($"{p1.Name} has a block of {p1.CalculateBlock()}\n");
            Console.WriteLine($"{p1.Name} Hit Chance: {p1.CalculateHitChance()}\n");
            Console.WriteLine($"{p1.Name} Damage: {p1.CalculateDamage()}\n");


            Console.WriteLine(Monster.GetMonster());
            Monster monster = Monster.GetMonster();

            Console.WriteLine("\n\n ***** COMBAT *****\n\n");
            Combat.DoBattle(p1, monster);



        }
    }
}
