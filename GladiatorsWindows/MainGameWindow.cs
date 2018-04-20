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
    public partial class MainGameWindow : Form
    {
        /// <summary>
        /// Storage for state of the game
        /// </summary>
        Game game;

        /// <summary>
        /// Game time counter
        /// </summary>
        public int GameTime { get; private set; }

        /// <summary>
        /// Indicates that user lost
        /// </summary>
        public bool gameOver = false;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainGameWindow(Game newGame)
        {
            InitializeComponent();
            timerSeconds.Enabled = true;

            this.game = newGame;
            game.GetPlayer().creatureAttributes.Experiance = 1400;
            labelPlayersName.Text = game.GetPlayer().Name;

            labelLevelNumber.Text = game.GetPlayer().creatureAttributes.Level.ToString();
            pictureBoxLevelUp.Visible = game.GetPlayer().CheckLevelUp();

            progressBarLevel.Minimum = 0;
            progressBarLevel.Maximum = (int)game.GetPlayer().creatureAttributes.NextLevelExperiance;
            progressBarLevel.Value = (int)game.GetPlayer().creatureAttributes.Experiance < (int)game.GetPlayer().creatureAttributes.NextLevelExperiance ? (int)game.GetPlayer().creatureAttributes.Experiance : (int)game.GetPlayer().creatureAttributes.NextLevelExperiance;

            progressBarHealthPoints.Minimum = 0;
            progressBarHealthPoints.Maximum = (int)game.GetPlayer().creatureAttributes.MaximumHealthPoints;
            progressBarHealthPoints.Value = (int)game.GetPlayer().creatureAttributes.HealthPoints;

            labelFunds.Text = $"{game.GetPlayer().Funds:C}";

            pictureBoxWeapon.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.GetPlayer().GetWeapon().ImageName);
            pictureBoxShield.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.GetPlayer().GetDefensiveItem(DefensiveEquipment.Shield).ImageName);
            pictureBoxHelmet.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.GetPlayer().GetDefensiveItem(DefensiveEquipment.Helmet).ImageName);
            pictureBoxChestArmor.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.GetPlayer().GetDefensiveItem(DefensiveEquipment.ChestArmor).ImageName);

            labelWeaponInfo.Text = game.GetPlayer().GetWeapon().ShowParameters();
            labelShieldInfo.Text = game.GetPlayer().GetDefensiveItem(DefensiveEquipment.Shield).ShowParameters();
            labelHelmetInfo.Text = game.GetPlayer().GetDefensiveItem(DefensiveEquipment.Helmet).ShowParameters();
            labelChestArmorInfo.Text = game.GetPlayer().GetDefensiveItem(DefensiveEquipment.ChestArmor).ShowParameters();
        }


        /// <summary>
        /// Allows relocation of form while using borderstyle none
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// Allows user to rename character's name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelPlayersName_Click(object sender, EventArgs e)
        {
            game.RenamePlayer(Prompt.ShowQuestion("What will be your new name?", "Name Selection", $"{game.GetPlayer().Name}"));

        }

        /// <summary>
        /// Method for exiting the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Bye!", "Exit");
            this.Close();
        }

        /// <summary>
        /// Alows access to shop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoToShop_Click(object sender, EventArgs e)
        {
            ShopWindow shopWindow = new ShopWindow(game);
            this.Hide();
            shopWindow.ShowDialog();

            // Updates gold amount
            labelFunds.Text = $"{game.GetPlayer().Funds:C}";

            // Updates items' images
            pictureBoxWeapon.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.GetPlayer().GetWeapon().ImageName);
            pictureBoxShield.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.GetPlayer().GetDefensiveItem(DefensiveEquipment.Shield).ImageName);
            pictureBoxHelmet.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.GetPlayer().GetDefensiveItem(DefensiveEquipment.Helmet).ImageName);
            pictureBoxChestArmor.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.GetPlayer().GetDefensiveItem(DefensiveEquipment.ChestArmor).ImageName);

            // Updates items' info
            labelWeaponInfo.Text = game.GetPlayer().GetWeapon().ShowParameters();
            labelShieldInfo.Text = game.GetPlayer().GetDefensiveItem(DefensiveEquipment.Shield).ShowParameters();
            labelHelmetInfo.Text = game.GetPlayer().GetDefensiveItem(DefensiveEquipment.Helmet).ShowParameters();
            labelChestArmorInfo.Text = game.GetPlayer().GetDefensiveItem(DefensiveEquipment.ChestArmor).ShowParameters();

            this.Show();
        }

        /// <summary>
        /// Shows scenario's informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxShowInformations_Click(object sender, EventArgs e)
        {
            ScenarioInformation scenarioInformation = new ScenarioInformation();
            this.Hide();
            scenarioInformation.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Restorates health and count time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if(gameOver == true)
            {
                Close();
            }
            else if (game.GetPlayer().creatureAttributes.HealthPoints < game.GetPlayer().creatureAttributes.MaximumHealthPoints)
            {
                GameTime++;

                if (game.GetPlayer().creatureAttributes.HealthPoints <= game.GetPlayer().creatureAttributes.MaximumHealthPoints - 5)
                {
                    game.GetPlayer().creatureAttributes.HealthPoints = game.GetPlayer().creatureAttributes.MaximumHealthPoints;
                }
                else
                {
                    game.GetPlayer().creatureAttributes.HealthPoints += 5;
                }
            }

            GameTime++;
            labelTimerHours.Text = $"{(int)(GameTime / 3600)}h";
            labelTimerMinutes.Text = $"{(int)((GameTime / 60) % 60)}m";
            labelTimerSeconds.Text = $"{(int)(GameTime % 60)}s";

            progressBarHealthPoints.Minimum = 0;
            progressBarHealthPoints.Maximum = (int)game.GetPlayer().creatureAttributes.MaximumHealthPoints;
            progressBarHealthPoints.Value = (int)game.GetPlayer().creatureAttributes.HealthPoints > 0 ? (int)game.GetPlayer().creatureAttributes.HealthPoints : 0;
        }

        /// <summary>
        /// Go to the arena window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonArena_Click(object sender, EventArgs e)
        {
            ArenaWindow arenaWindow = new ArenaWindow(game, ref gameOver);
            this.Hide();
            timerSeconds.Stop();
            arenaWindow.ShowDialog();

            // Updates gold amount
            labelFunds.Text = $"{game.GetPlayer().Funds:C}";

            labelLevelNumber.Text = game.GetPlayer().creatureAttributes.Level.ToString();

            progressBarLevel.Minimum = 0;
            progressBarLevel.Maximum = (int)game.GetPlayer().creatureAttributes.NextLevelExperiance;
            progressBarLevel.Value = (int)game.GetPlayer().creatureAttributes.Experiance < (int)game.GetPlayer().creatureAttributes.NextLevelExperiance ? (int)game.GetPlayer().creatureAttributes.Experiance : (int)game.GetPlayer().creatureAttributes.NextLevelExperiance;

            progressBarHealthPoints.Minimum = 0;
            progressBarHealthPoints.Maximum = (int)game.GetPlayer().creatureAttributes.MaximumHealthPoints;
            progressBarHealthPoints.Value = (int)game.GetPlayer().creatureAttributes.HealthPoints > 0 ? (int)game.GetPlayer().creatureAttributes.HealthPoints : 0;

            this.Show();
            timerSeconds.Start();
            pictureBoxLevelUp.Visible = game.GetPlayer().CheckLevelUp();
        }

        /// <summary>
        /// Use level up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLevelUp_Click(object sender, EventArgs e)
        {
            FormLevelUpSelector formLevelUpSelector = new FormLevelUpSelector(game);
            this.Hide();
            formLevelUpSelector.ShowDialog();

            labelLevelNumber.Text = game.GetPlayer().creatureAttributes.Level.ToString();

            progressBarLevel.Minimum = 0;
            progressBarLevel.Maximum = (int)game.GetPlayer().creatureAttributes.NextLevelExperiance;
            progressBarLevel.Value = (int)game.GetPlayer().creatureAttributes.Experiance < (int)game.GetPlayer().creatureAttributes.NextLevelExperiance ? (int)game.GetPlayer().creatureAttributes.Experiance : (int)game.GetPlayer().creatureAttributes.NextLevelExperiance;

            progressBarHealthPoints.Minimum = 0;
            progressBarHealthPoints.Maximum = (int)game.GetPlayer().creatureAttributes.MaximumHealthPoints;
            progressBarHealthPoints.Value = (int)game.GetPlayer().creatureAttributes.HealthPoints > 0 ? (int)game.GetPlayer().creatureAttributes.HealthPoints : 0;

            this.Show();

            pictureBoxLevelUp.Visible = game.GetPlayer().CheckLevelUp();
        }
    }
}
