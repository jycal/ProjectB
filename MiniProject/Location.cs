class Location
{
    public int ID;
    public string Name;
    public string Description;

    public Item ItemRequiredToEnter;

    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;

    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location()
    {
        this.X = 0;
        this.Y = 0;
    }

    public void Move()
    {
        while (Move == true)
        {
            Console.Writeline("Where would you like to go?");
            Console.Writeline($"You are at {Player.CurrentLocation}. From here you can go:");
            Console.Writeline($"  P\n  A\n V F T G B S\n   H");
            string Direction = Convert.ToString(Console.Readline());
            if (Direction == "T")
            {
                CurrentLocation(0, 1);
            }
            if (Direction == "A")
            {
                CurrentLocation(0, 2);
            }
            if (Direction == "P")
            {
                CurrentLocation(0, 3);
            }
            if (Direction == "G")
            {
                CurrentLocation(1, 1);
            }
            if (Direction == "B")
            {
                CurrentLocation(2, 1);
            }
            if (Direction == "S")
            {
                CurrentLocation(3, 1);
            }
            if (Direction == "F")
            {
                CurrentLocation(-1, 1);
            }
            if (Direction == "V")
            {
                CurrentLocation(-2, 1);
            }
        }
    }

    public void CurrentLocation(int X, int Y)
    {
        // Dit moet naar de Player Class
        switch (X, Y)
        {
            // ID bepalen bij coordinaat van x en y.
            // Town Square
            case (0, 1):
                {
                    int ID = 2;
                    break;
                }
            // Alchemist Hut
            case (0, 2):
                {
                    int ID = 4;
                    break;
                }
            // Alchemist Garden
            case (0, 3):
                {
                    int ID = 5;
                    break;
                }
            // Guard Post
            case (1, 1):
                {
                    int ID = 3;
                    break;
                }
            // Bridge
            case (2, 1):
                {
                    int ID = 8;
                    break;
                }
            // Spider Forest
            case (3, 1):
                {
                    int ID = 9;
                    break;
                }
            // Farmhouse
            case (-1, 1):
                {
                    int ID = 6;
                    break;
                }
            // Farm Field
            case (-2, 1):
                {
                    int ID = 7;
                    break;
                }
                // Loop om locatie en description uit de lijst te halen.
                foreach (Location locatie in World.Locations)
                {
                    switch (ID)
                    {
                        case (ID == 1):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                        case (ID == 2):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                        case (ID == 3):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                        case (ID == 4):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                        case (ID == 5):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                        case (ID == 6):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                        case (ID == 7):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                        case (ID == 8):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                        case (ID == 9):
                            {
                                this.ID = locatie.ID;
                                this.Name = locatie.Name;
                                this.Description = locatie.Description;
                            }
                    }
                }
        }
    }
}