using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Interface for classes that are able to be bought
    /// </summary>
    interface IBuyable
    {
        /// <summary>
        /// Method for buying items
        /// </summary>
        /// <param name="funds">Funds to buy something</param>
        /// <param name="priceIncrease">Shop's price increase</param>
        decimal Buy(decimal funds, decimal priceIncrease);
    }
}
