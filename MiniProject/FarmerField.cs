class Farmer
{
    public Player Player;

    public Farmer(Player player)
    {
        this.Player = player;
    }

    public void Story()
    {
        Console.WriteLine($"Birdo: {Player.Name} THOU HAS ARRIVED AT THE BIRDO'S FARM HOUSE!");
        Console.WriteLine("Birdo: I can't w'rk mine own landeth with those pesky snakes slith'ring 'round! Shall thee holp me?");
        Console.WriteLine($"Will u {Player.Name} help Birdo and slayy his snakes? Yeah or Nah?");
        string? answer = Convert.ToString(Console.ReadLine());
        if (answer == "Yeah")
        {
            Console.WriteLine($"You are at {Player.CurrentLocation!.Name}.");
            Console.WriteLine($"  P\n  A\n V F T G B S\n   H");
            Console.WriteLine("Enter 'V' to go to the Birdo's field.");
            string Direction = Convert.ToString(Console.ReadLine()!);
            if (Direction == "V")
            {
                Player.CurrentLocation = World.LocationByID(World.LOCATION_ID_FARM_FIELD);
                Console.WriteLine("U HAVE CHOSEN YOUNG ONE!");
                Console.WriteLine("Be prepared for the dangers thay lie ahead....");
                Console.WriteLine("You enter the field.\n As you slowly enter the field something slithers at your feet...");
                Console.WriteLine("You get in position.\n The battle of a lifetime is going to begin.");

            }
            if (Direction != "V")
            {
                Console.WriteLine("THOU HAS FAILED US YOUNG PADAWAN!\n YOU WERE THE CHOSEN ONE!");
                Menu.Quit();
            }


        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }

}