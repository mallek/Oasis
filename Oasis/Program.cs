using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine;

namespace Oasis
{
    class Program
    {
        static void Main(string[] args)
        {
            Game currentGame = new Game();
            currentGame.ReadMotd();
            currentGame.SetupPlayer();
            currentGame.ReadLocation();
            currentGame.InitializeCommands();

            while (currentGame.PlayerIsAlive())
            {
                currentGame.ExecuteCommand();
            }
        }
    }
}
