using controller;
using UnityEngine;

namespace action
{
    public abstract class InputAction
    {
        public string Description;
        public abstract void RespondToInput(GameController controller);
    }
}