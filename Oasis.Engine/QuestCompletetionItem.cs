using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public class QuestCompletetionItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public QuestCompletetionItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
