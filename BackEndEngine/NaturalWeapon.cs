using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class for weapons like - bare hands, paws, claws etc.
    /// </summary>
    public class NaturalWeapon : Weapon
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Natural weapon's name</param>
        /// <param name="price">Weapon's price</param>
        /// <param name="attackValue">Weapon's attack value</param>
        /// <param name="armorPiercing">Weapon's armor piercing</param>
        /// <param name="recharge">Weapon's recharge</param>
        public NaturalWeapon(string name, decimal price = 0, double attackValue = 2, double armorPiercing = 0, int recharge = 25) : base(name, price)
        {
            ImageName = "NoItem";
            weaponParameters.AttackValue = attackValue;
            weaponParameters.ArmorPiercing = armorPiercing;
            weaponParameters.Recharge = recharge;
            weaponParameters.Weight = 0;
        }
    }
}
