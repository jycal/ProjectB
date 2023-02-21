
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
