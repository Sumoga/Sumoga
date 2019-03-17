using System.Collections.Generic;

namespace inventory
{
    public class Item
    {
        public string id;
        public string name;
        public string description;
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