using System.Collections.Generic;
using inventory;

namespace world
{
    public class Shop
    {
        private List<Item> _selection;

        public Shop(List<Item> selection)
        {
            _selection = selection;
        }
    }
}