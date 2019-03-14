using System;
using action;
using controller;
using UnityEngine;
using UnityEngine.UI;

namespace input
{
    public class TextInput : MonoBehaviour
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
            if (!IsInputValid(userInput))
            {
                InputInvalid();
                return;
            }

            var action = Utils.ConstructAction(userInput);
            action.RespondToInput(_controller);

            InputComplete();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userInput"> input string to check</param>
        /// <returns>True if input is valid, false otherwise</returns>
        private static bool IsInputValid(string userInput)
        {
            return !string.IsNullOrEmpty(userInput);
        }

        private void InputInvalid()
        {
            print("Input is invalid");
            InputComplete();
        }

        private void InputComplete()
        {
//            _controller.DisplayLoggedText();
            inputField.ActivateInputField();
            inputField.text = null;
        }
    }
}