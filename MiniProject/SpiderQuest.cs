using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject
{
    public class SpiderQuest
    {
        // fields
        public Player Player;

        // constructor
        public SpiderQuest(Player player)
        {
            this.Player = player;
        }


        // methods
        public void StartSpiderQuest()
        {
            // intro
            Console.WriteLine($"After crossing the bridge you have arrived at the {Player.CurrentLocation!.Name}");
            Console.WriteLine($"");

            // vechten met spider


            // spider silk ontvangen




        }

        public void EndSpiderQuest()
        {
            // teruggaan naar de bridge

            // winner medal ontvangen

        }


    }
}