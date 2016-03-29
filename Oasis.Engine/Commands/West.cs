﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class West : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            if (character.CurrentLocation.LocationToWest != null)
            {
                character.CurrentLocation = character.CurrentLocation.LocationToWest;
                ReadLocation readLocation = new ReadLocation();
                readLocation.ExecuteCommand(null, character);
                return true;
            }

            Console.WriteLine("You cannot go that way");
            return false;
        }

        public List<string> GetAlias()
        {
            return new List<string> {"W", "West"};
        }
    }
}
