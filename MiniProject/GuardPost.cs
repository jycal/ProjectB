class GuardPost
{
    public Player Player;

    public GuardPost(Player player)
    {
        this.Player = player;
    }
    public bool guard_post()
    {
        Console.WriteLine("You have arrived at the gate!");
        Console.WriteLine("Jurn: O Great One who summons me, Terrible One who commands me, I stand by my oath, does thou have the Adventurer's Pass!(Y/N)");
        string answer = Console.ReadLine();
        if (answer == "Yes")
        {
            foreach (CountedItem item in Player.Inventory.TheCountedItemList)
            {
                if (item.TheItem.ID == World.ITEM_ID_ADVENTURER_PASS)
                {
                    Player.Inventory.TheCountedItemList.Remove(item);
                    Console.WriteLine("The item has been removed from your inventory.")
                    return true;
                }
            }
        }
        Console.WriteLine("Jurn: YOU LIED!! NO ENTRY!!");
        return false;
    }
}