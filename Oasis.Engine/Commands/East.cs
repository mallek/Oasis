using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class East : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            if (charter.CurrentLocation.LocationToEast != null)
            {
                charter.CurrentLocation = charter.CurrentLocation.LocationToEast;
                ReadLocation readLocation = new ReadLocation();
                readLocation.ExecuteCommand(null, charter);
                return true;
            }

            Console.WriteLine("You cannot go that way");
            return false;
        }
    }
}
