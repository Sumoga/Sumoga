using System;
using controller;
using UnityEngine;

namespace action
{
    public class ViewInventory : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            var playerItems = controller.player.inventory.items;

            controller.Log("--- Items in inventory ---");
            foreach (var item in playerItems)
                controller.Log($"{item} - {item.description}");

            controller.Log("--- --- ---");
        }
    }
}