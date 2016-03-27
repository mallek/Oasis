using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<NonPlayerCharter> NonPlayerCharters = new List<NonPlayerCharter>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;

        public const int NPC_ID_RAT = 1;
        public const int NPC_ID_SNAKE = 2;
        public const int NPC_ID_GIANT_SPIDER = 3;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        static World()
        {
            PopulateItems();
            PopulateNPCs();
            PopulateQuests();
            PopulateLocations();

        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", "A rusty sword", 0, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", "A rat tail"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", "A piece of fuzzy fur"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake Fangs", "The fang of a snake"));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", "The skind of a snake"));
            Items.Add(new Weapon(ITEM_ID_CLUB, "A club", "Clubs", "A long heavy club", 3, 10));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing Potions", "A golden potion of healing", 5));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider Fangs", "The fang of a spider"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Many strands of spider silk", "A sticky silk made froma spider"));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer Passes", "A card with the name Adventurer Pass at the top"));
        }
        private static void PopulateNPCs()
        {
            NonPlayerCharter rat = new NonPlayerCharter(NPC_ID_RAT, "Rat", 5, 3, 10, 3, 3, 1);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            NonPlayerCharter snake = new NonPlayerCharter(NPC_ID_SNAKE, "Snake", 5,3,10,3,3, 1);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            NonPlayerCharter giantSpider = new NonPlayerCharter(NPC_ID_GIANT_SPIDER, "Giant Spider", 20, 5, 40, 10, 10, 5);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            NonPlayerCharters.Add(rat);
            NonPlayerCharters.Add(snake);
            NonPlayerCharters.Add(giantSpider);
        }


        private static void PopulateQuests()
        {
            Quest clearAlchemistsGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, "Clear the alchemist's garden", 
                "Kill rats in the alchemist's garden and bring back three rat tails.  You will receive a healing potion and 10 gold pieces",
                20, 10);
            clearAlchemistsGarden.QuestCompletetionItems.Add(new QuestCompletetionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));
            clearAlchemistsGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearFarmersField = new Quest(QUEST_ID_CLEAR_FARMERS_FIELD, "Clear the farmers field", 
                "Kill snakes in the farmers field and brind back three snake fangs.  You will receive an adventurer's pass and 20 gold pieces.",
                20, 20);
            clearFarmersField.QuestCompletetionItems.Add(new QuestCompletetionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));
            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quests.Add(clearAlchemistsGarden);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house, You really need to clean this place.");
            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town Square", "You see a fountain");
            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvaliableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);
            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.NonPlayerCharterHere = NpcByID(NPC_ID_RAT);
            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front");
            farmhouse.QuestAvaliableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's Field", "You see rows of vegetables growing here.");
            farmersField.NonPlayerCharterHere = NpcByID(NPC_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS));
            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering the trees in the forest.");
            spiderField.NonPlayerCharterHere = NpcByID(NPC_ID_GIANT_SPIDER);


            //Link locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            //Add locations to static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);

        }

        public static NonPlayerCharter NpcByID(int npcId)
        {
            foreach (NonPlayerCharter nonPlayerCharter in NonPlayerCharters)
            {
                if (nonPlayerCharter.ID == npcId)
                {
                    return nonPlayerCharter;
                }
            }

            return null;
        }

        public static Quest QuestByID(int questId)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == questId)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Item ItemByID(int itemId)
        {
            foreach (Item item in Items)
            {
                if (item.ID == itemId)
                {
                    return item;
                }
            }

            return null;
        }

        public static Location LocationByID(int locationId)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == locationId)
                {
                    return location;
                }
            }

            return null;
        }




    }
}
