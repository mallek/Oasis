using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Look : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            ReadLocation loc = new ReadLocation();
            loc.ExecuteCommand(args, charter);
            return true;
        }

        public List<string> GetAlias()
        {
            return new List<string> {"l", "Look"};
        }
    }
}
