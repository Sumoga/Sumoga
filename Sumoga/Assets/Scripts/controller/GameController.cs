using action;
using player;
using UnityEngine;
using world;
using Score = player.Score;

namespace controller
{
    public class GameController : MonoBehaviour
    {
        public Player player;
        private World _world;

        public InputAction action;

        private void Awake()
        {
            // create a player
            player = new Player(
                new Inventory(),
                new Score()
            );

            // create a world
            _world = new World(
                new world.Score()
            );
        }
    }
}