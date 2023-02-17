class Menu
{
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

    public void Screen()
    {
        Console.Writeline("What would you like to do (Enter a number)?");
        Console.Writeline("1: See game stats");
        Console.Writeline("2: Move");
        Console.Writeline("3: Fight");
        Console.Writeline("4: Quit");
        int choice = Convert.ToInt32(Console.Readline());
        if (choice == 1)
        {
            Console.Writeline($"Your current Location: {CurrentLocation}");
            Console.Writeline($"Your current HP is {HP}");
            Console.Writeline($"Your at Level: {Level}");
            Console.Writeline($"You have {ExperiencePoints} Experience Points");
            Console.Writeline($"You have {Gold} Golden Coins");
            foreach (PlayerQuest quest in QuesList)
            {
                Console.Writeline($"The quests you've gone through consist of {quest}");
            }
            foreach (CountedItemList item in Inventory)
            {
                Console.Writeline($"Your inventory consists of a {item}");
            }
        }
        else if (choice == 2)
        {
            Console.Writeline("Where would you like to go?");
            Console.Writeline($"You are at {CurrentLocation}. From here you can go:");
            Console.Writeline($"  P\n  A\n V F T G B S\n   H");
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

    public void Quit()
    {
        this.Close();
    }

}