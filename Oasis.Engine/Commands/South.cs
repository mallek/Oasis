using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class South : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            if (charter.CurrentLocation.LocationToSouth != null)
            {
                charter.CurrentLocation = charter.CurrentLocation.LocationToSouth;
                ReadLocation readLocation = new ReadLocation();
                readLocation.ExecuteCommand(null, charter);
                return true;
            }

            Console.WriteLine("You cannot go that way");
            return false;
        }

        public List<string> GetAlias()
        {
            return new List<string> {"S", "South"};
        }
    }
}
