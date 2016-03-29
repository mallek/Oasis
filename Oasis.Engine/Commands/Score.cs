using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Score : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*****************************************************************************");
            sb.AppendLine($"|  Score for {charter.Name} ");
            sb.AppendLine($"*****************************************************************************");
            sb.AppendLine($"|");
            sb.AppendLine($"|  HP:{charter.CurrentHitPoints}/{charter.MaximimHitPoints} " +
                      $"| Exp:{charter.ExperiancePoints} " +
                      $"| Gold:{charter.Gold}");
            sb.AppendLine($"|");
            sb.AppendLine($"*****************************************************************************");
            Console.WriteLine(sb.ToString());
            
            return true;
        }

        public List<string> GetAlias()
        {
            return  new List<string> {"Score", "Sco"};
        }
    }
}
