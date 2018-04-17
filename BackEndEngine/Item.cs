using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class that represents abstract item
    /// </summary>
    abstract public class Item : IBuyable, ISellable
    {
        /// <summary>
        /// Name of an item
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// Price of an item
        /// </summary>
        public decimal Price { get; protected set; }

        /// <summary>
        /// Image name (used in image selection)
        /// </summary>
        public string ImageName { get; protected set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Sets initial name for and object</param>
        /// <param name="price">Sets initial price for an object</param>
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Method for buying items
        /// </summary>
        /// <param name="funds">Funds to buy something</param>
        public abstract decimal Buy(decimal funds, decimal priceIncrease);
        /// <summary>
        /// Allow player to sell item back to shop
        /// </summary>
        /// <param name="funds">Funds for item to be returned</param>
        public abstract decimal Sell(decimal funds, decimal priceDecrease);

        /// <summary>
        /// Shows ites parameters
        /// </summary>
        /// <returns></returns>
        public virtual string ShowParameters()
        {
            return $"{Name}:   ";
        }

        /// <summary>
        /// Gives basic information about item
        /// </summary>
        /// <returns>String with basic information about item</returns>
        public override string ToString() => $"Name: {Name} Cost: {Price:C}\n";
    }
}
