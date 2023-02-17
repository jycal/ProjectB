using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject
{
    public class Player
    {
        // fields
        public string Name;
        public int CurrentHitPoints;
        public int MaximumHitPoints;
        public int Gold;
        public int ExperiencePoints;
        public int Level;
        public Weapon CurrentWeapon;
        public Location CurrentLocation;
        public QuestLog Questlist;
        public CountedItemList Inventory;

        // constructor
        public Player(string name)
        {
            // naam komt uit input van menu
            this.Name = name;
            // begint met 0 levels en 10 goud
            this.Gold = 10;
            this.Level = 0;
            this.ExperiencePoints = 0;
            // begint met rusty zwaart
            this.CurrentWeapon = Weapon;
            // begint op locatie 1
            this.CurrentLocation = World.LOCATION_ID_HOME;
        }

        // methods


        // hp doen/ is alive

        // level en experience points omhoog en omlaag doen
    }
}