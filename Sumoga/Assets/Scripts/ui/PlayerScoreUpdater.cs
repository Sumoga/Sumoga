using player;
using UnityEngine;
using UnityEngine.UI;

namespace ui
{
    public class PlayerScoreUpdater : MonoBehaviour
    {
        public Text greenEnergyValue;
        public Text happinessValue;
        public Text starsValue;
        public Text moneyValue;

        private Score _score;

        public void Init(Score score)
        {
            _score = score;
            _score.ScoreChange += OnScoreChange; // subscribe to event
        }

        /// <summary>
        /// Update text fields when a sore value changes
        /// </summary>
        private void OnScoreChange()
        {
            greenEnergyValue.text = _score.greenEnergy.ToString();
            happinessValue.text = _score.happiness.ToString();
            starsValue.text = _score.stars.ToString();
            moneyValue.text = _score.money.ToString();
        }

        private void Destroy()
        {
            _score.ScoreChange -= OnScoreChange; // unsubscribe from event
        }
    }
}