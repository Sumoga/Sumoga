using System.Collections.Generic;

namespace inventory
{
    public class Item
    {
        public string Id;
        public string Name;
        public string Description;
        public List<ItemAttribute> Attributes;

        public Item(string name, string description, List<ItemAttribute> attributes)
        {
            Name = name;
            Description = description;
            Attributes = attributes;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}