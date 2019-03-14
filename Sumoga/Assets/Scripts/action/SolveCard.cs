using controller;

namespace action
{
    /// <summary>
    /// Offers player to resolve one of the cards he has, possibly using player's items or score
    /// and possibly also influencing the world score.
    /// </summary>
    public class SolveCard : InputAction
    {
        public override void RespondToInput(GameController controller)
        {
            // TODO create a dialog to allow player process cards and dispose them for a reward
        }
    }
}