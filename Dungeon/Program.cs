﻿using Microsoft.Win32.SafeHandles;
using System.Threading.Tasks.Sources;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.Title = "DUNGEON OF DOOM!";
            Console.WriteLine("Your journey begins...\n");
            #endregion

            #region Player Creation
            //TODO Variable to keep score
            int score = 0;
            //TODO Weapon creation

            //TODO Player object creation
            #endregion

            #region Main Game Loop
            bool exit = false;
            int innerCount = 0;
            int outerCount = 0;
            do
            {
                //TODO Generate a random room
                Console.WriteLine(GetRoom());
                //TODO Select a random monster to inhabit the room
                Console.WriteLine("Here's a monster!");
                #region Gameplay Menu Loop
                bool reload = false;            
                do
                {
                    Console.WriteLine("Outer: " + ++outerCount);
                    Console.WriteLine("Inner: " + ++innerCount);
                    //TODO Gameplay menu
                    #region Menu
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO Combat
                            Console.WriteLine("ATTACK!");
                            break;

                        case ConsoleKey.R:
                            //TODO Attack of opportunity
                            Console.WriteLine("Run away!");
                            reload = true;
                            break;

                        case ConsoleKey.P:
                            //TODO Player Info
                            Console.WriteLine("Player Info: ");
                            break;

                        case ConsoleKey.M:
                            //TODO Monster Info
                            Console.WriteLine("Monster Info ");
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            //reload = true;
                            break;
                        default:
                            break;
                    }
                    #endregion
                    //TODO check player life
                } while (!reload && !exit); //if either exit or reload, the inner loop will exit
                #endregion
            } while (!exit); // if exit is true, the outer loop will exit as well

            //Show the score
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));
            #endregion
        }//end Main()

        private static string GetRoom()
        {
            string[] rooms =
            {
                 "1", "2", "3", "4", "5",
            };

            Random rand = new Random();

            int index = rand.Next(rooms.Length);


            string room = rooms[index];

            return room;
            //possible refactor
            //return rooms[new Random().Next(rooms.Length)];
        }

    }//end class
}//end namespace