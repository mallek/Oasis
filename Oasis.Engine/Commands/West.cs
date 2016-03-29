using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class West : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            if (charter.CurrentLocation.LocationToWest != null)
            {
                charter.CurrentLocation = charter.CurrentLocation.LocationToWest;
                ReadLocation readLocation = new ReadLocation();
                readLocation.ExecuteCommand(null, charter);
                return true;
            }

            Console.WriteLine("You cannot go that way");
            return false;
        }

        public List<string> GetAlias()
        {
            List<string> results = new List<string>();
            results.Add("W");
            return results;
        }
    }
}
