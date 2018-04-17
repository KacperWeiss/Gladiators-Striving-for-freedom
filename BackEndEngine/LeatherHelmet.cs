using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class descibe leather helmet objects
    /// </summary>
    public class LeatherHelmet : DefensiveItem, IUpgradeable
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Helmet's name</param>
        /// <param name="price">Helmet's price</param>
        public LeatherHelmet(string name, decimal price, double quality = 1) : base(name, price)
        {
            ImageName = "LeatherHelm";
            defensiveParameters.DefenceValue = 5 * quality;
            defensiveParameters.BlockChance = (int)(2 * quality);
            defensiveParameters.Weight = 1;
        }
    }
}
