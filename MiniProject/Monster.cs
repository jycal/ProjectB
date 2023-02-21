
public class Monster
{
    // Fields
    public int ID;

    public static string? Name;

    public static string? NamePlural;

    public static int MaximumDamage = 3;

    public static int MinimumDamage = 0;

    public static int RewardGold = 5;

    public CountedItemList? Loot;

    public static int CurrentHitPoints = 14;

    public static int MaximumHitPoints = 14;

    public Monster(int id, string name, string namePlural, int maximumDamage, int minimumDamage, int rewardGold, int currentHitPoints, int maximumHitPoints)
    {
        ID = id;
        Name = name;
        NamePlural = namePlural;
        MaximumDamage = maximumDamage;
        MinimumDamage = minimumDamage;
        RewardGold = rewardGold;
        Loot = new CountedItemList();
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }

    public int DoDamage()
    {
        Random attackRange = new Random();
        // random damage kiezen tussn min en max
        int damageValue = attackRange.Next(1, MaximumDamage);
        // damage van monster hp afhalen

        // via class monster of gwn int returnen?
        return damageValue;
    }

    public void Stats()
    {
        Console.WriteLine("The {0} {1}'s Stats:", Name, NamePlural);
        Console.WriteLine("HP: {0}", CurrentHitPoints);
        Console.WriteLine("Attack: {0}", DoDamage());
    }
}
