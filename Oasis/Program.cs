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
            currentGame.SetupPlayer();
            currentGame.ReadLocation();

            while (currentGame.PlayerIsAlive())
            {
                currentGame.ExecuteCommand();
            }
        }
    }
}
