using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public class PlayerCharacter : Character
    {
        public Dictionary<string, Type> CommandDictionary { get; set; }
        public int Gold { get; set; }
        public int ExperiancePoints { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<Quest> Quests { get; set; }
        public Location CurrentLocation { get; set; }

        public NonPlayerCharacter NonPlayerCharacterFighting { get; set; }

        public PlayerCharacter(int id, int currentHitPoints, int maximumHitPoints, string name, int level, int gold, int experiancePoints) : base(id, currentHitPoints, maximumHitPoints, name, level)
        {
            Gold = gold;
            ExperiancePoints = experiancePoints;
            Inventory = new List<InventoryItem>();
            Quests = new List<Quest>();
            CommandDictionary = new Dictionary<string, Type>(StringComparer.InvariantCultureIgnoreCase);
        }

        public bool IsPlayerStillAlive()
        {
            if (CurrentHitPoints > 0)
            {
                return true;
            }

            return false;

        }




    }
}
