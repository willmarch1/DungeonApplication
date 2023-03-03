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
            Console.Write("Press Enter to continue...  ");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("Charlie is a cat who has it all, but it wasn't always that way...Abandoned at an extremely young age, Charlie had to\nfight for his well-being." +
                " He learned to take advantage of the smallest opportunities, navigate his way through the\nworld with eyes in the back of his head, and overcome " +
                "the toughest circumstances. Through trials and tribulations,\nhis struggles as a youth helped to shape him into a Cat worth being.\n" +
                "\nYears go by, and after overcoming adversity, Charlie now lives like royalty. He prances around his palace with cat treat\nfountains, catnip gardens, " +
                "and cat tree towers at every window which give him views he never thought he'd get to have.\nThat is until...tragedy strikes! Menacing forces have invaded Charlie's palace" +
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
            Console.Write("Press Enter to continue...  ");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Player Creation
            int score = 0;
            int monstersKilled = 0;
            // Weapon creation
            Weapon claws = new("CLAWS -> Charlie's Extendable Wolverine-like Claws", 10, true, 3, 8,WeaponType.Claws);
            Weapon teeth = new("TEETH -> Charlie's custom made mouthguard with Knives as teeth", 15, false, 4, 10, WeaponType.Teeth_Knives);
            Weapon whip = new("WHIP -> Charlie attaches an electric Whip to his tail", 20, false, 6, 10, WeaponType.Whip);
            
            Player player = new Player(20, 70, "Charlie The Cat", 75, Race.Animal, claws);

            bool chosen = false;
            do
            {
                Console.WriteLine("\n\n\tCharlie has prepared for this moment. He knew the enemies of his past would be jealous of his success.\n");
                Console.Write("\n\t\t\tChoose a weapon for Charlie to wield: \n\n" +
                               "\t\t\t[C] === CLAWS: Charlie's Extendable Wolverine-like Claws\n\n" +
                               "\t\t\t[T] === TEETH: Charlie's custom made mouthguard with knives as Teeth\n\n" +
                               "\t\t\t[W] === WHIP: Charlie attaches an electric Whip to his tail\n\n");
                Console.Write("Please select an option: C, T, or W:  ");
                ConsoleKey userWeapon = Console.ReadKey(true).Key;
                Console.WriteLine("");
                switch (userWeapon)
                {
                    case ConsoleKey.C:
                        Console.WriteLine($"You chose {claws}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Are you sure? Press Y to Confirm your weapon. Press any other key to choose again.");
                        Console.ResetColor();
                        ConsoleKey userConfirm = Console.ReadKey(true).Key;
                        if (userConfirm == ConsoleKey.Y)
                        {
                            chosen = true;
                        }                      
                        player.EquippedWeapon = claws;
                        break;

                    case ConsoleKey.T:
                        Console.WriteLine($"\nYou chose {teeth}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Are you sure? Press Y to Confirm your weapon. Press any other key to choose again.");
                        Console.ResetColor();
                        ConsoleKey userConfirm2 = Console.ReadKey(true).Key;
                        if (userConfirm2 == ConsoleKey.Y)
                        {
                            chosen = true;
                        }                      
                        player.EquippedWeapon = teeth;
                        break;

                    case ConsoleKey.W:
                        Console.WriteLine($"\nYou chose {whip}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\tAre you sure? Press Y to Confirm your weapon. Press any other key to choose again.");
                        Console.ResetColor();
                        ConsoleKey userConfirm3 = Console.ReadKey(true).Key;
                        if (userConfirm3 == ConsoleKey.Y)
                        {
                            chosen = true;
                        }
                        player.EquippedWeapon = whip;
                        break;

                    default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("ERROR: Invalid input, choose a valid weapon (C, T, or W).");
                        Console.ResetColor();
                        break;
                }



            } while (!chosen);
           
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\t\t\tWEAPON CONFIRMED. Press any key to receieve Charlie's first Challenge...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Main Game Loop
            bool exit = false;          
            do
            {
                //TODO Generate a random room
                
                Room room = GetRoom();
                Console.WriteLine(room);
                //Select a random monster to inhabit the room
                //Monster monster = Monster.GetMonster();
                //Console.WriteLine($"In this room is {monster.Name}!");
                #region Gameplay Menu Loop
                bool reload = false;            
                do
                {
                    // Gameplay menu
                    #region Menu

                    Console.WriteLine("\n\tPlease choose an action:  \n" +
                        "\tA) Attack\n" +
                        "\tR) Run away\n" +
                        "\tP) Player Info\n" +
                        "\tM) Monster Info\n" +
                        "\tX) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            // Combat
                            //Potential expansion : Weapon/race bonus attack
                            //if race == darkelf -> player.DoAttack(monster)
                            Combat.DoBattle(player, room.RoomMonster);
                            //check if the monster is dead
                            if (room.RoomMonster.Life <= 0)
                            {
                                //Expansion - combat rewards. money, health, whatever
                                Thread.Sleep(400);
                                Console.Clear();
                                Console.ForegroundColor= ConsoleColor.Blue;
                                Console.WriteLine($"\nCharlie dealt the final blow to {room.RoomMonster.Name}!");
                                Console.ResetColor();
                                Console.ForegroundColor= ConsoleColor.Green;
                                Console.WriteLine("He celebrates with a little cat nip, which restores a small amount of health.\n\n");
                                Console.ResetColor();
                                Console.ForegroundColor=(ConsoleColor) ConsoleColor.DarkYellow;
                                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\tPress any key to receive Charlie's next challenge...  ");
                                Console.ReadKey();
                                Console.ResetColor();
                                Console.Clear();
                                player.Life = player.Life + (player.MaxLife / 10);
                                if (player.Life > player.MaxLife)
                                {
                                    player.Life = player.MaxLife;
                                }
                                score ++;
                                monstersKilled++;
                                //flip the inner loop bool to true to get a new room and new monster
                                reload = true;
                                if (monstersKilled < 10)
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



                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("\n\n\n\n\n\n\n\n\n\t\t\t\t\tPress any key to continue...  ");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\n\n\t\tCongratulations! Charlie has once again defied all odds and overcome his enemies!");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n\n\t\t\t\t\t\tYOU WIN!\n\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\t\t\tYou defeated " + score + " of Charlie's enemies to keep his palace at peace.");
                                    Console.ResetColor();
                                    Console.Write("\n\n\n\nPress any key to continue... ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("\n\n\n\n\t\t\t\t\t\tCREDITS\n\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("\t\t\t\t\tA game by: Will March\n\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\t\t\tSpecial thanks to: Centriq, Jeremy, Jeff, Spencer, and my classmates!\n\n\n\n\n\n");
                                    Console.ResetColor();

                                    exit = true;
                                    reload = false;
                                    
                                }
                            }
                            break;

                        case ConsoleKey.R:
                            // Attack of opportunity
                            Console.WriteLine("Charlie doesn't feel ready for this fight yet...He hisses and runs away!");
                            Console.WriteLine($"Offended by his hiss, {room.RoomMonster.Name} attacks as he runs.");
                            Combat.DoAttack(room.RoomMonster, player);
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
                            Console.WriteLine(room.RoomMonster);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            Console.WriteLine("Charlie was really counting on you... Remember, he'll be in trouble until you return and help him!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Incorrect input, please choose a valid option.");
                            break;
                    }
                    #endregion
                    // check player life
                    if (player.Life <=0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n\n\t\t{room.RoomMonster.Name} dealt the final blow to Charlie!");
                        Console.ResetColor();
                        Console.WriteLine("\nDefeated, Charlie sighs. He knows he must once again return to a life of uncertainty.\n" +
                            "He gives one last look at his overrun palace before heading off with no particular destination.\a");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n\n\n\n\n\nDon't give up! Charlie only needs to clear the palace of a few more enemies to achieve victory...");
                        Console.ResetColor();
                        Console.Write("\nWould you like to respawn? Press Y to for Yes. Press any other key to give up. ");
                        ConsoleKey userTryAgain = Console.ReadKey(true).Key;
                        
                        if (userTryAgain == ConsoleKey.Y)
                        {
                            reload= true;
                            Console.Clear();
                            player.Life = player.MaxLife;
                        }
                        else
                        {
                            exit = true;
                        }
                    }

                } while (!reload && !exit); //if either exit or reload, the inner loop will exit


                
                #endregion
            } while (!exit); // if exit is true, the outer loop will exit as well

            //Show the score
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.Write("\n\n\n\n\n\n\n\n\n\t\t\t\t\tPress any key to continue...  ");
            //Console.ResetColor();
            //Console.ReadKey();
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("\n\n\t\tCongratulations! Charlie has once again defied all odds and overcome his enemies!");
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\n\n\t\t\t\t\t\tYOU WIN!\n\n");
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("\t\t\tYou defeated " + score + " of Charlie's enemies to keep his palace at peace.");
            //Console.ResetColor();
            //Console.Write("\n\n\n\nPress any key to continue... ");
            //Console.ReadKey();
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("\n\n\n\n\t\t\t\t\t\tCREDITS\n\n");
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.WriteLine("\t\t\t\t\tA game made by: Will March\n\n");
            //Console.ResetColor(); 
            //Console.ForegroundColor= ConsoleColor.Green;
            //Console.WriteLine("\t\t\tSpecial thanks to: Centriq, Jeremy, Jeff, Spencer, and my classmates!\n\n\n\n\n\n");
            //Console.ResetColor();
            #endregion
        }//end Main()

        private static Room GetRoom()
        {
            Monster r1 = new("Rabid Rat", block: 7, hitChance: 90, maxLife: 20, maxDamage: 7, minDamage: 2, description: "Ground Zero for the start of rabies in Rats, this one seeks revenge for the turmoil Cats have\ncaused Rats for centuries...");
            Monster r2 = new("BUFFED Rabid Rat+", block: 8, hitChance: 92, maxLife: 24, maxDamage: 7, minDamage: 3, description: "Ground Zero for the start of rabies in Rats, this one seeks revenge for the turmoil Cats have\ncaused Rats for centuries...\n ***  ++ indicates buffed stats!  ***");

            Monster v1 = new("Vicious Vacuum", block: 8, hitChance: 85, maxLife: 22, maxDamage: 8, minDamage: 2, description: "A sworn nemesis of the Cat, the Vicious Vacuum will stop at nothing to end the collection of shedded\ncat hair once and for all.");
            Monster v2 = new("BUFFED Vicious Vacuum+", block: 8, hitChance: 85, maxLife: 28, maxDamage: 8, minDamage: 4, description: "A sworn nemesis of the Cat, the Vicious Vacuum will stop at nothing to end the collection of shedded\ncat hair once and for all.\n ***  ++ indicates buffed stats!  ***");

            Monster l1 = new("Laserating Laser Pointer", block: 15, hitChance: 70, maxLife: 25, maxDamage: 8, minDamage: 3, description: "A quick enemy. Makes for a good match for a Cat, but can Charlie finally catch it?");
            Monster l2 = new("BUFFED Laserating Laser Pointer+", block: 15, hitChance: 75, maxLife: 25, maxDamage: 7, minDamage: 2, description: "A quick enemy. Makes for a good match for a Cat, but can Charlie finally catch it?\n ***  ++ indicates buffed stats!  ***");

            Monster g1 = new("Growling Gracie", block: 15, hitChance: 75, maxLife: 30, maxDamage: 9, minDamage: 4, description: "A vicious, mouth-foaming, eyes bulging, barking, determined to kill 4.8 pound Chihuahua.\nStill, somehowcute. DO NOT UNDERESTIMATE!");
            Monster g2 = new("BUFFED Growling Gracie+", block: 20, hitChance: 85, maxLife: 35, maxDamage: 10, minDamage: 6, description: "A vicious, mouth-foaming, eyes bulging, barking, determined to kill 4.8 pound Chihuahua.\nStill, somehowcute. DO NOT UNDERESTIMATE!\n ***  ++ indicates buffed stats!  ***");

            Monster t1 = new("Terrorizing Toddler", block: 25, hitChance: 80, maxLife: 24, maxDamage: 8, minDamage: 4, description: "A tiny human with no awareness or boundaries. This toddler has crazy eyes and a smelly diaper.");
            Monster t2 = new("BUFFED Terrorizing Toddler+", block: 25, hitChance: 85, maxLife: 30, maxDamage: 9, minDamage: 5, description: "A tiny human with no awareness or boundaries. This toddler has crazy eyes and a smelly diaper. \n ***  ++ indicates buffed stats!  ***");


            List<Room> rooms = new List<Room>()
            {
                new Room()
                {
                    RoomMonster = r1,
                    RoomDescription = "Charlie races to the basement of his Palace. Immediately he realizes his suspiciouns are true.\nA nasty Rabid Rat is rummaging through his things, trying to steal the possessions" +
                                        " that he's worked so hard to acquire.\nCharlie hisses, and the Rat stands its ground...ready to fight."
                },
                new Room()
                {
                    RoomMonster= r2,
                    RoomDescription = "Charlie races to the basement of his Palace. Immediately he realizes his suspiciouns are true.\nA nasty Rabid Rat is rummaging through his things, trying to steal the possessions" +
                                        " that he's worked so hard to acquire.\nCharlie hisses, and the Rat stands its ground...ready to fight.\nThis rat seems hyper-rabid..."
                },
                new Room()
                {
                    RoomMonster= v1,
                    RoomDescription= "Charlie hears strange noises coming from his master closet...He swings open the double doors, and right there\nbefore him" +
                                        " is one of his biggest fears, but also a sworn nemesis. The vacuum that Charlie had banished from his\n" +
                                        "palace years ago, has returned. It's staring down at him, filled with hatred, vengeance, and various collections\nof dust bunnies. This won't be pretty."
                },
                 new Room()
                {
                    RoomMonster = v2,
                    RoomDescription = "Charlie hears strange noises coming from his master closet...He swings open the double doors, and right there\nbefore him" +
                                        " is one of his biggest fears, but also a sworn nemesis. The vacuum that Charlie had banished from his\n" +
                                        "palace years ago, has returned. It's staring down at him, filled with hatred, vengeance, and various collections\nof dust bunnies. This won't be pretty."
                },
                new Room()
                {
                    RoomMonster= l1,
                    RoomDescription = "Upon investigating strange lights coming from the guest house, Charlie discovers a strange red glow coming\n" +
                                        "from the lounge. He peeks his head around the corner and spots his arch-nemesis...the laser pointer.\nCharlie knows" +
                                        "he's struggled against this enemy in the past, but this time it's personal, and not just for fun and games.\n" +
                                        "This time around, it's about to get real."
                },
                new Room()
                {
                    RoomMonster= l2,
                    RoomDescription= "Upon investigating strange lights coming from the guest house, Charlie discovers a strange red glow coming\n" +
                                        "from the lounge. He peeks his head around the corner and spots his arch-nemesis...the laser pointer.\nCharlie knows" +
                                        "he's struggled against this enemy in the past, but this time it's personal, and not just for fun and games.\n" +
                                        "This time around, it's about to get real.\nThis laser seems extra quick..."
                },
                 new Room()
                {
                    RoomMonster = g1,
                    RoomDescription = "Sensing something wrong outside, Charlie dashes to the front gate of his palace and looks outside...\n" +
                                        "That's when he spots her. He once thought they could be friends...even BEST friends. In the bottom\n" +
                                        "of his heart he wished he didn't see her here tonight...but alas, Growling Gracie is pooping right\n" +
                                        "on his favorite cat nip garden. He leaps down the grand staircase and races towards her ready to pounce,\nand she's done with her business, now ready to fight.\n" 
                 },
                new Room()
                {
                    RoomMonster= g2,
                    RoomDescription = "Sensing something wrong outside, Charlie dashes to the front gate of his palace and looks outside...\n" +
                                        "That's when he spots her. He once thought they could be friends...even BEST friends. In the bottom\n" +
                                        "of his heart he wished he didn't see her here tonight...but alas, Growling Gracie is pooping right\n" +
                                        "on his favorite cat nip garden. He leaps down the grand staircase and races towards her ready to pounce,\nand she's done with her business, now ready to fight.\n" +
                                        "This Growling Gracie seems like she hasn't eaten in days..."
                },
                new Room()
                {
                    RoomMonster= t1,
                    RoomDescription= "There is horrible music coming from the great hall...but why? Charlie investigates. What he\n" +
                                        "finds is truly terrifying. It's a tiny toddler wrecking havoc on his gold-plated piano.\n" +
                                        "He will not stand for this. The amount of wreckage this little creature can" +
                                        " accumulate is mind-boggling.\nThis terrorizing toddler needs to be sent back to daycare!"
                },
                 new Room()
                {
                    RoomMonster = t2,
                    RoomDescription = "There is horrible music coming from the great hall...but why? Charlie investigates. What he\n" +
                                        "finds is truly terrifying. It's a tiny toddler wrecking havoc on his gold-plated piano.\n" +
                                        "He will not stand for this. The amount of wreckage this little creature can" +
                                        " accumulate is mind-boggling.\nThis terrorizing toddler needs to be sent back to daycare!\n" +
                                        "This toddler seems like it needs a nap..."
                 }
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