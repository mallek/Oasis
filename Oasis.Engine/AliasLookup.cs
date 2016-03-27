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
                
                case "exit":
                case "quit":
                    return "exit";

                    //Directions
                case "n":
                case "north":
                    return "North";
                case "e":
                case "east":
                    return "East";
                case "s":
                case "south":
                    return "South";
                case "w":
                case "west":
                    return "West";

                    //charter commands
                case "score":
                case "sco":
                    return "Score";
                case "look":
                case "l":
                case "readLocation":
                    return "ReadLocation";
                case "inv":
                case "inventory":
                    return "Inventory";
                case "k":
                case "kill":
                    return "Kill";

                default :
                    return "";
            }
            
        }
    }
}
