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
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*****************************************************************************");
            sb.AppendLine($"|  Score for {character.Name} ");
            sb.AppendLine($"*****************************************************************************");
            sb.AppendLine($"|");
            sb.AppendLine($"|  HP:{character.CurrentHitPoints}/{character.MaximimHitPoints} " +
                      $"| Exp:{character.ExperiancePoints} " +
                      $"| Gold:{character.Gold}");
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
