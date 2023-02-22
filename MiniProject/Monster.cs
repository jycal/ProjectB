
public class Monster
{
    // Fields
    public int ID;

    public string? Name;

    public string? NamePlural;

    public int MaximumDamage = 3;

    public int MinimumDamage = 0;

    public int RewardGold = 5;

    public CountedItemList? Loot;

    public int CurrentHitPoints = 14;

    public int MaximumHitPoints = 14;

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
    public void Fight(Player player)
    {
        // bool gameOver = false;
        Console.WriteLine("A wild {0} appears!", this.Name);
        Console.WriteLine("Prepare to fight!\n");
        // Continue the fight until either the player or the monster has 0 HP
        while (player.CurrentHitPoints > 0 && this.CurrentHitPoints > 0)
        {
            // Prompt the player to choose an attack
            Console.WriteLine("Choose your attack:");
            Console.WriteLine("1. Attack with {0}", player.CurrentWeapon.Name);
            Console.WriteLine("2. Use a healing potion");
            Console.WriteLine("3. Run away");

            // Get the player's choice
            int choice = Convert.ToInt32(Console.ReadLine());

            // Attack the monster
            if (choice == 1)
            {
                // Calculate the player's damage
                int playerDamage = Weapon.DoWeaponDamage();
                Console.WriteLine("You attack the {0} with your {1} for {2} damage!", this.Name, player.CurrentWeapon.Name, playerDamage);

                // Subtract the damage from the monster's HP
                this.CurrentHitPoints -= playerDamage;
            }
            // Heal the player
            else if (choice == 2)
            {
                player.UpPlayerHealth(10);
                Console.WriteLine("You drink a healing potion and restore 10 HP. Your current HP is {0}.", player.CurrentHitPoints);
            }
            // Player runs away
            else if (choice == 3)
            {
                Console.WriteLine("You run away from the {0}!", this.Name);
                return;
            }

            // Check if the monster is dead
            if (this.CurrentHitPoints <= 0)
            {
                Console.WriteLine("You have defeated the {0}!", this.Name);
                player.AddGold(this.RewardGold);
                // item bool meegeven
                // bool itemGot = true;
                return;
            }

            // Monster attacks the player
            int monsterDamage = this.DoDamage();
            Console.WriteLine("The {0} attacks you for {1} damage!", this.Name, monsterDamage);

            // Subtract the damage from the player's HP
            player.LowerPlayerHealth(monsterDamage);

            // Check if the player is dead
            if (player.CurrentHitPoints <= 0)
            {
                Console.WriteLine("You have been defeated by the {0}. Game over!", this.Name);
                // gameOver = true;
                return;
            }
        }
    }
}
