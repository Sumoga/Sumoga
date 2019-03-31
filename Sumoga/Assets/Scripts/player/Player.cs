using System.Collections.Generic;
using card;

namespace player
{
    public class Player
    {
        public Score score;
        public Inventory inventory;
        public List<Card> cards = new List<Card>();

        public Player(Inventory inventory, Score score)
        {
            this.inventory = inventory;
            this.score = score;
        }
    }
}