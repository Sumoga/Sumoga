using System;
using System.Collections.Generic;

namespace inventory
{
    [Serializable]
    public class Item
    {
        public int id;
        public string name;
        public string description;

        // price in shop
        public int price = 0;

        // elementary player score changes applied on using this item
        public int greenEnergyChange = 0;
        public int happinessChange = 0;
        public int starsChange = 0;
        public int moneyChange = 0;

        // elementary world score changes applied on using this item
        public int worldHealthChange = 0;

        // additional attributes for item - determines item type
        public List<ItemAttribute> attributes;

        public Item(string name, string description, List<ItemAttribute> attributes)
        {
            this.name = name;
            this.description = description;
            this.attributes = attributes;
        }

        public override string ToString()
        {
            return name;
        }
    }
}