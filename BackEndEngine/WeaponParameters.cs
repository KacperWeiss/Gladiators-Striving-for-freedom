using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Structure of weapon's parameters
    /// </summary>
    public struct WeaponParameters
    {
        /// <summary>
        /// Damage that weapon deals
        /// </summary>
        public double AttackValue { get; set; }
        /// <summary>
        /// How much armor it ignores on hit
        /// </summary>
        public double ArmorPiercing { get; set; }
        /// <summary>
        /// Recharge time
        /// </summary>
        public int Recharge { get; set; }
        /// <summary>
        /// Weapon's weight
        /// </summary>
        public double Weight { get; set; }
    }
}
