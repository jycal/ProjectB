public class Menu
{
    // Fields
    public string Map;
    public string CurrentLocation;
    public int HP;
    public int Level;
    public int ExperiencePoints;
    public int Gold;
    public List<PlayerQuest> QuesList;
    public List<CountedItemList> Inventory;

    public Menu(string map, string currentlocation, int hp, int level, int experiencepoints, int gold)
    {
        this.Map = map;
        this.CurrentLocation = currentlocation;
        this.HP = hp;
        this.Level = level;
        this.ExperiencePoints = experiencepoints;
        this.Gold = gold;
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
            Console.WriteLine("3: Fight");
            Console.WriteLine("4: Quit\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine($"Your current Location: {CurrentLocation}");
                Console.WriteLine($"Your current HP is {HP}");
                Console.WriteLine($"Your at Level: {Level}");
                Console.WriteLine($"You have {ExperiencePoints} Experience Points");
                Console.WriteLine($"You have {Gold} Golden Coins");
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
                Console.WriteLine($"You are at {World.LocationByID(1)}. From here you can go:");
                Console.WriteLine($"  P\n  A\nV F T G B S\n  H\n");
                World.LocationByID(1);
                string destination = Console.ReadLine().ToUpper();
                switch (destination)
                {
                    case "P":
                        // Move to location P (Alchemist's garden)
                        this.CurrentLocation = World.LocationByID(5).Name;
                        Console.WriteLine($"You have arrived at {this.CurrentLocation}.\n");
                        break;
                    case "A":
                        // Move to location A (Alchemist's hut)
                        this.CurrentLocation = World.LocationByID(4).Name;
                        Console.WriteLine($"You have arrived at {this.CurrentLocation}.\n");

                        break;
                    case "V":
                        // Move to location V (Farmer's field)
                        break;
                    case "F":
                        // Move to location F (Farmer)
                        break;
                    case "T":
                        // Move to location T (Town square)
                        break;
                    case "G":
                        // Move to location G (Guard post)
                        break;
                    case "B":
                        // Move to location B (Bridge)
                        break;
                    case "S":
                        // Move to location S (Spider forest)
                        break;
                    case "H":
                        // Move to location H (Home)
                        break;
                    default:
                        Console.WriteLine("Invalid destination. Please enter a valid location code.");
                        break;
                }
            }
            else if (choice == 3)
            {
                // Player en Monster moeten vechten in Game.cs
                // Player();
                // Monster();
            }
            else if (choice == 4)
            {
                Quit();
            }
        }
    }

    // Quit the game
    public void Quit()
    {
        Environment.Exit(0);
    }
}
