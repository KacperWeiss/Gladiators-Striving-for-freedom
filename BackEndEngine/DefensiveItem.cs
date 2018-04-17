using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Defines defensive items
    /// </summary>
    public class DefensiveItem : Item, IUpgradeable
    {
        /// <summary>
        /// Current level of this item
        /// </summary>
        public int Level { get; protected set; }
        /// <summary>
        /// Max level of this item
        /// </summary>
        public int MaximumLevel { get; protected set; }
        /// <summary>
        /// Upgrade price
        /// </summary>
        public decimal UpgradePrice { get; protected set; }

        /// <summary>
        /// Defencive item's defensive parameters 
        /// </summary>
        public DefensiveParameters defensiveParameters;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public DefensiveItem(string name, decimal price) : base(name, price)
        {
            Level = 1;
            MaximumLevel = 5;
            UpgradePrice = price / 2;
        }

        /// <summary>
        /// Method for buying this item. It checks if user have enough funds and if so, 
        /// it reduces it by the value of this item and allow user to buy it.
        /// </summary>
        /// <param name="funds">Player funds</param>
        public override decimal Buy(decimal funds, decimal priceIncrease)
        {
            if (Price > funds)
                throw new Exception($"Not enought funds to buy this defensive item. You will need {Price - funds} more");
            else
            {
                decimal temporaryFunds = funds;
                temporaryFunds -= (Price + Price * priceIncrease);
                return temporaryFunds;
            }
        }

        /// <summary>
        /// Method for selling this item.
        /// </summary>
        /// <param name="funds">Player's funds</param>
        public override decimal Sell(decimal funds, decimal priceIncrease)
        {
            decimal temporaryFunds = funds;
            temporaryFunds += (Price - Price * priceIncrease);
            return temporaryFunds;
        }

        /// <summary>
        /// Upgrades item to next level
        /// </summary>
        /// <param name="funds"></param>
        public void Upgrade(ref decimal funds)
        {
            if (Level >= MaximumLevel)
                throw new Exception($"{Name} is already at maximum level: {MaximumLevel}");
            else if (funds < UpgradePrice)
                throw new Exception($"Not enought funds to buy this defensive item. You will need {UpgradePrice - funds} more");
            else
            {
                funds -= UpgradePrice;
                UpgradePrice *= 2;
                defensiveParameters.DefenceValue *= 1.2;
                defensiveParameters.BlockChance += 1;
            }
        }

        /// <summary>
        /// Gives basic information about item
        /// </summary>
        /// <returns>String with basic information about item</returns>
        public override string ToString() => base.ToString() + $"Level: {Level} MaxLevel: {MaximumLevel}.";

        /// <summary>
        /// Shows defencive item's parameters
        /// </summary>
        /// <returns></returns>
        public override string ShowParameters()
        {
            return base.ShowParameters() + $"Defence: {defensiveParameters.DefenceValue}\nBlock Chance: {defensiveParameters.BlockChance}, Weight: {defensiveParameters.Weight}";
        }
    }
}
