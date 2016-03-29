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
        public bool ExecuteCommand(string[] args, PlayerCharter charter)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Kill What?");
                return false;
            }

            if (charter.CurrentLocation.NonPlayerCharterHere == null)
            {
                Console.WriteLine("There is nothing here to kill");
                return false;
            }

            if (!charter.CurrentLocation.NonPlayerCharterHere.Name.ToLower().Contains(args[1].ToLower()))
            {
                Console.WriteLine("You do not see that here");
                return false;
            }

            charter.NonPlayerCharterFighting = new NonPlayerCharter(charter.CurrentLocation.NonPlayerCharterHere);
            Console.WriteLine("Killing " + charter.NonPlayerCharterFighting.Name);

            while (charter.NonPlayerCharterFighting.CurrentHitPoints > 0 && charter.CurrentHitPoints > 0)
            {
                ProcessDamage(charter);
                ProcessDamage(charter.NonPlayerCharterFighting);
            }

            Console.WriteLine($"You kill a {charter.NonPlayerCharterFighting.Name}");

            //TODO Add Looting
            //foreach (Item item in charter.NonPlayerCharterFighting.CurrentLoot)
            //{
            //    if (charter.Inventory.Exists(x => x.Details == item))
            //    {
                    
            //    }
            //}
           // charter.CurrentLocation.NonPlayerCharterHere = null;
                

            return true;
        }

        private static void ProcessDamage(Charter charter)
        {
            var rnd = RandomNumberGenerator.NumberBetween(0, 3);
            if (rnd == 0)
            {
                Console.WriteLine($"{charter.Name}'s hit misses.");
            }
            else
            {
                Console.WriteLine($"{charter.Name} does {rnd} damage.");
                charter.CurrentHitPoints -= rnd;
            }
            Thread.Sleep(1000);
        }

        public List<string> GetAlias()
        {
            return new List<string> {"K", "Ki", "Kill"};
           
        }
    }
}
