using System.Linq;
using controller;

namespace action
{
    public class ViewShop : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            controller.Log("--- Shop selection: ---");
            controller.shop.selection.Each((item, i) =>
                controller.Log($"#{i} ${item} - ${item.price}"));
            controller.Log("--- --- ---");
        }
    }
}