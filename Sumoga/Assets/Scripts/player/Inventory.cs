using System.Collections.Generic;
using System.Linq;
using inventory;

namespace player
{
    public class Inventory
    {
        public List<Item> items = new List<Item>();

        /// <summary>
        /// Checks if item is in this inventory
        /// </summary>
        /// <param name="id">id of item</param>
        /// <returns>true if user is in this inventory, else false</returns>
        public bool Contains(string id)
        {
            return items.Any(item => item.id == id);
        }

        public void Add(Item item)
        {
            items.Add(item);
        }
    }
}