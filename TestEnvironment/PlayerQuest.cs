public class PlayerQuest
{
    public Quest TheQuest;
    public bool IsCompleted;

    public PlayerQuest(Quest quest, bool iscompleted)
    {
        this.TheQuest = quest;
        this.IsCompleted = iscompleted;
    }
}