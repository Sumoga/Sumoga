using System;
using controller;
using UnityEngine;

namespace action
{
    public class ViewCards : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            var playerCards = controller.player.Cards;

            Debug.Log("--- Cards in inventory ---");
            foreach (var card in playerCards)
                Debug.Log($"{card} - {card.Description}");
            Debug.Log("--- --- ---");
        }
    }
}