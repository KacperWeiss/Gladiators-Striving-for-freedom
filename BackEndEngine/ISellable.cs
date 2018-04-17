using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Interface for classes that are able to be selled
    /// </summary>
    interface ISellable
    {
        /// <summary>
        /// Method for selling items
        /// </summary>
        /// <param name="funds">Funds to sell something</param>
        /// <param name="priceIncrease">Shop's price decrease</param>
        decimal Sell(decimal funds, decimal priceDecrease);
    }
}
