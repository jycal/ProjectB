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
            int choice = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine($"  P\n  A\nV F T G B S\n  H\n");
                World.LocationByID(1);
                string destination = Console.ReadLine()!.ToUpper();
                switch (destination)
                {
                    case "P":
                        // Move to location P (Alchemist's garden)
                        Player.CurrentLocation = World.LocationByID(5);
                        Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                        break;
                    case "A":
                        // Move to location A (Alchemist's hut)
                        Player.CurrentLocation = World.LocationByID(4);
                        Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");

                        break;
                    case "V":
                        // Move to location V (Farmer's field)
                        Player.CurrentLocation = World.LocationByID(7);
                        Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");

                        break;
                    case "F":
                        // Move to location F (Farmer)
                        Player.CurrentLocation = World.LocationByID(6);
                        Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                        // slang met id ophalen uit world
                        Monster snake = World.MonsterByID(World.MONSTER_ID_SNAKE);
                        // quest aanroepen
                        Farmer farmerquest = new Farmer(Player, snake);
                        farmerquest.Story();
                        break;
                    case "T":
                        // Move to location T (Town square)
                        Player.CurrentLocation = World.LocationByID(2);
                        Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");

                        break;
                    case "G":
                        // Move to location G (Guard post)
                        Player.CurrentLocation = World.LocationByID(3);
                        Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");

                        break;
                    case "B":
                        // Move to location B (Bridge)
                        bool hasAdventurePass = false;

                        foreach (CountedItemList itemList in Inventory)
                        {
                            foreach (CountedItem countedItem in itemList.TheCountedItemList)
                            {
                                if (countedItem.TheItem.ID == World.ITEM_ID_ADVENTURER_PASS)
                                {
                                    hasAdventurePass = true;
                                    break;
                                }
                            }

                            if (hasAdventurePass)
                            {
                                Player.CurrentLocation = World.LocationByID(8);
                                Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                                break; // break out of the outer loop as well
                            }
                        }

                        if (!hasAdventurePass)
                        {
                            Console.WriteLine("You do not have the adventure pass to enter this area. Returning to menu...\n");
                            Console.ReadKey();

                            break;
                        }
                        break;

                    case "S":
                        // Move to location S (Spider forest)
                        Player.CurrentLocation = World.LocationByID(9);
                        Console.WriteLine($"You have arrived at {Player.CurrentLocation.Name}.\n");
                        // spider met id ophalen uit world
                        Monster spider = World.MonsterByID(3);
                        // spiderquest aanroepen
                        SpiderQuest spiderquest = new SpiderQuest(Player, spider);
                        spiderquest.StartSpiderQuest();
                        spiderquest.EndSpiderQuest();
                        break;
                    case "H":
                        // Move to location H (Home)
                        Player.CurrentLocation = World.LocationByID(1);
                        Console.WriteLine($"You have arrived back {Player.CurrentLocation.Name}.\n");

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
