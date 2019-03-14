using System;
using controller;
using UnityEngine;

namespace action
{
    public class ViewInventory : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            var playerItems = controller.player.Inventory.Items;

            Debug.Log("--- Items in inventory ---");
            foreach (var item in playerItems)
                Console.WriteLine($"{item} - {item.Description}");
            Debug.Log("--- --- ---");
        }
    }
}