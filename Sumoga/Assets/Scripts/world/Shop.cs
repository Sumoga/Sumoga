using System.Collections.Generic;
using inventory;

namespace world
{
    public class Shop
    {
        public List<Item> selection;

        public Shop(List<Item> selection)
        {
            this.selection = selection;
        }
    }
}