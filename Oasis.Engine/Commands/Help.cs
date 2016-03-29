using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Help : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            List<string> commands = new List<string>();
            foreach (KeyValuePair<string, Type> keyValuePair in character.CommandDictionary)
            {
                commands.Add(keyValuePair.Key);
            }
            commands.Sort();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**************************************************************");
            sb.AppendLine($"|  Welcome to Oasis, These are the commands you can use ");
            sb.AppendLine($"**************************************************************");
                                                                                                        

            for (int i = 0; i < commands.Count; i++)
            {
                if (i == 0)
                {
                    sb.Append("| ");
                }
                if (i%5 == 0)
                {
                    sb.Append("\n\r| ");
                }
                sb.Append(commands[i] + " ");

            }

            Console.WriteLine(sb.ToString());
            return true;
        }

        public List<string> GetAlias()
        {
            return new List<string> { "Help", "?" };
        }
    }
}
