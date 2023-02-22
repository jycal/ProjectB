
public class SuperAdventure
{
    // fields
    private Player _player;
    private Monster _monster;
    private bool _gameOver;

    // constructor
    public SuperAdventure(Player player)
    {
        // player aanmaken
        _player = player;
        DateTime now = DateTime.Now;
        string formattedTime = now.ToString("hh:mm tt");
        string intro = $@"Welcome to Kirby & The Crystal Print. Kirby named {player.Name} must find the way to Walter White, the druglord (alchemist).
Current location: {player.CurrentLocation.Name}, it is currently {formattedTime}
Time to get out of bed..
";
        foreach (char c in intro)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
        Menu menuScreen = new Menu("Title", "Description", 1, 2, 3, 4);
        menuScreen.Screen();
        // World.PopulateLocations();
        // Menu.Screen();
        // // game over op false zetten
        // _gameOver = false;
    }

    // methods
    //vanaf hier totMonster.CurrentHitPoints
    public void Fight(Monster monster)
    {
        _monster = monster;
        Console.WriteLine("A wild {0} appears!", Monster.Name);
        Console.WriteLine("Prepare to fight!\n");
        // Continue the fight until either the player or the monster has 0 HP
        while (_player.CurrentHitPoints > 0 && Monster.CurrentHitPoints > 0)
        {
            // Prompt the player to choose an attack
            Console.WriteLine("Choose your attack:");
            Console.WriteLine("1. Attack with {0}", _player.CurrentWeapon.Name);
            Console.WriteLine("2. Use a healing potion");
            Console.WriteLine("3. Run away");

            // Get the player's choice
            int choice = Convert.ToInt32(Console.ReadLine());

            // Attack the monster
            if (choice == 1)
            {
                // Calculate the player's damage
                int playerDamage = _player.CurrentWeapon.MaximumDamage;
                Console.WriteLine("You attack the {0} with your {1} for {2} damage!", Monster.Name, _player.CurrentWeapon.Name, playerDamage);

                // Subtract the damage from the monster's HP
                Monster.CurrentHitPoints -= playerDamage;
            }
            // Heal the player
            else if (choice == 2)
            {
                _player.UpPlayerHealth(10);
                Console.WriteLine("You drink a healing potion and restore 10 HP. Your current HP is {0}.", _player.CurrentHitPoints);
            }
            // Player runs away
            else if (choice == 3)
            {
                Console.WriteLine("You run away from the {0}!", Monster.Name);
                return;
            }

            // Check if the monster is dead
            if (Monster.CurrentHitPoints <= 0)
            {
                Console.WriteLine("You have defeated the {0}!", Monster.Name);
                _player.AddGold(Monster.RewardGold);
                return;
            }

            // Monster attacks the player
            int monsterDamage = monster.DoDamage();
            Console.WriteLine("The {0} attacks you for {1} damage!", Monster.Name, monsterDamage);

            // Subtract the damage from the player's HP
            _player.LowerPlayerHealth(monsterDamage);

            // Check if the player is dead
            if (_player.CurrentHitPoints <= 0)
            {
                Console.WriteLine("You have been defeated by the {0}. Game over!", Monster.Name);
                _gameOver = true;
                return;
            }
        }
    }
    // hier
    // game loop
    public void Run()
    {
        // game loop

        // while (!_gameOver)
        // {
        //     // game loop
        //     Console.WriteLine("Game loop!!!!!!!!!");
        //     // string Discription = World.LocationByID(1).Description;
        //     // Console.WriteLine(Discription);
        //     _gameOver = true;
        // }
    }
}
