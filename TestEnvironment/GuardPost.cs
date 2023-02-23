class GuardPost
{
    public Player Player;
    public static bool IsCompleted;
    public GuardPost(Player player)
    {
        this.Player = player;
        IsCompleted = false;
    }
    public bool guard_post()
    {
        Console.WriteLine("You have arrived at the gate!");
        Console.WriteLine("Jurn: O Great One who summons me, Terrible One who commands me, I stand by my oath, does thou have the Adventurer's Pass!(Yes/No)");
        string answer = Console.ReadLine()!;
        if (answer == "Yes")
        {
            foreach (CountedItem item in Player.Inventory.TheCountedItemList)
            {
                if (item.TheItem.ID == World.ITEM_ID_ADVENTURER_PASS)
                {
                    Player.Inventory.TheCountedItemList.Remove(item);
                    Console.WriteLine("The item has been removed from your inventory.");
                    IsCompleted = true;
                    return true;
                }
            }
        }
        Console.WriteLine("Jurn: YOU LIED!! NO ENTRY!! COME BACK WHEN YOU HAVE THE PASS!!");
        return false;
    }
}