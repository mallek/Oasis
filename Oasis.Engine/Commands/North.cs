using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class North : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            if (character.CurrentLocation.LocationToNorth != null)
            {
                character.CurrentLocation = character.CurrentLocation.LocationToNorth;
                ReadLocation readLocation = new ReadLocation();
                readLocation.ExecuteCommand(null, character);
                return true;
            }

            Console.WriteLine("You cannot go that way");
            return false;

        }

        public List<string> GetAlias()
        {
            return new List<string> {"N", "North"};
            
        } 
    }
}
