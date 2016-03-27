using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public static class AliasLookup
    {
        public static string ReturnCommand(string commandToCheck)
        {
            switch (commandToCheck.ToLower())
            {
                case "look":
                case "l":
                case "readLocation":
                    return "ReadLocation";
                case "exit":
                case "quit":
                    return "exit";
                case "n":
                case "north":
                    return "North";
                case "s":
                case "south":
                    return "South";
                    
                default :
                    return "";
            }
            
        }
    }
}
