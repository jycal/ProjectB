public class CountedItemList
{
    // Fields
    public List<CountedItem> TheCountedItemList;

    public CountedItemList()
    {
        this.TheCountedItemList = new List<CountedItem>();
    }

    // Add an item to the list
    public void AddItem(Item item, int quantity = 1)
    {
        if (TheCountedItemList.Exists(x => x.TheItem.ID == item.ID))
        {
            foreach (CountedItem counteditem in TheCountedItemList)
            {
                if (counteditem.TheItem.ID == item.ID)
                {
                    counteditem.Quantity += quantity;
                    break;
                }
            }
        }
        else
        {
            TheCountedItemList.Add(new CountedItem(item, quantity));
        }
    }

    // Remove an item from the list
    public void RemoveItem(Item item, int quantity = 1)
    {
        foreach (CountedItem counteditem in TheCountedItemList)
        {
            if (counteditem.TheItem.ID == item.ID)
            {
                if (counteditem.Quantity > quantity)
                {
                    counteditem.Quantity -= quantity;
                }
                else
                {
                    TheCountedItemList.Remove(counteditem);
                }
                break;
            }
        }
    }
}
