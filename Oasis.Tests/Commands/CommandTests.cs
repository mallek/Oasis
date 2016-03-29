using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oasis.Engine.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oasis.Engine.Interfaces;

namespace Oasis.Engine.Commands.Tests
{
    [TestClass()]
    public class CommandTests
    {

        private PlayerCharter _player;
        private const int PLAYER_ID_UNKNOWN = 1;

        private void SetupTests()
        {
            _player = new PlayerCharter(PLAYER_ID_UNKNOWN, 10, 10, "unknown", 1, 0, 0);
            _player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_HEALING_POTION), 2));

        }

        [TestMethod()]
        public void ExecuteExitCommand()
        {
            SetupTests();
            IGameCommand sut = new Exit();
            string[] args = { "Exit" };
            bool result = sut.ExecuteCommand(args, _player);
            Assert.IsTrue(result);
            Assert.IsTrue(_player.CurrentHitPoints == 0);
        }
    }
}