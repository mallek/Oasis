using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public class Charter
    {
        public int ID { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaximimHitPoints { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public Charter(int id, int currentHitPoints, int maximumHitPoints, string name, int level)
        {
            ID = id;
            CurrentHitPoints = currentHitPoints;
            MaximimHitPoints = maximumHitPoints;
            Name = name;
            Level = level;
        }
    }
}
