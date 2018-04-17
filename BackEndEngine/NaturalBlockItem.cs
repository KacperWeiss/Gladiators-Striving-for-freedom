using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class that describes natural block item (such as blocking hands)
    /// </summary>
    class NaturalBlockItem : DefensiveItem
    {
        /// <summary>
        /// Defealut constructor
        /// </summary>
        /// <param name="name">Natural blocking item's name</param>
        /// <param name="price">Price of natural blocking item - should always be 0</param>
        /// <param name="defenceValue">Natural defence value</param>
        /// <param name="blockChance">Block chance of hand block</param>
        /// <param name="weight">Weight of natural armor</param>
        public NaturalBlockItem(string name, decimal price = 0, double defenceValue = 0, int blockChance = 10, double weight = 0) : base(name, price)
        {
            ImageName = "NoItem";
            defensiveParameters.DefenceValue = defenceValue;
            defensiveParameters.BlockChance = blockChance;
            defensiveParameters.Weight = weight;
        }
    }
}
