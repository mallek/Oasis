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

        public NonPlayerCharter(int id, string name, int maximumDamage, int rewardExperiancePoints, int rewardGold, int currentHitPoints, int maximumHitPoints,  int level) : base(id, currentHitPoints, maximumHitPoints, name, level)
        {
            MaximumDamage = maximumDamage;
            RewardExperiancePoints = rewardExperiancePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }

    }
}
