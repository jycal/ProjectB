public class Menu
{
    // Fields
    public string Map;
    // public string CurrentLocation;
    // public int HP;
    // public int Level;
    // public int ExperiencePoints;
    // public int Gold;
    public Player Player;
    public List<PlayerQuest> QuesList;
    public List<CountedItemList> Inventory;

    public Menu(string map, Player player)
    {
        this.Map = map;
        this.Player = player;
        // this.CurrentLocation = currentlocation;
        // this.HP = hp;
        // this.Level = level;
        // this.ExperiencePoints = experiencepoints;
        // this.Gold = gold;
        this.QuesList = new List<PlayerQuest>();
        this.Inventory = new List<CountedItemList>();
    }

    // Menu
    public void Screen()
    {
        bool playerSelected = false;
        while (!playerSelected)
        {
            Console.WriteLine("What wouLd you like to do (Enter a number)?");
            Console.WriteLine("1: See game stats");
            Console.WriteLine("2: Move");
            Console.WriteLine("3: Quit\n");
            int choice;
            choice = Int32.Parse(Console.ReadLine()!);
            if (choice == 1)
            {
                Console.WriteLine($"Your current Location: {Player.CurrentLocation!.Name}");
                Console.WriteLine($"Your current HP is {Player.CurrentHitPoints}");
                Console.WriteLine($"Your at Level: {Player.Level}");
                Console.WriteLine($"You have {Player.ExperiencePoints} Experience Points");
                Console.WriteLine($"You have {Player.Gold} Golden Coins\n");
                foreach (PlayerQuest quest in QuesList)
                {
                    Console.WriteLine($"The quests you've gone through consist of {quest}");
                }
                foreach (CountedItemList item in Inventory)
                {
                    Console.WriteLine($"Your inventory consists of a {item}");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Where would you like to go?");
                Console.WriteLine($"You are at {Player.CurrentLocation!.Name}. From here you can go:");
                Console.WriteLine($"    P\n    A\nV F T G B S\n    H\n");
                World.LocationByID(1);
                string destination = Console.ReadLine()!.ToUpper();
                switch (destination)
                {
                    case "P":
                        // Move to location P (Alchemist's garden)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 4:
                                Player.CurrentLocation = World.LocationByID(5);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                break;
                            default:
                                Console.WriteLine("You are not allowed to enter this area. Returning to menu...\n");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "A":
                        // Move to location A (Alchemist's hut)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 2:
                            case 5:
                                Player.CurrentLocation = World.LocationByID(4);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                break;
                            default:
                                Console.WriteLine("You are not allowed to enter this area. Returning to menu...\n");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "V":
                        // Move to location V (Farmer's field)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 7:
                                Player.CurrentLocation = World.LocationByID(7);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                break;
                            default:
                                Console.WriteLine("You are not allowed to enter this area. Returning to menu...\n");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "F":
                        // Move to location F (Farmer)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 2:
                            case 7:
                                Player.CurrentLocation = World.LocationByID(6);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                // slang met id ophalen uit world
                                Monster snake = World.MonsterByID(World.MONSTER_ID_SNAKE);
                                // quest aanroepen
                                Farmer farmerquest = new Farmer(Player, snake);
                                if (farmerquest.IsCompleted == false)
                                {
                                    farmerquest.Story();
                                }
                                break;
                            default:
                                Console.WriteLine("You are not allowed to enter this area. Returning to menu...\n");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "T":
                        // Move to location T (Town square)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 1:
                            case 4:
                            case 6:
                                Player.CurrentLocation = World.LocationByID(2);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                break;
                            default:
                                Console.WriteLine("You are not allowed to enter this area. Returning to menu...\n");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "G":
                        // Move to location G (Guard post)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 2:
                            case 8:
                                Player.CurrentLocation = World.LocationByID(3);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                GuardPost guardpost = new GuardPost(Player);
                                if (guardpost.guard_post() == false)
                                {
                                    Player.CurrentLocation = World.LocationByID(2);
                                    Console.WriteLine("You are not allowed to enter this area. Returning to menu...\n");
                                    Console.ReadKey();
                                }
                                break;
                            default:
                                Console.WriteLine("You are not allowed to enter this area. Returning to menu...\n");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "B":
                        // Move to location B (Bridge)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 3:
                            case 9:
                                Player.CurrentLocation = World.LocationByID(8);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                break;
                            default:
                                Console.WriteLine("You are not allowed to enter this area. Returning to menu...\n");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "S":
                        // Move to location S (Spider forest)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 8:
                                Player.CurrentLocation = World.LocationByID(9);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                // spider met id ophalen uit world
                                Monster spider = World.MonsterByID(3);
                                // spiderquest aanroepen
                                SpiderQuest spiderquest = new SpiderQuest(Player, spider);
                                if (spiderquest.IsCompleted == false)
                                {
                                    spiderquest.StartSpiderQuest();
                                    spiderquest.EndSpiderQuest();
                                }
                                break;
                        }
                        break;
                    case "H":
                        // Move to location H (Home)
                        switch (Player.CurrentLocation!.ID)
                        {
                            case 2:
                                Player.CurrentLocation = World.LocationByID(1);
                                Console.WriteLine($"You have arrived back {Player.CurrentLocation.Name}.\n");
                                Console.WriteLine($"{Player.CurrentLocation.Description}.\n");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid destination. Please enter a valid location code.");
                        break;
                }
            }
            else if (choice == 3)
            {
                Quit();
            }
        }
    }

    // Quit the game
    public static void Quit()
    {
        Environment.Exit(0);
    }
}
