using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public class HealingPotion : Item
    {
        public HealingPotion(int id, string name, string namePlural, string description, int amountToHeal) : base(id, name, namePlural, description)
        {
            AmountToHeal = amountToHeal;
        }

        public int AmountToHeal { get; set; }

    }
}
