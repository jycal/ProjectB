public class Quest
{
    // Fields
    public int ID;
    public string Name;
    public string Description;
    public int RewardExperiencePoint;
    public int RewardGold;
    public CountedItemList QuestCompletionItems;

    public Quest(int id, string name, string description, int rewardexperiencepoint, int rewardgold, CountedItemList questcompletionitems)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.RewardExperiencePoint = rewardexperiencepoint;
        this.RewardGold = rewardgold;
        this.QuestCompletionItems = questcompletionitems;
    }
}
