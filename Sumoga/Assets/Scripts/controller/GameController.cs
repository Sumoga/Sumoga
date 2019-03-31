using System.Collections.Generic;
using player;
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
        private Shop _shop;

        /* on screen logging */
        public Text displayText;
        readonly List<string> _actionLog = new List<string>();
        private const int MostRecentMessageCount = 20;

        private void Awake()
        {
            Log("Welcome to Sumoga");
            // create a player
            player = new Player(
                new Inventory(),
                new Score()
            );

            // create a world
            _world = new World(
                new world.Score()
            );

            var gameItems = inventory.Utils.LoadItems();
            _shop = new Shop(gameItems);
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