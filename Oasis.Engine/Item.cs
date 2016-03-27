using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oasis.Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }

        public Item(int id, string name, string namePlural, string description)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Description = description;
            Value = GetItemValue();
        }

        public int GetItemValue()
        {
            return RandomNumberGenerator.NumberBetween(1, 10);
        }
    }
}
