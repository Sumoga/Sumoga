using controller;
using UnityEngine;

namespace action
{
    public class ShopAction
    {
        public string description;

        public static void BuyItem(GameController controller, int itemNumber)
        {
            var boughtItem = controller.shop.selection[itemNumber];
            if (controller.player.score.money < boughtItem.price) return; // not enough money to buy
            controller.player.inventory.Add(boughtItem);
            controller.player.score.money -= boughtItem.price;
            controller.Log($"Bought item: {boughtItem} remaining money: {controller.player.score.money}");
        }
    }
}