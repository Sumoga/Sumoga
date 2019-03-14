using controller;
using Debug = UnityEngine.Debug;

namespace action
{
    /// <summary>
    /// Draws a random card from the stack and adds it to player's cards.
    /// </summary>
    public class DrawCard : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            var newCard = card.Utils.GenerateRandomCard();

            controller.player.Cards.Add(newCard);
            Debug.Log($"Player draws a card: {newCard}");
        }
    }
}