using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public class NonPlayerCharter : Charter
    {

        public int MaximumDamage { get; set; }
        public int RewardExperiancePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }
        public List<Item> CurrentLoot { get; }

        public NonPlayerCharter(int id, string name, int maximumDamage, int rewardExperiancePoints, 
            int rewardGold, int currentHitPoints, int maximumHitPoints,  int level) 
            : base(id, currentHitPoints, maximumHitPoints, name, level)
        {
            MaximumDamage = maximumDamage;
            RewardExperiancePoints = rewardExperiancePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
            
        }

        public NonPlayerCharter(NonPlayerCharter npc) 
            : base(npc.ID, npc.CurrentHitPoints, npc.MaximimHitPoints, npc.Name, npc.Level)
        {
            this.MaximumDamage = npc.MaximumDamage;
            this.RewardExperiancePoints = npc.RewardExperiancePoints;
            this.RewardGold = npc.RewardGold;
            this.CurrentLoot = GenerateLoot(npc.LootTable);
        }

        private List<Item> GenerateLoot(List<LootItem> lootTable)
        {
            List<Item> Results = new List<Item>();
            foreach (LootItem item in lootTable)
            {
                if (RandomNumberGenerator.NumberBetween(0, 100) < item.DropPresentage)
                {
                    Results.Add(item.Details);
                }
            }
            return Results;
        }
    }
}
