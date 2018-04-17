using BackEndEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GladiatorsWindows
{
    /// <summary>
    /// Menu to choose quality and buy weapon 
    /// </summary>
    public partial class BuyMenu : Form
    {
        /// <summary>
        /// Storage for game reference
        /// </summary>
        Game game;

        /// <summary>
        /// Info about type of items user wishes to buy
        /// </summary>
        ItemType _itemType = ItemType.Sword;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="gameReference"></param>
        public BuyMenu(Game gameReference, ItemType itemType)
        {
            InitializeComponent();
            game = gameReference;
            _itemType = itemType;

            switch (_itemType)
            {
                case ItemType.Sword:
                    labelItemToBuy.Text = "Sword";
                    labelPoorQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Poor);
                    labelNormalQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Normal);
                    labelGoodQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Good);
                    labelPerfectQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Perfect);
                    break;

                case ItemType.Mace:
                    labelItemToBuy.Text = "Mace";
                    labelPoorQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Poor);
                    labelNormalQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Normal);
                    labelGoodQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Good);
                    labelPerfectQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Perfect);
                    break;

                case ItemType.RoundShield:
                    labelItemToBuy.Text = "Round shield";
                    labelPoorQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Poor);
                    labelNormalQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Normal);
                    labelGoodQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Good);
                    labelPerfectQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Perfect);
                    break;

                case ItemType.ChestArmor:
                    labelItemToBuy.Text = "Chest armor";
                    labelPoorQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Poor);
                    labelNormalQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Normal);
                    labelGoodQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Good);
                    labelPerfectQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Perfect);
                    break;

                case ItemType.FullHelmet:
                    labelItemToBuy.Text = "Full helmet";
                    labelPoorQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Poor);
                    labelNormalQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Normal);
                    labelGoodQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Good);
                    labelPerfectQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Perfect);
                    break;

                case ItemType.LeatherHelmet:
                    labelItemToBuy.Text = "Leather helmet";
                    labelPoorQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Poor);
                    labelNormalQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Normal);
                    labelGoodQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Good);
                    labelPerfectQualityInfo.Text = game.GoToShop().ShowSelectedItemInfo(_itemType, ItemQuality.Perfect);
                    break;
            }
        }

        /// <summary>
        /// Allows user to buy poor quality item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPoorQuality_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_itemType)
                {
                    case ItemType.Sword:
                        game.GoToShop().BuySword(ItemQuality.Poor, game.GetPlayer());
                        break;

                    case ItemType.Mace:
                        game.GoToShop().BuyMace(ItemQuality.Poor, game.GetPlayer());
                        break;

                    case ItemType.RoundShield:
                        game.GoToShop().BuyRoundShield(ItemQuality.Poor, game.GetPlayer());
                        break;

                    case ItemType.ChestArmor:
                        game.GoToShop().BuyChestPiece(ItemQuality.Poor, game.GetPlayer());
                        break;

                    case ItemType.FullHelmet:
                        game.GoToShop().BuyFullHelmet(ItemQuality.Poor, game.GetPlayer());
                        break;

                    case ItemType.LeatherHelmet:
                        game.GoToShop().BuyLeatherHelmet(ItemQuality.Poor, game.GetPlayer());
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}");
            }
        }

        /// <summary>
        /// Allows user to buy normal quality item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyNormalQuality_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_itemType)
                {
                    case ItemType.Sword:
                        game.GoToShop().BuySword(ItemQuality.Normal, game.GetPlayer());
                        break;

                    case ItemType.Mace:
                        game.GoToShop().BuyMace(ItemQuality.Normal, game.GetPlayer());
                        break;

                    case ItemType.RoundShield:
                        game.GoToShop().BuyRoundShield(ItemQuality.Normal, game.GetPlayer());
                        break;

                    case ItemType.ChestArmor:
                        game.GoToShop().BuyChestPiece(ItemQuality.Normal, game.GetPlayer());
                        break;

                    case ItemType.FullHelmet:
                        game.GoToShop().BuyFullHelmet(ItemQuality.Normal, game.GetPlayer());
                        break;

                    case ItemType.LeatherHelmet:
                        game.GoToShop().BuyLeatherHelmet(ItemQuality.Normal, game.GetPlayer());
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}");
            }

        }

        /// <summary>
        /// Allows user to buy good quality item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyGoodQuality_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_itemType)
                {
                    case ItemType.Sword:
                        game.GoToShop().BuySword(ItemQuality.Good, game.GetPlayer());
                        break;

                    case ItemType.Mace:
                        game.GoToShop().BuyMace(ItemQuality.Good, game.GetPlayer());
                        break;

                    case ItemType.RoundShield:
                        game.GoToShop().BuyRoundShield(ItemQuality.Good, game.GetPlayer());
                        break;

                    case ItemType.ChestArmor:
                        game.GoToShop().BuyChestPiece(ItemQuality.Good, game.GetPlayer());
                        break;

                    case ItemType.FullHelmet:
                        game.GoToShop().BuyFullHelmet(ItemQuality.Good, game.GetPlayer());
                        break;

                    case ItemType.LeatherHelmet:
                        game.GoToShop().BuyLeatherHelmet(ItemQuality.Good, game.GetPlayer());
                        break;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}");
            }
        }

        /// <summary>
        /// Allows user to buy perfect quality item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPerfectQuality_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_itemType)
                {
                    case ItemType.Sword:
                        game.GoToShop().BuySword(ItemQuality.Perfect, game.GetPlayer());
                        break;

                    case ItemType.Mace:
                        game.GoToShop().BuyMace(ItemQuality.Perfect, game.GetPlayer());
                        break;

                    case ItemType.RoundShield:
                        game.GoToShop().BuyRoundShield(ItemQuality.Perfect, game.GetPlayer());
                        break;

                    case ItemType.ChestArmor:
                        game.GoToShop().BuyChestPiece(ItemQuality.Perfect, game.GetPlayer());
                        break;

                    case ItemType.FullHelmet:
                        game.GoToShop().BuyFullHelmet(ItemQuality.Perfect, game.GetPlayer());
                        break;

                    case ItemType.LeatherHelmet:
                        game.GoToShop().BuyLeatherHelmet(ItemQuality.Perfect, game.GetPlayer());
                        break;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}");
            }
        }

        /// <summary>
        /// Alows exit from the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
