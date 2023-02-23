using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class AlchemistQuest
{
    public Player Player;
    public Monster Monster;
    public static bool IsCompleted;

    public AlchemistQuest(Player player, Monster monster)
    {
        this.Player = player;
        this.Monster = World.MonsterByID(1);
        IsCompleted = false;
    }

    public void Story()
    {
        Console.WriteLine($"Walter White: {Player.Name} THOU HAS ARRIVED AT THE ALCHEMIST'S HUT!");
        Console.WriteLine("Walter White: Those rats art nibbling on mine own h'rbs! I couldst very much useth an adventur'r to taketh careth of those folk.​");
        Console.WriteLine($"Will u {Player.Name} help Walter White and DESTROY the rats? Yeah or Nah?");
        string? answer = Convert.ToString(Console.ReadLine()!.ToUpper());
        if (answer == "YEAH")
        {
            Console.WriteLine($"You are at {Player.CurrentLocation!.Name}.");
            Console.WriteLine($"    P\n    A\nV F T G B S\n    H\n");
            Console.WriteLine("Enter 'P' to go to the Alchemist's garden.");
            string Direction = Convert.ToString(Console.ReadLine()!.ToUpper());
            if (Direction == "P")
            {
                Player.CurrentLocation = World.LocationByID(5);
                Console.WriteLine("U HAVE CHOSEN YOUNG ONE!");
                Console.WriteLine("Be prepared for the dangers thay lie ahead....");
                Console.WriteLine("You enter the garden.\nAs you slowly enter the garden something runs at your feet...");
                Console.WriteLine("You get in position.\nThe battle of a lifetime is going to begin.");
                Monster.Fight(Player);
                if (Monster.Fight(Player) == true)
                {
                    Console.WriteLine("CONGRATULATIONS YOUNG ONE YOU SLAYED THE RATS!!");
                    // snake fangs ontvangen
                    Console.WriteLine("You obtained 3 Rat tails");
                    Item snakeFang = World.ItemByID(World.ITEM_ID_SNAKE_FANG);
                    CountedItem farmerLoot = new CountedItem(snakeFang, 1);
                    Player.Inventory.TheCountedItemList.Add(farmerLoot);
                    Console.WriteLine($"Walter White: THANK YOU {Player.Name}.\n YOU'VE SAVED MY GARDEN! <3");
                    // AlchemistQuest.Heart();
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
                    Console.WriteLine("\n");
                    // snake fangs weggeven
                    IsCompleted = true;
                    Console.WriteLine("You hand over the 3 rat tails you collected from your battle!");
                    foreach (CountedItem item in Player.Inventory.TheCountedItemList)
                    {
                        if (item.TheItem.ID == World.ITEM_ID_RAT_TAIL && item.Quantity >= 3)
                        {
                            Player.Inventory.TheCountedItemList.Remove(item);
                            break;
                        }
                    }
                    // Club ontvangen
                    Console.WriteLine("Walter White hands you over a club!\n");
                    Weapon club = World.WeaponByID(World.WEAPON_ID_CLUB);
                    Player.CurrentWeapon = club;
                }
                if (Monster.Fight(Player) == false)
                {
                    Console.WriteLine("OH NO YOU'VE BEEN OVERPOWERED!");
                    Console.WriteLine("Walter White AND HIS METH WILL SUFFER THE WRATH OF YOUR FAILURE!");
                    Menu.Quit();
                }
            }
            if (Direction != "P")
            {
                Console.WriteLine("THOU HAS FAILED US YOUNG PADAWAN!\n YOU WERE THE CHOSEN ONE!");
                Menu.Quit();
            }




        }
    }

    public static void Heart()
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
        Console.WriteLine("\n");
    }

}