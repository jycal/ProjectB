
public class Monster
{
    // Fields
    public static int ID;

    public static string Name;

    public static string NamePlural;

    public static int MaximumDamage = 3;
    public static int RewardGold = 5;

    public static CountedItemList Loot;

    public static int CurrentHitPoints = 14;

    public Monster()
    {
        this.ID = ID;
        this.Name = Name;
        this.Loot = Loot;
    }

    public int DoDamage()
    {
        Random attackRange = new Random();
        // random damage kiezen tussn min en max
        int damageValue = attackRange.Next(1, this.MaximumDamage);
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
