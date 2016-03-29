using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine.Interfaces
{
    public interface IGameCommand
    {
        bool ExecuteCommand(string[] args, PlayerCharacter character);
        List<string> GetAlias();
    }
}
