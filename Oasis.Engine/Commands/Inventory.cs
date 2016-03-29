using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Inventory : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            if (charter.Inventory.Count == 0)
            {
                Console.WriteLine("You do not have any items");
                return false;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*****************************************************************************");
            sb.AppendLine($"|  Inventory for {charter.Name} ");
            sb.AppendLine($"*****************************************************************************");
            sb.AppendLine($"|");

            foreach (InventoryItem inventoryItem in charter.Inventory)
            {
                sb.AppendLine(inventoryItem.Quantity > 1
                    ? $"| [{inventoryItem.Quantity}] - {inventoryItem.Details.NamePlural}"
                    : $"| [{inventoryItem.Quantity}] - {inventoryItem.Details.Name}");
            }

            Console.WriteLine(sb.ToString());


            return true;
        }

        public List<string> GetAlias()
        {
            List<string> results = new List<string>();
            results.Add("I");
            results.Add("Inv");
            return results;
        }
    }
}
