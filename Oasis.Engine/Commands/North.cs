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
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            if (charter.CurrentLocation.LocationToNorth != null)
            {
                charter.CurrentLocation = charter.CurrentLocation.LocationToNorth;
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

            results.Add("N");
            results.Add("North");

            return results;
        } 
    }
}
