using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPresentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            DropPresentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }

    }
}
