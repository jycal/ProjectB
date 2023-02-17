using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monster
{
    public class Quests
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item RewardItem { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public QuestCompletionItem QuestCompletionItem { get; set; }

        public Quests(int id, string name, string description, Item rewardItem, int rewardExperiencePoints, int rewardGold, QuestCompletionItem questCompletionItem)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardItem = rewardItem;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            QuestCompletionItem = questCompletionItem;
        }
    }
}