using System;

namespace action
{
    public static class Utils
    {
        // transforms user input into an in-game action
        public static InputAction ConstructAction(string input)
        {
            switch (input[0])
            {
                // actions that influence aspects of the game
                case 'q': return new DrawCard();
                case 'w': return new SolveCard();

                // Read-only actions
                case 'i': return new ViewInventory();
                case 'o': return new ViewCards();
                case 'p': return new ViewShop();
                default: return new ViewInventory();
            }
        }
    }
}