using System;
using controller;
using UnityEngine;

namespace action
{
    public class ViewShop : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            // TODO populate shop with options
            Debug.Log("--- No items available in shop: ---");
            Debug.Log("--- --- ---");
        }
    }
}