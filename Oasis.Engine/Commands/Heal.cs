using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Heal : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            character.CurrentHitPoints = character.MaximimHitPoints;
            return true;
        }

        public List<string> GetAlias()
        {
            return new List<string> { "Heal" }; ;
        }
    }
}
