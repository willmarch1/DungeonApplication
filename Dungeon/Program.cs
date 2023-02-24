using DungeonLibrary;

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
            // Weapon creation
            //Possible Expansion - Display a list of pre-created weapons and let them pick one, or pick one for them randomly
            Weapon sword = new Weapon("Long Sword", 10, false, 1, 8,WeaponType.Sword);
            // Player object creation
            //Potential Expansion - allow them to enter their own name
            //Show them possible races and let them pick one
            Player player = new(5, 70, "Leeroy Jenkins", 40, Race.Goblin, sword);
            #endregion

            #region Main Game Loop
            bool exit = false;
           
            do
            {
                //TODO Generate a random room
                Console.WriteLine(GetRoom());
                //Select a random monster to inhabit the room
                Monster monster = Monster.GetMonster();
                Console.WriteLine($"In this room {monster.Name}!");
                #region Gameplay Menu Loop
                bool reload = false;            
                do
                {
                    //Console.WriteLine("Outer: " + ++outerCount);
                    //Console.WriteLine("Inner: " + ++innerCount);
                    // Gameplay menu
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
                            // Combat
                            //Potential expansion : Weapon/race bonus attack
                            //if race == darkelf -> player.DoAttack(monster)
                            Combat.DoBattle(player, monster);
                            //check if the monster is dead
                            if (monster.Life <= 0)
                            {
                                //Expansion - combat rewards. money, health, whatever
                                Console.ForegroundColor= ConsoleColor.Green;
                                Console.WriteLine($"\nYou killed {monster.Name}!");
                                Console.ResetColor();
                                //flip the inner loop bool to true to get a new room and new monster
                                reload = true;

                                score++;
                            }
                            break;

                        case ConsoleKey.R:
                            // Attack of opportunity
                            Console.WriteLine("Run away!");
                            Console.WriteLine($"{monster.Name} attacks as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();//formatting
                            reload = true;//new room, new monster
                            break;

                        case ConsoleKey.P:
                            // Player Info
                            Console.WriteLine("Player Info: ");
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            // Monster Info
                            Console.WriteLine("Monster Info ");
                            Console.WriteLine(monster);
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
                    // check player life
                    if (player.Life <=0)
                    {
                        Console.WriteLine("Dude...You died.\a");
                        exit = true;
                    }

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