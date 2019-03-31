using System.Diagnostics.SymbolStore;
using action;
using controller;
using UnityEngine;
using UnityEngine.UI;

namespace input
{
    public class ShopInput : MonoBehaviour
    {
        public InputField inputField;
        private GameController _controller;

        private void Awake()
        {
            _controller = FindObjectOfType<GameController>();
            inputField.onEndEdit.AddListener(AcceptStringInput);
        }

        private void AcceptStringInput(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
                return;

            if (!IsInputValid(userInput))
            {
                InputInvalid();
                return;
            }

            ShopAction.BuyItem(_controller, int.Parse(userInput));
            InputComplete();
        }

        /// <summary>
        /// Checks if input can be cast to number and therefore specify which item to buy.
        /// </summary>
        /// <param name="userInput"> input string to check</param>
        /// <returns>True if input is valid, false otherwise</returns>
        private bool IsInputValid(string userInput)
        {
            /* check if cast to int is possible */
            int n;
            var parsed = int.TryParse(userInput, out n);
            if (!parsed)
                return false;

            /* check if input is in range */
            var itemCount = _controller.shop.selection.Count;
            if (n <= itemCount) return true;
            _controller.Log($"Please enter a number 0-{itemCount}");
            return false;
        }

        private void InputInvalid()
        {
            _controller.Log("Invalid input");
            _controller.DisplayLoggedText();
            inputField.text = null;
        }

        private void InputComplete()
        {
            _controller.DisplayLoggedText();
            inputField.text = null;
            inputField.ActivateInputField();
        }
    }
}