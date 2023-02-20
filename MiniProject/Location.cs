public class Location
{
    // Fields
    public int ID;
    public string Name;
    public string Description;

    public Item ItemRequiredToEnter;

    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;

    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;


    public Location(int id, string name, string description, Item itemRequiredToEnter = null!, Quest questAvailableHere = null!, Monster monsterLivingHere = null!)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.ItemRequiredToEnter = itemRequiredToEnter;
        this.QuestAvailableHere = questAvailableHere;
        this.MonsterLivingHere = monsterLivingHere;
        this.LocationToNorth = null!;
        this.LocationToEast = null!;
        this.LocationToSouth = null!;
        this.LocationToWest = null!;
    }

    public void Move()
    {   
        bool IsMoving = true;
        while (IsMoving)
        {
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine($"You are at {this.Name}.");
            Console.WriteLine($"  P\n  A\n V F T G B S\n   H");
            string Direction = Convert.ToString(Console.ReadLine()!);
            if (Direction == "T")
            {
                World.LocationByID(World.LOCATION_ID_TOWN_SQUARE);
            }
            if (Direction == "A")
            {
                World.LocationByID(World.LOCATION_ID_ALCHEMIST_HUT);
            }
            if (Direction == "P")
            {
                World.LocationByID(World.LOCATION_ID_ALCHEMISTS_GARDEN);
            }
            if (Direction == "G")
            {
                World.LocationByID(World.LOCATION_ID_GUARD_POST);
            }
            if (Direction == "B")
            {
                World.LocationByID(World.LOCATION_ID_BRIDGE);
            }
            if (Direction == "S")
            {
                World.LocationByID(World.LOCATION_ID_SPIDER_FIELD);
            }
            if (Direction == "F")
            {
                World.LocationByID(World.LOCATION_ID_FARMHOUSE);
            }
            if (Direction == "V")
            {
                World.LocationByID(World.LOCATION_ID_FARM_FIELD);
            }
            IsMoving = false;
        }
    }
}