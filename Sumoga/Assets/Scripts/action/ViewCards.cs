using System;
using controller;
using UnityEngine;

namespace action
{
    public class ViewCards : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            var playerCards = controller.player.cards;

            controller.Log("--- Cards in inventory ---");
            foreach (var card in playerCards)
                controller.Log($"{card} - {card.Description}");
            controller.Log("--- --- ---");
        }
    }
}