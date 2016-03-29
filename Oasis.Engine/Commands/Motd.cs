using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Motd : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            Console.WriteLine("                 ,               ");
            Console.WriteLine("                / \\              ");
            Console.WriteLine("               {   }             ");
            Console.WriteLine("               p   !             ");
            Console.WriteLine("               ; : ;             ");
            Console.WriteLine("               | : |             ");
            Console.WriteLine("               | : |             ");
            Console.WriteLine("               l ; l             ");
            Console.WriteLine("               l ; l             ");
            Console.WriteLine("               I ; I             ");
            Console.WriteLine("               I ; I             ");
            Console.WriteLine("               I ; I             ");
            Console.WriteLine("               I ; I             ");
            Console.WriteLine("               d | b	            ");
            Console.WriteLine("               H | H             ");
            Console.WriteLine("               H | H             ");
            Console.WriteLine("               H I H             ");
            Console.WriteLine("       ,;,     H I H     ,;,     ");
            Console.WriteLine("      ;H@H;    ;_H_;,   ;H@H;    ");
            Console.WriteLine("      `\\Y/d_,;|4H@HK|;,_b\\Y/'    ");
            Console.WriteLine("       '\\;MMMMM$@@@$MMMMM;/'     ");
            Console.WriteLine("         \"~~~* !8@8! *~~~\"       ");
            Console.WriteLine("               ;888;             ");
            Console.WriteLine("               ;888;             ");
            Console.WriteLine("               ;888;             ");
            Console.WriteLine("               ;888;             ");
            Console.WriteLine("               d8@8b             ");
            Console.WriteLine("               O8@8O             ");
            Console.WriteLine("               T808T             ");
            Console.WriteLine("                `~`              ");
            return true;
        }

        public List<string> GetAlias()
        {
            return new List<string> {"Motd"};
        }
    }
}
