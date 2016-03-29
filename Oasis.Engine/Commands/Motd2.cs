using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Motd2 : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            Console.WriteLine("                                .-.            ");
            Console.WriteLine("                               {{@}}           ");
            Console.WriteLine("               <>               8@8            ");
            Console.WriteLine("             .::::.             888            ");
            Console.WriteLine("         @\\/W\\/\\/W\\//@          8@8            ");
            Console.WriteLine("          \\/^\\/\\/^\\//      _    )8(    _       ");
            Console.WriteLine("           \\_O_<>_O_/     (@)__/8@8\\__(@)      ");
            Console.WriteLine("      ____________________ `~'-=):(=-'~`       ");
            Console.WriteLine("     |<><><>  |  |  <><><>|     |.|            ");
            Console.WriteLine("     |<>      |  |      <>|     |O|            ");
            Console.WriteLine("     |<>      |  |      <>|     |'|            ");
            Console.WriteLine("     |<>   .--------.   <>|     |.|            ");
            Console.WriteLine("     |     |   ()   |     |     |A|            ");
            Console.WriteLine("     |_____| (O\\/O) |_____|     |'|            ");
            Console.WriteLine("     |     \\   /\\   /     |     |.|            ");
            Console.WriteLine("     |------\\  \\/  /------|     |S|            ");
            Console.WriteLine("     |       '.__.'       |     |'|            ");
            Console.WriteLine("     |        |  |        |     |.|            ");
            Console.WriteLine("     :        |  |        :     |I|            ");
            Console.WriteLine("      \\<>     |  |     <>/      |'|            ");
            Console.WriteLine("       \\<>    |  |    <>/       |.|            ");
            Console.WriteLine("        \\<>   |  |   <>/        |S|            ");
            Console.WriteLine("         `\\<> |  | <>/'         |'|            ");
            Console.WriteLine("           `-.|  |.-`           \\ /            ");
            Console.WriteLine("              '--'               ^             ");
            return true;
        }

        public List<string> GetAlias()
        {
            return new List<string> {"Motd2"};
        }
    }
}
