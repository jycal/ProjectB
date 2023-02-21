
public class SuperAdventure
{
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine(@"
    //   _  ___      _                      _______ _             _____                _        _   _____      _       _   
    //  | |/ (_)    | |             ___    |__   __| |           / ____|              | |      | | |  __ \    (_)     | |  
    //  | ' / _ _ __| |__  _   _   ( _ )      | |  | |__   ___  | |     _ __ _   _ ___| |_ __ _| | | |__) | __ _ _ __ | |_ 
    //  |  < | | '__| '_ \| | | |  / _ \/\    | |  | '_ \ / _ \ | |    | '__| | | / __| __/ _` | | |  ___/ '__| | '_ \| __|
    //  | . \| | |  | |_) | |_| | | (_>  <    | |  | | | |  __/ | |____| |  | |_| \__ \ || (_| | | | |   | |  | | | | | |_ 
    //  |_|\_\_|_|  |_.__/ \__, |  \___/\/    |_|  |_| |_|\___|  \_____|_|   \__, |___/\__\__,_|_| |_|   |_|  |_|_| |_|\__|
    //                      __/ |                                             __/ |                                        
    //                     |___/                                             |___/                                         
    // ");
    //     }
    Player player;
    public SuperAdventure(Player playerMade)
    {
        player = playerMade;
        string intro = $"Welcome to Kirby & TheCrystalPrint. Kirby named {player.Name} must find the way to Walter White, the druglord (alchemist).\n U get out of bed.";
        foreach (char c in intro)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
    }

}
