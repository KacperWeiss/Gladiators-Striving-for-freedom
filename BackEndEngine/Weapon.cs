using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    public class Weapon : Item, IUpgradeable
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
        /// Weapon parameters
        /// </summary>
        public WeaponParameters weaponParameters;

        /// <summary>
        /// Default constructor for weapon
        /// </summary>
        /// <param name="name">Weapon's name</param>
        /// <param name="price">Weapon's price</param>
        public Weapon(string name, decimal price) : base(name, price)
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
                throw new Exception($"Not enought funds to buy this weapon. You will need {Price - funds} more");
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
                throw new Exception($"Not enought funds to buy this item. You will need {UpgradePrice - funds} more");
            else
            {
                funds -= UpgradePrice;
                UpgradePrice *= 2;
                weaponParameters.AttackValue *= 1.2;
                weaponParameters.Recharge -= 2;
            }
        }

        /// <summary>
        /// Gives basic information about item
        /// </summary>
        /// <returns>String with basic information about item</returns>
        public override string ToString() => base.ToString() + $"Level: {Level} MaxLevel: {MaximumLevel}.";

        /// <summary>
        /// Shows weapon's parameters
        /// </summary>
        /// <returns></returns>
        public override string ShowParameters()
        {
            return base.ShowParameters() + $"Damage: {weaponParameters.AttackValue}\nArmor Piercing: {weaponParameters.ArmorPiercing}, Recharge: {weaponParameters.Recharge}, Weight: {weaponParameters.Weight}";
        }
    }
}
