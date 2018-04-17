using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class descibe round shield objects
    /// </summary>
    public class RoundShield : DefensiveItem, IUpgradeable
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Helmet's name</param>
        /// <param name="price">Helmet's price</param>
        public RoundShield(string name, decimal price, double quality = 1) : base(name, price)
        {
            ImageName = "RoundShield";
            defensiveParameters.DefenceValue = 10 * quality;
            defensiveParameters.BlockChance = (int)(20 * quality);
            defensiveParameters.Weight = 4;
        }
    }
}
