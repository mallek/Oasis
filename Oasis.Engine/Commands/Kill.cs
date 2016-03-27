using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Kill : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Kill What?");
                return false;
            }

            if (charter.CurrentLocation.NonPlayerCharterHere == null)
            {
                Console.WriteLine("There is nothing here to kill");
                return false;
            }

            if (charter.CurrentLocation.NonPlayerCharterHere.Name.ToLower() != args[1].ToLower())
            {
                Console.WriteLine("You do not see that here");
                return false;
            }

            Console.WriteLine("Killing " + args[1]);
                

            return true;
        }
    }
}
