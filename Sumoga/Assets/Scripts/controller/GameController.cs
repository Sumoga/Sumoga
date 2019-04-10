using System.Collections.Generic;
using card;
using player;
using ui;
using UnityEngine;
using UnityEngine.UI;
using world;
using Score = player.Score;

namespace controller
{
    public class GameController : MonoBehaviour
    {
        public Player player;
        private World _world;
        public Shop shop;
        public CardStack cardStack;

        /* on screen logging */
        public Text displayText;
        readonly List<string> _actionLog = new List<string>();
        private const int MostRecentMessageCount = 20;

        private void Awake()
        {
            Log("Welcome to Sumoga");
            InitPlayer();

            // create a world
            _world = new World(
                new world.Score()
            );

            // initialize game card stack
            var gameCards = card.Utils.LoadCards();
            cardStack = new CardStack(gameCards);

            var gameItems = inventory.Utils.LoadItems();
            shop = new Shop(gameItems);
        }

        private void InitPlayer()
        {
            /* create a player */
            player = new Player(
                new Inventory(),
                new Score()
            );

            /* attach event listener to update changes to UI */
            var scoreUpdater = GetComponentInChildren<PlayerScoreUpdater>();
            scoreUpdater.Init(player.score);

            /* set starting money */
            player.score.money = 15000;
        }


        public void Log(string text)
        {
            _actionLog.Add($"{text}\n");
        }

        internal void DisplayLoggedText()
        {
            var mostRecent = GetMostRecentLog();
            var logAsText = string.Join("\n", mostRecent);
            displayText.text = logAsText;
        }

        /// <summary>
        /// Get last @MostRecentMessageCount entries from log
        /// </summary>
        /// <returns>Most recent log entries</returns>
        private List<string> GetMostRecentLog()
        {
            return _actionLog.Count < MostRecentMessageCount
                ? _actionLog
                : _actionLog.GetRange(_actionLog.Count - MostRecentMessageCount, MostRecentMessageCount);
        }
    }
}