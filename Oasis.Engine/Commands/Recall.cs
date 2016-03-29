using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Recall : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            character.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
            ReadLocation readLocation = new ReadLocation();
            readLocation.ExecuteCommand(null, character);
            return true;
        }

        public List<string> GetAlias()
        {
            return new List<string> {"Rec", "Recall", "/"};
        }
    }
}
