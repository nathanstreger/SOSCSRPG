using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            // Quest number 1 : kill the snakes in the garden
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            _quests.Add(new Quest(1,
                "Clear the Herb Garden",
                "Defeat the Snakes in the Herbalist's garden.",
                itemsToComplete,
                25, 10,
                rewardItems));

            // Quest number 2 : kill the rats in the farmer's field
            List<ItemQuantity> itemsToComplete2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems2 = new List<ItemQuantity>();

            itemsToComplete2.Add(new ItemQuantity(9003, 5));
            rewardItems2.Add(new ItemQuantity(1003, 1));

            _quests.Add(new Quest(2,
                "Clear the Farmer's Field",
                "Clear the Rats from the Farmer's crop field.",
                itemsToComplete2,
                30, 15,
                rewardItems2
                ));

            // Quest Number 3 : Kill the giant spider in the forest.
            List<ItemQuantity> itemsToComplete3 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems3 = new List<ItemQuantity>();

            itemsToComplete3.Add(new ItemQuantity(9005, 5));
            rewardItems3.Add(new ItemQuantity(1004, 1));

            _quests.Add(new Quest(3,
                "Clear the Forest's Edge.",
                "Clear the Forest's Edge of Giant Spiders",
                itemsToComplete3,
                100, 75,
                rewardItems3
                ));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
