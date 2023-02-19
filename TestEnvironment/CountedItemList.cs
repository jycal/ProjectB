public class CountedItemList
{
    // Fields
    public List<CountedItem> TheCountedItemList;

    public CountedItemList()
    {
        this.TheCountedItemList = new List<CountedItem>();
    }

    // Add an item to the list
    public void AddItem(Item item)
    {
        foreach (CountedItem counteditem in TheCountedItemList)
        {
            if (counteditem.TheItem.ID == item.ID)
            {
                counteditem.Quantity++;
                return;
            }
        }

        // If we get here, the item was not found in the list, so add it
        TheCountedItemList.Add(new CountedItem(item, 1));
    }

    public void AddCountedItem(CountedItem item, int count = 1)
    {
        foreach (CountedItem counteditem in TheCountedItemList)
        {
            if (counteditem.TheItem.ID == item.TheItem.ID)
            {
                counteditem.Quantity += count;
                return;
            }
        }

        // If we get here, the item was not found in the list, so add it
        TheCountedItemList.Add(new CountedItem(item.TheItem, count));
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
