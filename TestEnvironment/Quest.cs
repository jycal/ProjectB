public class Quest
{
    // Fields
    public int ID;
    public string Name;
    public string Description;
    public int RewardExperiencePoint;
    public int RewardGold;
    public Item RewardItem;
    public Weapon RewardWeapon;
    public CountedItemList QuestCompletionItems;

    public Quest(int id, string name, string description, int rewardexperiencepoint, int rewardgold, Item? rewarditem = null!, Weapon rewardweapon = null!)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.RewardExperiencePoint = rewardexperiencepoint;
        this.RewardGold = rewardgold;
        this.RewardItem = rewarditem!;
        this.RewardWeapon = rewardweapon!;
        this.QuestCompletionItems = null!;
    }
}
