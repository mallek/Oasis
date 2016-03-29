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
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            if (character.Inventory.Count == 0)
            {
                Console.WriteLine("You do not have any items");
                return false;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*****************************************************************************");
            sb.AppendLine($"|  Inventory for {character.Name} ");
            sb.AppendLine($"*****************************************************************************");
            sb.AppendLine($"|");

            foreach (InventoryItem inventoryItem in character.Inventory)
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
            return new List<string> {"I", "Inv", "Inventory"};
           
        }
    }
}
