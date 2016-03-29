using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Prompt : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {

            Console.Write($"\n\r<HP:{character.CurrentHitPoints}/{character.MaximimHitPoints} Gold:{character.Gold}>");
            return true;
        }

        public List<string> GetAlias()
        {
            return new List<string> {"Prompt"};
        }
    }
}
