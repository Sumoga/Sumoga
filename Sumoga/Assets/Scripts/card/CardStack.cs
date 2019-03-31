using System.Collections.Generic;

namespace card
{
    public class CardStack
    {
        private readonly List<Card> _stack;

        public CardStack(List<Card> stack)
        {
            _stack = stack;
        }

        public Card DrawCard()
        {
            return _stack[0]; // currently, there is just one card you can draw
        }
    }
}