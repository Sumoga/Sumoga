using controller;
using UnityEngine;

namespace action
{
    public abstract class InputAction
    {
        public string description;
        public abstract void RespondToInput(GameController controller);
    }
}