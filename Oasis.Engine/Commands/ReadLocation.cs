using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class ReadLocation : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            Console.WriteLine(character.CurrentLocation.Description);
            DisplayExits(character.CurrentLocation);
            DisplayMobs(character.CurrentLocation);
            return true;
        }

        private void DisplayMobs(Location currentLocation)
        {
            if (currentLocation.NonPlayerCharacterHere != null)
            {
                Console.WriteLine($"{currentLocation.NonPlayerCharacterHere.Name} is here.");
            }
        }

        private void DisplayExits(Location currentLocation)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            if (currentLocation.LocationToNorth != null)
                sb.Append("North ");
            if (currentLocation.LocationToEast != null)
                sb.Append("East ");
            if (currentLocation.LocationToSouth != null)
                sb.Append("South ");
            if (currentLocation.LocationToWest != null)
                sb.Append("West ");
            sb.Append("]");

            Console.WriteLine(sb.ToString());
        }

        public List<string> GetAlias()
        {
            return new List<string>();
            //results.Add("L");
            //results.Add("Look");
            
        }
    }
}
