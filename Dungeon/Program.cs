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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Press Enter to continue...");
            Console.ResetColor();
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
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.Write("Press Enter to continue...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Player Creation
            //TODO Variable to keep score
            int score = 0;
            int monstersKilled = 0;
            // Weapon creation
            //Possible Expansion - Display a list of pre-created weapons and let them pick one, or pick one for them randomly
            Weapon claws = new("CLAWS -> Charlie's Extendable Wolverine-like Claws", 10, true, 3, 8,WeaponType.Claws);
            Weapon teeth = new("TEETH -> Charlie's custom made mouthguard with Knives as teeth", 15, false, 4, 10, WeaponType.Teeth_Knives);
            Weapon whip = new("WHIP -> Charlie attaches an electric Whip to his tail", 20, false, 6, 10, WeaponType.Whip);
            //Choose weapon loop
            bool chosen = false;
            Player player = new Player(20, 70, "Charlie The Cat", 50, Race.Animal, claws);


            do
            {
                Console.WriteLine("\n\n\tCharlie has prepared for this moment. He knew the enemies of his past would be jealous of his success.\n");
                Console.Write("\n\t\t\tChoose a weapon for Charlie to wield: \n\n" +
                               "\t\t\t[C] === CLAWS: Charlie's Extendable Wolverine-like Claws\n\n" +
                               "\t\t\t[T] === TEETH: Charlie's custom made mouthguard with Knives as teeth\n\n" +
                               "\t\t\t[W] === WHIP: Charlie attaches an electric Whip to his tail\n\n");
                Console.Write("\n\n\n\nPlease select an option: C, T, or W:  ");
                ConsoleKey userWeapon = Console.ReadKey(true).Key;
                switch (userWeapon)
                {
                    case ConsoleKey.C:
                        Console.WriteLine($"\nYou chose {claws}");
                        Console.WriteLine("Are you sure?");
                        ConsoleKey userConfirm = Console.ReadKey(true).Key;
                        if (userConfirm == ConsoleKey.Y)
                        {
                            chosen = true;
                        }
                        
                        player.EquippedWeapon = claws;
                        break;
                    case ConsoleKey.T:
                        Console.WriteLine($"\nYou chose {teeth}");
                        chosen = true;
                        player.EquippedWeapon = teeth;
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine($"\nYou chose {whip}");
                        chosen = true;
                        player.EquippedWeapon = whip;
                        break;
                    default:
                        Console.WriteLine("Invalid input, choose a valid weapon (C, T, or W).");
                        break;
                }



            } while (!chosen);
            //if (chosen)
            //{
            //    Console.WriteLine("Are you sure?");
            //    Console.ReadKey();
            //}





            //Console.WriteLine("Charlie has prepared for this moment. He knew the enemies of his past would be jealous of his success.\n");
            //Console.Write("Choose a weapon for Charlie to wield: \n");

            // Console.WriteLine("[C] === Charlie's Extendable Wolverine-like Claws\n" +
            //                       "[T] === Charlie's custom made mouthguard with Knives as teeth\n" +
            //                       "[W] === Charlie attaches an electric Whip to his tail\n");
            //ConsoleKey userWeapon = Console.ReadKey(true).Key;


            //if (userWeapon=="c" || userWeapon == "t" || userWeapon == "w")


            //{
            //    Console.WriteLine($"Are you sure you want to use {userWeapon}? Press Y to confirm, Press N choose a different one.");
            //    string confirmWeapon = Console.ReadLine().ToUpper();
            //    if (confirmWeapon =="Y")
            //    {
            //        Console.WriteLine("Ahh...One of Charlie's favorites. This should prove useful.\n");
            //        Console.Write("Press any key to continue...");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //    else if (confirmWeapon == "N")
            //    {
            //        Console.WriteLine("Didn't like that one? Choose another.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("That input was not recognized, please try again.");
            //    }

            //}
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\n\n\t\t\t\tPress any key to start your first Challenge...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            // Player object creation
            //Potential Expansion - allow them to enter their own name
            //Show them possible races and let them pick one
           
            #endregion

            #region Main Game Loop
            bool exit = false;
           
            do
            {
                //TODO Generate a random room
                Console.WriteLine(GetRoom());
                //Select a random monster to inhabit the room
                Monster monster = Monster.GetMonster();
                //Console.WriteLine($"In this room is {monster.Name}!");
                #region Gameplay Menu Loop
                bool reload = false;            
                do
                {
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
                                Console.WriteLine($"\nYou defeated {monster.Name}!");
                                Console.ResetColor();
                                Console.ForegroundColor= ConsoleColor.Blue;
                                Console.WriteLine("Charlie celebrates with some cat nip which restores a small amount of health.");
                                Console.ResetColor();
                                player.Life = player.Life + (player.MaxLife / 10);
                                if (player.Life > player.MaxLife)
                                {
                                    player.Life = player.MaxLife;
                                }
                                score ++;
                                monstersKilled++;
                                //flip the inner loop bool to true to get a new room and new monster
                                reload = true;
                                if (monstersKilled < 8)
                                {

                                }
                                else
                                {
                                    Console.WriteLine("\n\nCharlie darts into the next room, ready to use his wepaon against another enemy, only to find it empty.\n" +
                                        $"He checks all the rooms one-by-one, and finally finds his palace completely void of enemies.\nFor most, this would have been a tragic event," +
                                        $" but not for Charlie. For him, this was just another obstacle in\nhis life to overcome. He has once again shown the" +
                                        $" world, and more importantly, HIMSELF, that nothing can stop him.\n\nHe'll clean up the mess later. For now, he climbs up his" +
                                        $" favorite cat tree, and purrs himself to sleep.\n\n\n" + @"
                                  Z
                                 Z
                                Z
                               )\._.,--....,'``.
                              /,   _.. \   _\  (`._ ,.
                             `._.-(,_..'--(,_..'`-.;.'   ");




                                    exit = true;
                                    reload = false;
                                }
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
                            Console.WriteLine("Enemies Defeated: " + score);
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

        private static Room GetRoom()
        {
            Monster r1 = new("Rabid Rat", block: 7, hitChance: 90, maxLife: 20, maxDamage: 4, minDamage: 0, description: "Ground Zero for the start of rabies in Rats, this one seeks revenge for the turmoil Cats have\ncaused Rats for centuries...");
            Monster r2 = new("Rabid Rat++", block: 8, hitChance: 90, maxLife: 24, maxDamage: 4, minDamage: 1, description: "Ground Zero for the start of rabies in Rats, this one seeks revenge for the turmoil Cats have\ncaused Rats for centuries...\n ***  ++ indicates buffed stats!  ***");

            Monster v1 = new("Vicious Vacuum", block: 8, hitChance: 85, maxLife: 22, maxDamage: 5, minDamage: 1, description: "A sworn nemesis of the Cat, the Vicious Vacuum will stop at nothing to end the collection of shedded\nhair once and for all.");
            Monster v2 = new("Vicious Vacuum++", block: 8, hitChance: 85, maxLife: 28, maxDamage: 6, minDamage: 6, description: "A sworn nemesis of the Cat, the Vicious Vacuum will stop at nothing to end the collection of shedded\nhair once and for all.\n ***  ++ indicates buffed stats!  ***");

            Monster l1 = new("Laserating Laser Pointer", block: 15, hitChance: 70, maxLife: 25, maxDamage: 6, minDamage: 1, description: "A quick enemy. Makes for a good match for a Cat, but can Charlie finally catch it?");
            Monster l2 = new("Laserating Laser Pointer", block: 15, hitChance: 75, maxLife: 25, maxDamage: 7, minDamage: 2, description: "A quick enemy. Makes for a good match for a Cat, but can Charlie finally catch it?\n ***  ++ indicates buffed stats!  ***");

            Monster g1 = new("Growling Gracie", block: 15, hitChance: 75, maxLife: 30, maxDamage: 7, minDamage: 4, description: "A vicious, mouth-foaming, eyes bulging, barking, determined to kill 4.8 pound Chihuahua.\nStill, somehowcute. DO NOT UNDERESTIMATE!");
            Monster g2 = new("Growling Gracie++", block: 20, hitChance: 85, maxLife: 35, maxDamage: 10, minDamage: 4, description: "A vicious, mouth-foaming, eyes bulging, barking, determined to kill 4.8 pound Chihuahua.\nStill, somehowcute. DO NOT UNDERESTIMATE!\n ***  ++ indicates buffed stats!  ***");

            Monster t1 = new("Terrorizing Toddler", block: 25, hitChance: 80, maxLife: 24, maxDamage: 4, minDamage: 1, description: "A tiny human with no awareness or boundaries. This toddler has crazy eyes and a smelly diaper.");
            Monster t2 = new("Terrorizing Toddler++", block: 25, hitChance: 85, maxLife: 30, maxDamage: 6, minDamage: 3, description: "A tiny human with no awareness or boundaries. This toddler has crazy eyes and a smelly diaper. \n ***  ++ indicates buffed stats!  ***");


            List<Room> rooms = new List<Room>()
            {
                new Room()
                {
                    RoomMonster = r1,
                    RoomDescription = "sadfghfdsdf"
                },
                new Room()
                {

                },
            };
           

            Random rand = new Random();

            int index = rand.Next(rooms.Count);


            Room room = rooms[index];

            return room;
            //possible refactor
            //return rooms[new Random().Next(rooms.Length)];
        }

    }//end class
}//end namespace