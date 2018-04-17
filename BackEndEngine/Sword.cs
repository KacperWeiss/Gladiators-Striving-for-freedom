using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Sword class
    /// </summary>
    public class Sword : Weapon, IUpgradeable
    {
        /// <summary>
        /// Default constructor inherited partialy from base class
        /// </summary>
        /// <param name="name">Sets initial name for and object</param>
        /// <param name="price">Sets initial price for an object</param>
        /// <param name="quality">Sets quality for an object and default value is 1</param>
        public Sword(string name, decimal price, double quality = 1) : base(name, price)
        {
            ImageName = "Sword";
            weaponParameters.AttackValue = 10 * quality;
            weaponParameters.ArmorPiercing = 5 * quality;
            weaponParameters.Recharge = 60;
            weaponParameters.Weight = 4;
        }
    }
}
