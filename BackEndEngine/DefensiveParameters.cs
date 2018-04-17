using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Structure of defensive item's parameters
    /// </summary>
    public struct  DefensiveParameters
    {
        /// <summary>
        /// Damage mitigation
        /// </summary>
        public double DefenceValue { get; set; }
        /// <summary>
        /// Chance to stop all damage
        /// </summary>
        public int BlockChance { get; set; }
        /// <summary>
        /// Item's weight
        /// </summary>
        public double Weight { get; set; }
    }
}
