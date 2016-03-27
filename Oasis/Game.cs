using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Oasis.Engine;
using Oasis.Engine.Commands;
using Oasis.Engine.Interfaces;

namespace Oasis
{
    public class Game
    {
        private PlayerCharter _player;
        private NonPlayerCharter _currentNpc;

        public const int PLAYER_ID_UNKNOWN = 1;
        public const string COMMAND_NAMESPACE = "Oasis.Engine.Commands";


        public Game()
        {
            _player = new PlayerCharter(PLAYER_ID_UNKNOWN, 10, 10, "unknown", 1, 0, 0);
            _player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
        }

        internal void SetupPlayer()
        {

            string userInput = null;
            while (string.IsNullOrEmpty(userInput))
            {
                Console.Write("Please enter your name:");
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Invalid Name");
                }
            }
            _player.Name = userInput;
            Console.WriteLine($"Hello {_player.Name} Welcome to Oasis\n\r");
            Console.WriteLine("You look aroud and see:");
        }

        public bool PlayerIsAlive()
        {
            return _player.IsPlayerStillAlive();
        }

        public void ReadLocation()
        {
            ReadLocation readLocation = new ReadLocation();
            readLocation.ExecuteCommand(null, _player);
        }

        public void ExecuteCommand()
        {
            string[] command = Console.ReadLine()?.Split(' ');

            string aliasCommand = AliasLookup.ReturnCommand(command?[0]);

            if (aliasCommand.ToLower() == "exit")
            {
                _player.CurrentHitPoints = 0;
                return;
            }

            var commandType = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                        from type in assembly.GetTypes()
                        where type.Name == aliasCommand && type.Namespace == COMMAND_NAMESPACE
                               select type).FirstOrDefault();

            if (commandType == null)
            {
                Console.WriteLine("Huh?");
                return;
            }

            IGameCommand commandInstance = (IGameCommand)Activator.CreateInstance(commandType);

            commandInstance.ExecuteCommand(command, _player);
            
            //Console.WriteLine(commandType.FullName);

        }
    }
}
