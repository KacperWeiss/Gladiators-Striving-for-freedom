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
    public partial class ShopWindow : Form
    {
        /// <summary>
        /// Game reference
        /// </summary>
        Game game;

        /// <summary>
        /// Constructor for shop window
        /// </summary>
        public ShopWindow(Game gameReference)
        {
            InitializeComponent();
            game = gameReference;
            labelShopName.Text = game.GoToShop().Name;
        }

        /// <summary>
        /// Shows dialog for buying swords
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuySwords_Click(object sender, EventArgs e)
        {
            BuyMenu buyMenu = new BuyMenu(game, ItemType.Sword);
            this.Hide();
            buyMenu.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Shows dialog for buying maces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyMaces_Click(object sender, EventArgs e)
        {
            BuyMenu buyMenu = new BuyMenu(game, ItemType.Mace);
            this.Hide();
            buyMenu.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Shows dialog for buying round shields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyRoundShields_Click(object sender, EventArgs e)
        {
            BuyMenu buyMenu = new BuyMenu(game, ItemType.RoundShield);
            this.Hide();
            buyMenu.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Shows dialog for buying full helmets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyFullHelmets_Click(object sender, EventArgs e)
        {
            BuyMenu buyMenu = new BuyMenu(game, ItemType.FullHelmet);
            this.Hide();
            buyMenu.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Shows dialog for buying leather helmets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyLeatherHelmets_Click(object sender, EventArgs e)
        {
            BuyMenu buyMenu = new BuyMenu(game, ItemType.LeatherHelmet);
            this.Hide();
            buyMenu.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Shows dialog for buying chest pieces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyChestPieces_Click(object sender, EventArgs e)
        {
            BuyMenu buyMenu = new BuyMenu(game, ItemType.ChestArmor);
            this.Hide();
            buyMenu.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Shows basic informations about shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxShowInformations_Click(object sender, EventArgs e)
        {
            MessageBox.Show(game.GoToShop().ToString());
        }

        /// <summary>
        /// Allows exit from the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
