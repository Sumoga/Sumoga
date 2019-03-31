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
            if (string.IsNullOrEmpty(userInput))
                return;

            var action = Utils.ConstructAction(userInput);
            action.RespondToInput(_controller);

            InputComplete();
        }

        private void InputComplete()
        {
            _controller.DisplayLoggedText();
            inputField.text = null;
            inputField.ActivateInputField();
        }
    }
}