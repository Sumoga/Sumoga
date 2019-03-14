using System.Collections.Generic;
using card;

namespace player
{
    public class Player
    {
        private Score _score;
        public Inventory Inventory;
        public List<Card> Cards = new List<Card>();

        public Player(Inventory inventory, Score score)
        {
            Inventory = inventory;
            _score = score;
        }
    }
}