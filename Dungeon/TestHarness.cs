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

            w1.MinDamage= 1;
            w1.MaxDamage= 6;
            w1.IsTwoHanded = false;
            w1.BonusHitChance= 1;
            w1.Name = "Spiked Club";

            Console.WriteLine(w1); // can jusr do this instead of the CW below

            Console.WriteLine($"{w1.Name}\n" + 
                              $"Minimum damage: {w1.MinDamage}. Maximum Damage: {w1.MaxDamage}.\n" +
                              $"Bonus Hit Chance: {w1.BonusHitChance}.\n" +
                              $"2-handed weapon: {w1.IsTwoHanded}");
            Console.WriteLine("\n\n");
            Console.WriteLine("Characters\n");
            Character c1= new Character();

            c1.Name = "Charlie the Cat";
            c1.Life = 25;
            c1.MaxLife = 25;
            c1.HitChance = 3;
            c1.Block = 5;

            Console.WriteLine($"{c1.Name}\n" +
                              $"Life: {c1.Life}\n" +
                              $"Max Life: {c1.MaxLife}\n" +
                              $"Hit Chance: {c1.HitChance}\n" +
                              $"Block: {c1.Block}\n");

            Console.WriteLine($"{c1.Name} has a block of {c1.CalculateBlock()}\n");
            Console.WriteLine($"{c1.Name} Hit Chance: {c1.CalculateHitChance()}\n");
            Console.WriteLine($"{c1.Name} Damage: {c1.CalculateDamage()}\n");




        }
    }
}
