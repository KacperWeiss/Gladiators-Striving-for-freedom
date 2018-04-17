using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class for blunt weapons
    /// </summary>
    public class BluntWeapon : Weapon, IUpgradeable
    {
        /// <summary>
        /// Class for all types of blunt weapon - good versus heavy armored oponents
        /// </summary>
        /// <param name="name">Weapon's name</param>
        /// <param name="price">Weapon's price</param>
        /// <param name="quality">Weapon's quality</param>
        public BluntWeapon(string name, decimal price, double quality = 1) : base(name, price)
        {
            ImageName = "Mace";
            weaponParameters.AttackValue = 8 * quality;
            weaponParameters.ArmorPiercing = 20 * quality;
            weaponParameters.Recharge = 100;
            weaponParameters.Weight = 6;
        }
    }
}
