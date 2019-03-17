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

            Debug.Log("--- Items in inventory ---");
            foreach (var item in playerItems)
                Debug.Log(item + " - " + item.description);

            Debug.Log("--- --- ---");
        }
    }
}