using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class descibe full helmet objects
    /// </summary>
    public class FullHelmet : DefensiveItem, IUpgradeable
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Helmet's name</param>
        /// <param name="price">Helmet's price</param>
        public FullHelmet(string name, decimal price, double quality = 1) : base(name, price)
        {
            ImageName = "Helm";
            defensiveParameters.DefenceValue = 10 * quality;
            defensiveParameters.BlockChance = (int)(5 * quality);
            defensiveParameters.Weight = 4;
        }
    }
}
