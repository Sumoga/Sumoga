using System.Collections.Generic;
using card;

namespace player
{
    public class Player
    {
        private Score _score;
        public Inventory inventory;
        public List<Card> cards = new List<Card>();

        public Player(Inventory inventory, Score score)
        {
            this.inventory = inventory;
            _score = score;
        }
    }
}