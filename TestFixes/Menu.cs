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
        Console.WriteLine("What wouLd you like to do (Enter a number)?");
        Console.WriteLine("1: See game stats");
        Console.WriteLine("2: Move");
        Console.WriteLine("3: Fight");
        Console.WriteLine("4: Quit");
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
            Console.WriteLine($"You are at {CurrentLocation}. From here you can go:");
            Console.WriteLine($"  P\n  A\n V F T G B S\n   H");
            Location();
        }
        else if (choice == 3)
        {
            // Player en Monster moeten vechten in Game.cs
            Player();
            Monster();
        }
        else if (choice == 4)
        {
            Quit();
        }
    }

    // Quit the game
    public void Quit()
    {
        Environment.Exit(0);
    }
}
