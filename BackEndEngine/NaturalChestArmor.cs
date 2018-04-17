﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Defines natural armor
    /// </summary>
    public class NaturalChestArmor : DefensiveItem
    {
        /// <summary>
        /// Defealut constructor
        /// </summary>
        /// <param name="name">Natural chest's armor name</param>
        /// <param name="price">Price of natural armor - should be 0</param>
        /// <param name="defenceValue">Natural defence value</param>
        /// <param name="blockChance">Block chance of skin</param>
        /// <param name="weight">Weight of natural armor</param>
        public NaturalChestArmor(string name, decimal price = 0, double defenceValue = 0, int blockChance = 0, double weight = 0) : base(name, price)
        {
            ImageName = "NoItem";
            defensiveParameters.DefenceValue = defenceValue;
            defensiveParameters.BlockChance = blockChance;
            defensiveParameters.Weight = weight;
        }
    }
}
