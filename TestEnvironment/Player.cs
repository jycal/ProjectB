public class Player
{
    // fields
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints = 10;
    public int Gold;
    public int ExperiencePoints;
    public int Level;
    public Weapon CurrentWeapon;
    public Location? CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
    public QuestList QuestLog;
    public CountedItemList Inventory;

    // constructor
    public Player(string name)
    {
        // naam komt uit input van menu
        this.Name = name;
        // begint met 0 levels en 10 goud
        this.Gold = 10;
        this.Level = 0;
        this.ExperiencePoints = 0;
        // begint met rusty zwaart
        this.CurrentWeapon = null!;
        // begint op locatie 1
        // hp op 100 zetten
        this.CurrentHitPoints = 10;
        // inventory en questlog aanmaken
        this.QuestLog = new QuestList();
        this.Inventory = new CountedItemList();
    }

    // methods
    // hp doen/ is alive
    public void LowerPlayerHealth(int damageAmount)
    {
        // hp naar beneden halen
        this.CurrentHitPoints -= damageAmount;
    }

    public void UpPlayerHealth(int healAmount)
    {
        // hp omhoog doen tijdens healen
        this.CurrentHitPoints += healAmount;
    }

    // level en experience points omhoog en omlaag doen
    public void LevelUp(int experiencepoints)
    {
        // experiencepoints omhoog doen
        this.ExperiencePoints += experiencepoints;
        // if exp >= 10 level omhoog en exp weer op 0 zetten
        if (this.ExperiencePoints >= 10)
        {
            this.Level++;
            this.ExperiencePoints = 0;
        }
    }

    // inventory bijhouden
    public void SetInventory()
    {
        // Counteditemlist aanroepen
    }

    public void AddGold(int newGold)
    {
        // nieuw goed toevoegen
        this.Gold += newGold;
    }

}
