using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class SpiderQuest
{
    // fields
    public Player Player;

    public Monster Monster;

    // constructor
    public SpiderQuest(Player player, Monster monster)
    {
        this.Player = player;
        this.Monster = monster;
    }


    // methods
    public void StartSpiderQuest()
    {

        // intro
        Console.WriteLine($"After crossing the bridge you have arrived at the {Player.CurrentLocation!.Name}");
        Console.WriteLine($"You: “I shalt releaseth the town folks of their feareth!”");
        Console.WriteLine($"Janneke The Spider: “AND WHO MIGHT THOU BE?”");
        Console.WriteLine($"You: “I'm the one who's gonna lay the smackdown on you.”");

        // vechten met spider
        Console.WriteLine($"Are you ready to fight the {Monster.Name} (Y/N)");
        string answer = Console.ReadLine()!.ToUpper();
        if (answer == "Y")
        {

            Monster.Fight(Player);
            if (Monster.Fight(Player) == true)
            {
                // spider silk ontvangen
                Item spidersilk = World.ItemByID(World.ITEM_ID_SPIDER_SILK);
                CountedItem spiderLoot = new CountedItem(spidersilk, 1);
                Player.Inventory.TheCountedItemList.Add(spiderLoot);

            }

        }
        else
        {
            Console.WriteLine($"Janneke The Spider: “WHY IS THOU RUNNING AWAY!!!”");
            Console.WriteLine("You can't run away from the spiders. One bites you immediately killing you.\nGAME OVER");
            Menu.Quit();
        }




    }

    public void EndSpiderQuest()
    {
        // teruggaan naar de bridge
        Console.WriteLine($"You go back to the bridge after defeating the {Monster.NamePlural}");

        // spider silk uit items halen
        foreach (CountedItem item in Player.Inventory.TheCountedItemList)
        {
            if (item.TheItem.ID == World.ITEM_ID_SPIDER_SILK && item.Quantity >= 3)
            {
                Player.Inventory.TheCountedItemList.Remove(item);
                Console.WriteLine("The item has been removed from your inventory.");
                break;
            }
        }
        // winner medal ontvangen
        Console.WriteLine("CONGRATS YOU HAVE OBTAINED THE WINNERS MEDAL!!");
        Console.WriteLine("Only fit for a true WARRIOR!");
        Item winnermedal = World.ItemByID(World.ITEM_ID_WINNERS_MEDAL);
        CountedItem winnerLoot = new CountedItem(winnermedal, 1);
        Player.Inventory.TheCountedItemList.Add(winnerLoot);

    }


}
