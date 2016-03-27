using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public class Weapon: Item
    {
        public Weapon(int id, string name, string namePlural, string description, int minimumDamage, int maximumDamage) : base(id, name, namePlural, description)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

    }
}
