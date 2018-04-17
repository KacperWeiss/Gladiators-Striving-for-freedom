using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Main class in game - all the backend is operated here
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Player's character
        /// </summary>
        Player player;

        /// <summary>
        /// Main shop
        /// </summary>
        Shop shop;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Game(string playerName)
        {
            player = new Player(playerName, 180);
            shop = new Shop("Gladiator's shop");
        }

        /// <summary>
        /// Alows to change player's name in the UI
        /// </summary>
        /// <param name="newName"></param>
        public void RenamePlayer(string newName)
        {
            player.Rename(newName);
        }

        /// <summary>
        /// Gives access to player's informations
        /// </summary>
        /// <returns></returns>
        public Player GetPlayer()
        {
            return player;
        }

        /// <summary>
        /// Allows access to shop
        /// </summary>
        /// <returns></returns>
        public Shop GoToShop()
        {
            return shop;
        }
    }
}
