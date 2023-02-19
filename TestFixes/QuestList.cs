public class QuestList
{
    // List of quests the player has
    public List<PlayerQuest> QuestLog;

    public QuestList()
    {
        this.QuestLog = new List<PlayerQuest>();
    }

    // Add a quest to the quest log
    public void AddQuest(PlayerQuest quest)
    {
        QuestLog.Add(quest);
    }

    // Remove a quest from the quest log
    public void RemoveQuest(PlayerQuest quest)
    {
        QuestLog.Remove(quest);
    }
}
