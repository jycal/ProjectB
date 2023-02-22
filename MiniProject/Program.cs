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

        string text = "What is your name? ";
        foreach (char c in text)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(c);
            Thread.Sleep(40);
        }
        Console.WriteLine();
        string name = Console.ReadLine()!;



        Player PlayerOne = new Player(name);
        SuperAdventure super = new SuperAdventure(PlayerOne);
        super.Run();
    }

}
