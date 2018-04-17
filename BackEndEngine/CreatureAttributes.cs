using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Describes creature's attributes
    /// </summary>
    public struct CreatureAttributes
    {
        /// <summary>
        /// Health points of player
        /// </summary>
        public double HealthPoints { get; set; }
        /// <summary>
        /// Maximum health points value
        /// </summary>
        public double MaximumHealthPoints { get; set; }
        /// <summary>
        /// Current experience
        /// </summary>
        public int Experiance { get; set; }
        /// <summary>
        /// Experience to the next level
        /// </summary>
        public int NextLevelExperiance { get; set; }
        /// <summary>
        /// Current level
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Current strength
        /// </summary>
        public int Strength { get; set; }
        /// <summary>
        /// Current agility
        /// </summary>
        public int Agility { get; set; }
        /// <summary>
        /// Natural armor value
        /// </summary>
        public int Toughness { get; set; }

    }
}
