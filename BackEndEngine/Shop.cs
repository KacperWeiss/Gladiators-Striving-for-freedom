using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class that represents shop in game 
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// Name of the shop
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Price increase in this shop
        /// </summary>
        public decimal PriceIncrease { get; private set; }

        /// <summary>
        /// Swords that this shop can sell
        /// </summary>
        List<Sword> swords;

        /// <summary>
        /// Maces that this shop can sell
        /// </summary>
        List<BluntWeapon> maces;

        /// <summary>
        /// Round shields that this shop can sell
        /// </summary>
        List<RoundShield> roundShields;

        /// <summary>
        /// Chest piece that this shop can sell
        /// </summary>
        List<ChestPiece> chestPieces;

        /// <summary>
        /// Leather helmets that this shop can sell
        /// </summary>
        List<LeatherHelmet> leatherHelmets;

        /// <summary>
        /// Full helmets that this shop can sell
        /// </summary>
        List<FullHelmet> fullHelmets;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Sets name of the shop</param>
        /// <param name="priceIncrease">Describes price increase</param>
        public Shop(string name, decimal priceIncrease = 0.2m)
        {
            Name = name;
            PriceIncrease = priceIncrease;
            swords = new List<Sword>
            {
                new Sword("Poor quality sword", 10, 0.5),
                new Sword("Normal quality sword", 100, 1),
                new Sword("Good quality sword", 750.5m, 1.5),
                new Sword("Perfect quality sword", 5070.5m, 2.5)
            };
            maces = new List<BluntWeapon>
            {
                new BluntWeapon("Poor quality mace", 10, 0.5),
                new BluntWeapon("Normal quality mace", 100, 1),
                new BluntWeapon("Good quality mace", 750.5m, 1.5),
                new BluntWeapon("Perfect quality mace", 5070.5m, 2.5)
            };
            roundShields = new List<RoundShield>
            {
                new RoundShield("Poor quality round shield", 10, 0.5),
                new RoundShield("Normal quality round shield", 100, 1),
                new RoundShield("Good quality round shield", 750.5m, 1.5),
                new RoundShield("Perfect quality round shield", 5070.5m, 2.5)
            };
            chestPieces = new List<ChestPiece>
            {
                new ChestPiece("Poor quality torso armor", 10, 0.5),
                new ChestPiece("Normal quality torso armor", 100, 1),
                new ChestPiece("Good quality torso armor", 750.5m, 1.5),
                new ChestPiece("Perfect quality torso armor", 5070.5m, 2.5)
            };
            leatherHelmets = new List<LeatherHelmet>
            {
                new LeatherHelmet("Poor quality leather helmet", 10, 0.5),
                new LeatherHelmet("Normal quality leather helmet", 100, 1),
                new LeatherHelmet("Good quality leather helmet", 750.5m, 1.5),
                new LeatherHelmet("Perfect quality leather helmet", 5070.5m, 2.5)
            };
            fullHelmets = new List<FullHelmet>
            {
                new FullHelmet("Poor quality full helmet", 10, 0.5),
                new FullHelmet("Normal quality full helmet", 100, 1),
                new FullHelmet("Good quality full helmet", 750.5m, 1.5),
                new FullHelmet("Perfect quality full helmet", 5070.5m, 2.5)
            };
        }

        /// <summary>
        /// Alows player to buy sword from the shop
        /// </summary>
        /// <param name="itemQuality">Identifies weapon quality</param>
        /// <param name="player">Player reference</param>
        public void BuySword(ItemQuality itemQuality, Player player)
        {
            try
            {
                player.Funds = swords[(int)itemQuality].Buy(player.Funds, PriceIncrease);
                player.Funds = player.GetWeapon().Sell(player.Funds, PriceIncrease);
                player.ChangeWeapon(swords[(int)itemQuality]);
                
            }
            catch(Exception exception)
            {
                throw new Exception($"{Name}: \"{exception.Message}\"");
            }
        }

        /// <summary>
        /// Alows player to buy mace from the shop
        /// </summary>
        /// <param name="itemQuality">Identifies weapon quality</param>
        /// <param name="player">Player reference</param>
        public void BuyMace(ItemQuality itemQuality, Player player)
        {
            try
            {
                player.Funds = maces[(int)itemQuality].Buy(player.Funds, PriceIncrease);
                player.Funds = player.GetWeapon().Sell(player.Funds, PriceIncrease);
                player.ChangeWeapon(maces[(int)itemQuality]);
            }
            catch (Exception exception)
            {
                throw new Exception($"{Name}: \"{exception.Message}\"");
            }
        }

        /// <summary>
        /// Alows player to buy round shield from the shop
        /// </summary>
        /// <param name="itemQuality">Identifies quality</param>
        /// <param name="player">Player reference</param>
        public void BuyRoundShield(ItemQuality itemQuality, Player player)
        {
            try
            {
                player.Funds = roundShields[(int)itemQuality].Buy(player.Funds, PriceIncrease);
                player.Funds = player.GetDefensiveItem(DefensiveEquipment.Shield).Sell(player.Funds, PriceIncrease);
                player.ChangeDefensiveItem(roundShields[(int)itemQuality], DefensiveEquipment.Shield);
            }
            catch (Exception exception)
            {
                throw new Exception($"{Name}: \"{exception.Message}\"");
            }
        }

        /// <summary>
        /// Alows player to buy chest piece from the shop
        /// </summary>
        /// <param name="itemQuality">Identifies quality</param>
        /// <param name="player">Player reference</param>
        public void BuyChestPiece(ItemQuality itemQuality, Player player)
        {
            try
            {
                player.Funds = chestPieces[(int)itemQuality].Buy(player.Funds, PriceIncrease);
                player.Funds = player.GetDefensiveItem(DefensiveEquipment.ChestArmor).Sell(player.Funds, PriceIncrease);
                player.ChangeDefensiveItem(chestPieces[(int)itemQuality], DefensiveEquipment.ChestArmor);
            }
            catch (Exception exception)
            {
                throw new Exception($"{Name}: \"{exception.Message}\"");
            }
        }

        /// <summary>
        /// Alows player to buy full helmet from the shop
        /// </summary>
        /// <param name="itemQuality">Identifies quality</param>
        /// <param name="player">Player reference</param>
        public void BuyFullHelmet(ItemQuality itemQuality, Player player)
        {
            try
            {
                player.Funds = fullHelmets[(int)itemQuality].Buy(player.Funds, PriceIncrease);
                player.Funds = player.GetDefensiveItem(DefensiveEquipment.Helmet).Sell(player.Funds, PriceIncrease);
                player.ChangeDefensiveItem(fullHelmets[(int)itemQuality], DefensiveEquipment.Helmet);
            }
            catch (Exception exception)
            {
                throw new Exception($"{Name}: \"{exception.Message}\"");
            }
        }

        /// <summary>
        /// Alows player to buy leather helmet from the shop
        /// </summary>
        /// <param name="itemQuality">Identifies quality</param>
        /// <param name="player">Player reference</param>
        public void BuyLeatherHelmet(ItemQuality itemQuality, Player player)
        {
            try
            {
                player.Funds = leatherHelmets[(int)itemQuality].Buy(player.Funds, PriceIncrease);
                player.Funds = player.GetDefensiveItem(DefensiveEquipment.Helmet).Sell(player.Funds, PriceIncrease);
                player.ChangeDefensiveItem(leatherHelmets[(int)itemQuality], DefensiveEquipment.Helmet);
            }
            catch (Exception exception)
            {
                throw new Exception($"{Name}: \"{exception.Message}\"");
            }
        }

        /// <summary>
        /// Shows list of items
        /// </summary>
        /// <returns>List of items</returns>
        public string ShowSelectedItemInfo(ItemType itemType, ItemQuality itemQuality)
        {
            string message;

            switch (itemType)
            {
                case ItemType.Sword:
                    return message = swords[(int)itemQuality].ToString();

                case ItemType.Mace:
                    return message = maces[(int)itemQuality].ToString();

                case ItemType.RoundShield:
                    return message = roundShields[(int)itemQuality].ToString();

                case ItemType.ChestArmor:
                    return message = chestPieces[(int)itemQuality].ToString();

                case ItemType.FullHelmet:
                    return message = fullHelmets[(int)itemQuality].ToString();

                case ItemType.LeatherHelmet:
                    return message = leatherHelmets[(int)itemQuality].ToString();
            }
            return "";
        }

        /// <summary>
        /// Shows basic informations about this shop
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Shop's name: {Name}, Price incease: {PriceIncrease}.";
    }
}
