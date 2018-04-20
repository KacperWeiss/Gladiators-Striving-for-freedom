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
    /// Form for arena fights
    /// </summary>
    public partial class ArenaWindow : Form
    {
        /// <summary>
        /// Reward storage
        /// </summary>
        decimal reward;

        /// <summary>
        /// Counts enemy time in fight
        /// </summary>
        int enemyTimeCounter = 0;

        /// <summary>
        /// Counts player time in fight
        /// </summary>
        int playerTimeCounter = 0;

        /// <summary>
        /// Indicates loss in game
        /// </summary>
        public Boolean gameOver;

        /// <summary>
        /// Game reference
        /// </summary>
        Game game;

        /// <summary>
        /// Genereted player's enemy
        /// </summary>
        Creature enemyCreature;

        /// <summary>
        /// Rewards' dicionary
        /// </summary>
        Dictionary<Rewards, decimal> rewards;

        /// <summary>
        /// Currently used target
        /// </summary>
        ValiableTargets valiableTargets;

        /// <summary>
        /// Random value generator
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Default constructor
        /// </summary>
        public ArenaWindow(Game gameReference, ref bool gameOverReference)
        {
            InitializeComponent();
            panelFightingUserInterfacePanel.Hide();
            panelDifficultySelection.Show();

            game = gameReference;
            gameOver = gameOverReference;
            rewards = new Dictionary<Rewards, decimal>
            {
                { Rewards.Low, 25 },
                { Rewards.Normal, 75 },
                { Rewards.Good, 200 }
            };
            labelEasyReward.Text = $"{rewards[Rewards.Low]:C}";
            labelNormalReward.Text = $"{rewards[Rewards.Normal]:C}";
            labelHardReward.Text = $"{rewards[Rewards.Good]:C}";

            // Player panel initialisation
            labelCharacterInfo.Text = game.GetPlayer().Name;

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
            // End player panel initialisation

        }

        /// <summary>
        /// Exiting area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Easy enemy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEasyEnemy_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomInteger = random.Next(0, 100);
            if (randomInteger < 10)
            {
                if (game.GetPlayer().creatureAttributes.Level > 3)
                {
                    enemyCreature = new Beast("Wolf", "Claws", 275, game.GetPlayer().creatureAttributes.Level - 2);
                }
                else
                {
                    enemyCreature = new Beast("Wolf", "Claws");
                }
            }
            else if (randomInteger < 40)
            {
                if (game.GetPlayer().creatureAttributes.Level > 3)
                {
                    enemyCreature = new MaceGladiator("Mace Gladiator", 175, game.GetPlayer().creatureAttributes.Level - 2);
                }
                else
                {
                    enemyCreature = new MaceGladiator("Mace Gladiator");
                }
            }
            else
            {
                if (game.GetPlayer().creatureAttributes.Level > 3)
                {
                    enemyCreature = new MaceGladiator("Sword Gladiator", 150, game.GetPlayer().creatureAttributes.Level - 2);
                }
                else
                {
                    enemyCreature = new SwordGladiator("Sword Gladiator");
                }
            }
            labelReward.Text = $"{rewards[Rewards.Low]:C}";
            reward = rewards[Rewards.Low];

            // Creature panel initialisation
            labelCreatureInfo.Text = enemyCreature.Name;

            labelCreatureLevelNumber.Text = enemyCreature.creatureAttributes.Level.ToString();

            progressBarCreatureHealthPoints.Minimum = 0;
            progressBarCreatureHealthPoints.Maximum = (int)enemyCreature.creatureAttributes.MaximumHealthPoints;
            progressBarCreatureHealthPoints.Value = (int)enemyCreature.creatureAttributes.HealthPoints;

            pictureBoxCreatureWeapon.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetWeapon().ImageName);
            pictureBoxCreatureShield.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.Shield).ImageName);
            pictureBoxCreatureHelmet.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.Helmet).ImageName);
            pictureBoxCreatureChestArmor.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.ChestArmor).ImageName);

            labelCreatureWeaponInfo.Text = enemyCreature.GetWeapon().ShowParameters();
            labelCreatureShieldInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.Shield).ShowParameters();
            labelCreatureHelmetInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.Helmet).ShowParameters();
            labelCreatureChestArmorInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.ChestArmor).ShowParameters();
            // End creature panel initialisation
            panelFightingUserInterfacePanel.Show();
            panelDifficultySelection.Hide();
        }

        /// <summary>
        /// Normal enemy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNormalEnemy_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomInteger = random.Next(0, 100);
            if (randomInteger < 10)
            {
                enemyCreature = new Beast("Wolf", "Claws", 275, game.GetPlayer().creatureAttributes.Level);
            }
            else if (randomInteger < 40)
            {
                enemyCreature = new MaceGladiator("Mace Gladiator", 175, game.GetPlayer().creatureAttributes.Level);
            }
            else
            {
                enemyCreature = new SwordGladiator("Sword Gladiator", 150, game.GetPlayer().creatureAttributes.Level);
            }
            labelReward.Text = $"{rewards[Rewards.Normal]:C}";
            reward = rewards[Rewards.Normal];

            // Creature panel initialisation
            labelCreatureInfo.Text = enemyCreature.Name;

            labelCreatureLevelNumber.Text = enemyCreature.creatureAttributes.Level.ToString();

            progressBarCreatureHealthPoints.Minimum = 0;
            progressBarCreatureHealthPoints.Maximum = (int)enemyCreature.creatureAttributes.MaximumHealthPoints;
            progressBarCreatureHealthPoints.Value = (int)enemyCreature.creatureAttributes.HealthPoints;

            pictureBoxCreatureWeapon.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetWeapon().ImageName);
            pictureBoxCreatureShield.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.Shield).ImageName);
            pictureBoxCreatureHelmet.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.Helmet).ImageName);
            pictureBoxCreatureChestArmor.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.ChestArmor).ImageName);

            labelCreatureWeaponInfo.Text = enemyCreature.GetWeapon().ShowParameters();
            labelCreatureShieldInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.Shield).ShowParameters();
            labelCreatureHelmetInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.Helmet).ShowParameters();
            labelCreatureChestArmorInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.ChestArmor).ShowParameters();
            // End creature panel initialisation

            panelFightingUserInterfacePanel.Show();
            panelDifficultySelection.Hide();
        }

        /// <summary>
        /// Hard enemy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHardEnemy_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomInteger = random.Next(0, 100);
            if (randomInteger < 10)
            {
                enemyCreature = new Beast("Wolf", "Claws", 275, game.GetPlayer().creatureAttributes.Level + 3);
            }
            else if (randomInteger < 40)
            {
                enemyCreature = new MaceGladiator("Mace Gladiator", 175, game.GetPlayer().creatureAttributes.Level + 4);
            }
            else
            {
                enemyCreature = new SwordGladiator("Sword Gladiator", 150, game.GetPlayer().creatureAttributes.Level + 5);
            }
            labelReward.Text = $"{rewards[Rewards.Good]:C}";
            reward = rewards[Rewards.Good];

            // Creature panel initialisation
            labelCreatureInfo.Text = enemyCreature.Name;

            labelCreatureLevelNumber.Text = enemyCreature.creatureAttributes.Level.ToString();

            progressBarCreatureHealthPoints.Minimum = 0;
            progressBarCreatureHealthPoints.Maximum = (int)enemyCreature.creatureAttributes.MaximumHealthPoints;
            progressBarCreatureHealthPoints.Value = (int)enemyCreature.creatureAttributes.HealthPoints;

            pictureBoxCreatureWeapon.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetWeapon().ImageName);
            pictureBoxCreatureShield.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.Shield).ImageName);
            pictureBoxCreatureHelmet.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.Helmet).ImageName);
            pictureBoxCreatureChestArmor.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.ChestArmor).ImageName);

            labelCreatureWeaponInfo.Text = enemyCreature.GetWeapon().ShowParameters();
            labelCreatureShieldInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.Shield).ShowParameters();
            labelCreatureHelmetInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.Helmet).ShowParameters();
            labelCreatureChestArmorInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.ChestArmor).ShowParameters();
            // End creature panel initialisation

            panelFightingUserInterfacePanel.Show();
            panelDifficultySelection.Hide();
        }

        /// <summary>
        /// Master enemy of level 50
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMasterEnemy_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomInteger = random.Next(0, 100);
            if (randomInteger < 10)
            {
                enemyCreature = new Beast("Wolf", "Claws", 275, 50);
            }
            else if (randomInteger < 40)
            {
                enemyCreature = new MaceGladiator("Mace Gladiator", 175, 50);
            }
            else
            {
                enemyCreature = new SwordGladiator("Sword Gladiator", 150, 50);
            }
            labelReward.Text = "Freedom";
            
            // Creature panel initialisation
            labelCreatureInfo.Text = enemyCreature.Name;

            labelCreatureLevelNumber.Text = enemyCreature.creatureAttributes.Level.ToString();

            progressBarCreatureHealthPoints.Minimum = 0;
            progressBarCreatureHealthPoints.Maximum = (int)enemyCreature.creatureAttributes.MaximumHealthPoints;
            progressBarCreatureHealthPoints.Value = (int)enemyCreature.creatureAttributes.HealthPoints;

            pictureBoxCreatureWeapon.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetWeapon().ImageName);
            pictureBoxCreatureShield.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.Shield).ImageName);
            pictureBoxCreatureHelmet.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.Helmet).ImageName);
            pictureBoxCreatureChestArmor.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(enemyCreature.GetDefensiveItem(DefensiveEquipment.ChestArmor).ImageName);

            labelCreatureWeaponInfo.Text = enemyCreature.GetWeapon().ShowParameters();
            labelCreatureShieldInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.Shield).ShowParameters();
            labelCreatureHelmetInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.Helmet).ShowParameters();
            labelCreatureChestArmorInfo.Text = enemyCreature.GetDefensiveItem(DefensiveEquipment.ChestArmor).ShowParameters();
            // End creature panel initialisation

            panelFightingUserInterfacePanel.Show();
            panelDifficultySelection.Hide();
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
            progressBarHealthPoints.Value = (int)game.GetPlayer().creatureAttributes.HealthPoints;

            this.Show();

            pictureBoxLevelUp.Visible = game.GetPlayer().CheckLevelUp();
        }

        /// <summary>
        /// Set head as target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxHeadTarget_Click(object sender, EventArgs e)
        {
            valiableTargets = ValiableTargets.Head;
            labelCurrentTarget.Text = "Current target: Head";
        }

        /// <summary>
        /// Set head as target
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxChestTarget_Click(object sender, EventArgs e)
        {
            valiableTargets = ValiableTargets.Torso;
            labelCurrentTarget.Text = "Current target: Torso";
        }

        /// <summary>
        /// Starts fight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartFight_Click(object sender, EventArgs e)
        {
            timerFight.Enabled = true;
        }

        /// <summary>
        /// Fight time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFight_Tick(object sender, EventArgs e)
        {
            if(game.GetPlayer().creatureAttributes.HealthPoints < 0)
            {
                timerFight.Enabled = false;
                MessageBox.Show("You are dead!, Game over!");
                gameOver = true;
                Close();
            }
            else if (enemyCreature.creatureAttributes.HealthPoints < 0)
            {
                timerFight.Enabled = false;
                game.GetPlayer().Funds += reward;
                game.GetPlayer().creatureAttributes.Experiance += (int)reward;
                MessageBox.Show("You are victorius!");
                Close();
            }
            else
            {
                playerTimeCounter += 5;
                enemyTimeCounter += 5;

                if(game.GetPlayer().GetWeapon().weaponParameters.Recharge >= playerTimeCounter)
                {
                    playerTimeCounter -= game.GetPlayer().Fight(enemyCreature, valiableTargets);
                }
                if(enemyCreature.GetWeapon().weaponParameters.Recharge >= enemyTimeCounter)
                {
                    int temporaryValue = random.Next(0, 100);
                    if (temporaryValue < 20)
                    {
                        enemyTimeCounter -= enemyCreature.Fight(game.GetPlayer(), ValiableTargets.Head);
                    }
                    else
                    {
                        enemyTimeCounter -= enemyCreature.Fight(game.GetPlayer());
                    }
                }
            }
            // Player panel actualisation
            progressBarHealthPoints.Minimum = 0;
            progressBarHealthPoints.Maximum = (int)game.GetPlayer().creatureAttributes.MaximumHealthPoints;
            progressBarHealthPoints.Value = (int)game.GetPlayer().creatureAttributes.HealthPoints > 0 ? (int)game.GetPlayer().creatureAttributes.HealthPoints : 0;

            // Creature panel actualisation
            progressBarCreatureHealthPoints.Minimum = 0;
            progressBarCreatureHealthPoints.Maximum = (int)enemyCreature.creatureAttributes.MaximumHealthPoints;
            progressBarCreatureHealthPoints.Value = (int)enemyCreature.creatureAttributes.HealthPoints > 0 ? (int)enemyCreature.creatureAttributes.HealthPoints : 0;
        }
    }
}
