using DungeonLibrary;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.Title = "Charlie's Challenges";
            Console.WriteLine("\t\t\t\t====== Welcome to Charlie's Challenges ======" + @"
                                                                        .--.
                                                                        `.  \
                                                                            \  \
                                                                            .  \
                                                                            :   .
                                                                            |    .
                                                                            |    :
                                                                            |    |
                            ..._  ___                                       |    |
                            `."""".`''''""""--..___                              |    |
                            ,-\  \             """"-...__         _____________/    |
                            / ` "" '                    `""""""""""""""""                  .
                            \                                                      L
                            (>                                                      \
                            /                                                         \
                            \_    ___..---.                                            L
                            `--'         '.                                           \
                                            .                                           \_
                                        _/`.                                           `.._
                                        .'     -.                                             `.
                                    /     __.-Y     /''''''-...___,...--------.._            |
                                    /   _.""    |    /                ' .      \   '---..._    |
                                    /   /      /    /                _,. '    ,/           |   |
                                    \_,'     _.'   /              /''     _,-'            _|   |
                                            '     /               `-----''               /     |
                                            `...-'                                       `...-' ");
            Console.Write("Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("Charlie is a cat who has it all, but it wasn't always that way...Abandoned at an extremely young age, Charlie had to\nfight for his well-being." +
                " He learned to take advantage of the smallest opportunites, navigate his way through the\nworld with eyes in the back of his head, and overcome " +
                "the toughest circumstances. His struggles as a youth shaped him\ninto a Cat worth being.\n" +
                "\nYears go by, and after overcoming adversity, Charlie now lives like royalty. He lives in a palace with cat treat\nfountains, cat nip gardens, " +
                "and cat trees at every window with views he never thought he'd get to have.\nThat is... until tragedy strikes! Menacing forces have invaded Charlie's palace" +
                " and threaten his peaceful way of life.\nCharlie fought too hard to overcome adversity to let these forces take him down.\n\n\t\t\tCan you complete Charlie's Challenges and lead" +
                " him back to the life of peace?\n" + @"

                                       
                                        .__....._             _.....__,
                                            ."": o :':         ;': o :"".
                                            `. `-' .'.       .'. `-' .'
                                            `---'             `---'

                                    _...----...      ...   ...      ...----..._
                                .-'__..-""""'----    `.  `""`  .'    ----'""""-..__`-.
                                '.-'   _.--""""""'       `-._.-'       '""""""--._   `-.`
                                '  .-""'                  :                  `""-.  `
                                '   `.              _.'""'._              .'   `
                                        `.       ,.-'""       ""'-.,       .'
                                        `.                           .'
                                            `-._                   _.-'
                                                `""'--...___...--'""`");
            Console.Write("Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Player Creation
            //TODO Variable to keep score
            int score = 0;
            int monstersKilled = 0;
            // Weapon creation
            //Possible Expansion - Display a list of pre-created weapons and let them pick one, or pick one for them randomly
            Weapon claws = new("Charlie's Extendable Wolverine-like Claws", 10, true, 3, 8,WeaponType.Claws);
            Weapon teeth = new("Charlie's custom made mouthguard with Knives as teeth", 15, false, 4, 10, WeaponType.Teeth_Knives);
            Weapon whip = new("Charlie attaches an electric Whip to his tail", 20, false, 6, 10, WeaponType.Whip);
            //Choose weapon loop
            bool chosen = false;
            do
            {
                Console.WriteLine("Charlie has prepared for this moment. He knew the enemies of his past would be jealous of his success.\n");
                Console.Write("Choose a weapon for Charlie to wield: \n" +
                               "[C] === Charlie's Extendable Wolverine-like Claws\n\n" +
                               "[T] === Charlie's custom made mouthguard with Knives as teeth\n\n" +
                               "[W] === Charlie attaches an electric Whip to his tail\n\n");
                ConsoleKey userWeapon = Console.ReadKey(true).Key;
                switch (userWeapon)
                {
                    case ConsoleKey.C:
                        Console.WriteLine($"You chose {claws}");
                        chosen = true;
                        break;
                    case ConsoleKey.T:
                        Console.WriteLine($"You chose {teeth}");
                        chosen = true;
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine($"You chose {whip}");
                        chosen = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input, choose a valid weapon.");
                        break;
                }
            } while (!chosen);
            
            // Player object creation
            //Potential Expansion - allow them to enter their own name
            //Show them possible races and let them pick one
            Player player = new Player(20, 70, "Charlie The Cat", 50, Race.Animal, claws);
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
                                Console.WriteLine($"\nYou killed {monster.Name}! Charlie celebrates with cat nip which restores some health.");
                                Console.ResetColor();
                                player.Life += monster.Life / 4;
                                score += monster.MaxLife - (player.MaxLife - player.Life);
                                monstersKilled++;
                                //flip the inner loop bool to true to get a new room and new monster
                                reload = true;                            
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
                            Console.WriteLine("Incorrect input, please choose a valid option.");
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