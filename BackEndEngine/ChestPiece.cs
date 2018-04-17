using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class descibe chest piece objects
    /// </summary>
    public class ChestPiece : DefensiveItem, IUpgradeable
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Helmet's name</param>
        /// <param name="price">Helmet's price</param>
        public ChestPiece(string name, decimal price, double quality = 1) : base(name, price)
        {
            ImageName = "Armor";
            defensiveParameters.DefenceValue = 25 * quality;
            defensiveParameters.BlockChance = (int)(5 * quality);
            defensiveParameters.Weight = 15;
        }
    }
}
