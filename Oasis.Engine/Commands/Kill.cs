using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands
{
    public class Kill : IGameCommand
    {
        public bool ExecuteCommand(string[] args, PlayerCharacter character)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Kill What?");
                return false;
            }

            if (character.CurrentLocation.NonPlayerCharacterHere == null)
            {
                Console.WriteLine("There is nothing here to kill");
                return false;
            }

            if (!character.CurrentLocation.NonPlayerCharacterHere.Name.ToLower().Contains(args[1].ToLower()))
            {
                Console.WriteLine("You do not see that here");
                return false;
            }

            character.NonPlayerCharacterFighting = new NonPlayerCharacter(character.CurrentLocation.NonPlayerCharacterHere);
            Console.WriteLine("Killing " + character.NonPlayerCharacterFighting.Name);

            while (character.NonPlayerCharacterFighting.CurrentHitPoints > 0 && character.CurrentHitPoints > 0)
            {
                ProcessDamage(character);
                ProcessDamage(character.NonPlayerCharacterFighting);
            }

            Console.WriteLine($"You kill a {character.NonPlayerCharacterFighting.Name}");
            character.Gold += character.NonPlayerCharacterFighting.RewardGold;

            //TODO Add Looting
            //foreach (Item item in character.NonPlayerCharacterFighting.CurrentLoot)
            //{
            //    if (character.Inventory.Exists(x => x.Details == item))
            //    {
                    
            //    }
            //}
           // character.CurrentLocation.NonPlayerCharacterHere = null;
                

            return true;
        }

        private static void ProcessDamage(Character character)
        {
            var rnd = RandomNumberGenerator.NumberBetween(0, 3);
            if (rnd == 0)
            {
                Console.WriteLine($"{character.Name}'s hit misses.");
            }
            else
            {
                Console.WriteLine($"{character.Name} does {rnd} damage.");
                character.CurrentHitPoints -= rnd;
            }
            Thread.Sleep(1000);
        }

        public List<string> GetAlias()
        {
            return new List<string> {"K", "Ki", "Kill"};
           
        }
    }
}
