using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Exit : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            charter.CurrentHitPoints = 0;
            return true;
        }

        public List<string> GetAlias()
        {
            List<string> results = new List<string>();
            results.Add("Exit");
            results.Add("Quit");
            return results;
        }
    }
}
