using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oasis.Engine;
using Oasis.Engine.Commands;
using Oasis.Engine.Interfaces;

namespace Oasis.Tests.Commands
{
    [TestClass()]
    public class CommandTests
    {

        private PlayerCharacter _player;
        private const int PLAYER_ID_UNKNOWN = 1;

        private void SetupTests()
        {
            _player = new PlayerCharacter(PLAYER_ID_UNKNOWN, 10, 10, "unknown", 1, 0, 0);
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


        [TestMethod()]
        public void ExecuteKillCommand()
        {
            SetupTests();
            IGameCommand north = new North();
            north.ExecuteCommand( new []{" North "}, _player);
            north.ExecuteCommand(new[] { " North " }, _player);
            north.ExecuteCommand(new[] { " North " }, _player);


            IGameCommand sut = new Kill();
            string[] args = { "kill","rat" };
            bool result = sut.ExecuteCommand(args, _player);
            Assert.IsTrue(result);
            Assert.IsNotNull(_player.NonPlayerCharacterFighting);
            Assert.IsTrue(_player.CurrentHitPoints <= 0 || _player.NonPlayerCharacterFighting.CurrentHitPoints <= 0);
        }

    }
}