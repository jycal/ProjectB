using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Farmer
{
    public Player Player;
    public Monster Monster;

    public Farmer(Player player, Monster monster)
    {
        this.Player = player;
        this.Monster = World.MonsterByID(MONSTER_ID_SNAKE);
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
                Monster.Fight(Player);
                if (Monster.Fight(Player) == true)
                {
                    Console.WriteLine("CONGRATULATIONS YOUNG ONE YOU SLAYED THE SNAKES!!");
                    Console.WriteLine($"Birdo: THANK YOU {Player.Name}.\n YOU'VE SAVED MY CROPS!");
                    Console.WriteLine(Heart());
                }
                if (Monster.Fight(Player) == false)
                {
                    Console.WriteLine("OH NO YOU'VE BEEN OVERPOWERED!");
                    Console.WriteLine("BIRDO AND HIS CROPS WILL SUFFER THE WRATH OF YOUR FAILURE!");
                    Menu.Quit();
                }
            }
            if (Direction != "V")
            {
                Console.WriteLine("THOU HAS FAILED US YOUNG PADAWAN!\n YOU WERE THE CHOSEN ONE!");
                Menu.Quit();
            }

            static bool Heart()
            {
                char o = 'o';
                Console.WriteLine("  " + o + o + o + "   " + o + o + o);
                Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
                Console.WriteLine(o + "     " + o + "     " + o);
                Console.WriteLine(o + "     " + " " + "     " + o);
                Console.WriteLine(o + "     " + " " + "     " + o);
                Console.WriteLine(" " + o + "    " + "     " + o);
                Console.WriteLine("  " + o + "   " + "    " + o);
                Console.WriteLine("   " + o + "  " + "   " + o);
                Console.WriteLine("    " + o + "  " + " " + o);
                Console.WriteLine("     " + o + " " + o);
                Console.WriteLine("      " + o);
                return true;
            }


        }
    }

}