class Program
{
    public static void Main()
    {
        Console.WriteLine(@"
  _  ___      _                      _______ _             _____                _        _   _____      _       _   
 | |/ (_)    | |             ___    |__   __| |           / ____|              | |      | | |  __ \    (_)     | |  
 | ' / _ _ __| |__  _   _   ( _ )      | |  | |__   ___  | |     _ __ _   _ ___| |_ __ _| | | |__) | __ _ _ __ | |_ 
 |  < | | '__| '_ \| | | |  / _ \/\    | |  | '_ \ / _ \ | |    | '__| | | / __| __/ _` | | |  ___/ '__| | '_ \| __|
 | . \| | |  | |_) | |_| | | (_>  <    | |  | | | |  __/ | |____| |  | |_| \__ \ || (_| | | | |   | |  | | | | | |_ 
 |_|\_\_|_|  |_.__/ \__, |  \___/\/    |_|  |_| |_|\___|  \_____|_|   \__, |___/\__\__,_|_| |_|   |_|  |_|_| |_|\__|
                     __/ |                                             __/ |                                        
                    |___/                                             |___/                                         
");
        Player player = new Player("Player");
        SuperAdventure game = new SuperAdventure(player);
        Location new_loc = new Location(1, "Town Square", "You see a fountain.", null, null, null);
        Console.WriteLine(new_loc.Description);
        World.PopulateLocations();
        string name = player.CurrentLocation.Name;
        Console.WriteLine(name);
        game.Run();
    }
}
