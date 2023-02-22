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
        // bool itemGot = false;
        // intro
        Console.WriteLine($"After crossing the bridge you have arrived at the {Player.CurrentLocation!.Name}");
        Console.WriteLine($"You: “I shalt releaseth the town folks of their feareth!”");

        // vechten met spider
        Console.WriteLine($"Are you ready to fight the {Monster.Name} (Y/N)");
        string answer = Console.ReadLine()!.ToUpper();
        if (answer == "Y")
        {

            Monster.Fight(Player);
            // if (Monster.Fight(Player) == true)
            // {
            //     itemGot = true;
            // }

        }


        // spider silk ontvangen






    }

    public void EndSpiderQuest()
    {
        // teruggaan naar de bridge
        Console.WriteLine($"You go back to the bridge after defeating the {Monster.NamePlural}");


        // winner medal ontvangen

    }


}
