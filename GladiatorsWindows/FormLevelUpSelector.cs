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
    /// Selects update
    /// </summary>
    public partial class FormLevelUpSelector : Form
    {
        /// <summary>
        /// Game reference
        /// </summary>
        Game game;

        /// <summary>
        /// Default constructor
        /// </summary>
        public FormLevelUpSelector(Game gameReference)
        {
            InitializeComponent();
            game = gameReference;
        }

        /// <summary>
        /// Choose to upgrade strength
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxStrength_Click(object sender, EventArgs e)
        {
            game.GetPlayer().SelectLevelUp(AttributesSelection.Strength);
            this.Close();
        }
        /// <summary>
        /// Choose to upgrade agility
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAgility_Click(object sender, EventArgs e)
        {
            game.GetPlayer().SelectLevelUp(AttributesSelection.Agility);
            this.Close();
        }
        /// <summary>
        /// Choose to upgrade toughness
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxToughness_Click(object sender, EventArgs e)
        {
            game.GetPlayer().SelectLevelUp(AttributesSelection.Toughness);
            this.Close();
        }
    }
}
