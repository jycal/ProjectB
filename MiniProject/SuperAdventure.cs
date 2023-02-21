
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
        string intro = $@"Welcome to Kirby & TheCrystalPrint. Kirby named {player.Name} must find the way to Walter White, the druglord (alchemist).
Current location: {player.CurrentLocation.Name}, it is currently {now.Hour}:{now.Minute}
Time to get out of bed.";
        foreach (char c in intro)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
        // game over op false zetten
        _gameOver = false;
    }

    // methods
    // game loop
    public void Run()
    {
        // game loop
        while (!_gameOver)
        {
            // game loop
            Console.WriteLine("Game loop!!!!!!!!!");
            // string Discription = World.LocationByID(1).Description;
            // Console.WriteLine(Discription);
            _gameOver = true;
        }
    }
}
