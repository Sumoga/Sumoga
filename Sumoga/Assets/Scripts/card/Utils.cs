namespace card
{
    public static class Utils
    {
        /// <summary>
        /// This method tries to imitate drawing a card from a stack.
        /// </summary>
        /// <returns>A random card</returns>
        public static Card GenerateRandomCard()
        {
            return new WantBuyNewSweater(); // this is currently the only card
        }
    }
}