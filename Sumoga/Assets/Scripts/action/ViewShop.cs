using System;
using controller;
using UnityEngine;

namespace action
{
    public class ViewShop : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            controller.Log("--- No items available in shop: ---");
            controller.Log("--- --- ---");
        }
    }
}