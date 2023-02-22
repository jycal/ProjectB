
public class SuperAdventure
{
    // fields
    private Player _player;
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
Time to get out of bed.
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
