namespace GladiatorsWindows
{
    partial class MainGameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelPlayersName = new System.Windows.Forms.Label();
            this.panelPlayerDetails = new System.Windows.Forms.Panel();
            this.labelFunds = new System.Windows.Forms.Label();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.progressBarHealthPoints = new System.Windows.Forms.ProgressBar();
            this.labelHealthPoints = new System.Windows.Forms.Label();
            this.progressBarLevel = new System.Windows.Forms.ProgressBar();
            this.labelLevelNumber = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelCharacterInfo = new System.Windows.Forms.Label();
            this.labelWeaponInfo = new System.Windows.Forms.Label();
            this.labelShieldInfo = new System.Windows.Forms.Label();
            this.labelHelmetInfo = new System.Windows.Forms.Label();
            this.labelChestArmorInfo = new System.Windows.Forms.Label();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.labelTimerHours = new System.Windows.Forms.Label();
            this.labelTimerMinutes = new System.Windows.Forms.Label();
            this.labelTimerSeconds = new System.Windows.Forms.Label();
            this.panelTimerHolder = new System.Windows.Forms.Panel();
            this.pictureBoxShowInformations = new System.Windows.Forms.PictureBox();
            this.pictureBoxLevelUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxWeapon = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoney = new System.Windows.Forms.PictureBox();
            this.pictureBoxChestArmor = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelmet = new System.Windows.Forms.PictureBox();
            this.pictureBoxShield = new System.Windows.Forms.PictureBox();
            this.buttonArena = new System.Windows.Forms.Button();
            this.buttonGoToShop = new System.Windows.Forms.Button();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelPlayerDetails.SuspendLayout();
            this.panelTimerHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowInformations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevelUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChestArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayersName
            // 
            this.labelPlayersName.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayersName.Location = new System.Drawing.Point(0, 0);
            this.labelPlayersName.Name = "labelPlayersName";
            this.labelPlayersName.Size = new System.Drawing.Size(1280, 135);
            this.labelPlayersName.TabIndex = 0;
            this.labelPlayersName.Text = "Player\'s name";
            this.labelPlayersName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayersName.Click += new System.EventHandler(this.labelPlayersName_Click);
            // 
            // panelPlayerDetails
            // 
            this.panelPlayerDetails.Controls.Add(this.pictureBoxLevelUp);
            this.panelPlayerDetails.Controls.Add(this.labelChestArmorInfo);
            this.panelPlayerDetails.Controls.Add(this.labelHelmetInfo);
            this.panelPlayerDetails.Controls.Add(this.labelShieldInfo);
            this.panelPlayerDetails.Controls.Add(this.labelWeaponInfo);
            this.panelPlayerDetails.Controls.Add(this.pictureBoxWeapon);
            this.panelPlayerDetails.Controls.Add(this.labelFunds);
            this.panelPlayerDetails.Controls.Add(this.pictureBoxMoney);
            this.panelPlayerDetails.Controls.Add(this.labelEquipment);
            this.panelPlayerDetails.Controls.Add(this.pictureBoxChestArmor);
            this.panelPlayerDetails.Controls.Add(this.pictureBoxHelmet);
            this.panelPlayerDetails.Controls.Add(this.pictureBoxShield);
            this.panelPlayerDetails.Controls.Add(this.progressBarHealthPoints);
            this.panelPlayerDetails.Controls.Add(this.labelHealthPoints);
            this.panelPlayerDetails.Controls.Add(this.progressBarLevel);
            this.panelPlayerDetails.Controls.Add(this.labelLevelNumber);
            this.panelPlayerDetails.Controls.Add(this.labelLevel);
            this.panelPlayerDetails.Controls.Add(this.labelCharacterInfo);
            this.panelPlayerDetails.Location = new System.Drawing.Point(418, 138);
            this.panelPlayerDetails.Name = "panelPlayerDetails";
            this.panelPlayerDetails.Size = new System.Drawing.Size(436, 570);
            this.panelPlayerDetails.TabIndex = 4;
            // 
            // labelFunds
            // 
            this.labelFunds.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelFunds.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFunds.Location = new System.Drawing.Point(55, 229);
            this.labelFunds.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelFunds.Name = "labelFunds";
            this.labelFunds.Size = new System.Drawing.Size(366, 50);
            this.labelFunds.TabIndex = 17;
            this.labelFunds.Text = "Gold";
            this.labelFunds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEquipment.Location = new System.Drawing.Point(5, 192);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(142, 33);
            this.labelEquipment.TabIndex = 16;
            this.labelEquipment.Text = "Equipment: ";
            // 
            // progressBarHealthPoints
            // 
            this.progressBarHealthPoints.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBarHealthPoints.ForeColor = System.Drawing.Color.Green;
            this.progressBarHealthPoints.Location = new System.Drawing.Point(5, 156);
            this.progressBarHealthPoints.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.progressBarHealthPoints.Name = "progressBarHealthPoints";
            this.progressBarHealthPoints.Size = new System.Drawing.Size(416, 33);
            this.progressBarHealthPoints.TabIndex = 10;
            // 
            // labelHealthPoints
            // 
            this.labelHealthPoints.AutoSize = true;
            this.labelHealthPoints.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHealthPoints.Location = new System.Drawing.Point(5, 120);
            this.labelHealthPoints.Name = "labelHealthPoints";
            this.labelHealthPoints.Size = new System.Drawing.Size(60, 33);
            this.labelHealthPoints.TabIndex = 9;
            this.labelHealthPoints.Text = "HP: ";
            // 
            // progressBarLevel
            // 
            this.progressBarLevel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBarLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBarLevel.Location = new System.Drawing.Point(65, 84);
            this.progressBarLevel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.progressBarLevel.Name = "progressBarLevel";
            this.progressBarLevel.Size = new System.Drawing.Size(356, 33);
            this.progressBarLevel.TabIndex = 8;
            // 
            // labelLevelNumber
            // 
            this.labelLevelNumber.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLevelNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLevelNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLevelNumber.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevelNumber.Location = new System.Drawing.Point(5, 84);
            this.labelLevelNumber.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLevelNumber.Name = "labelLevelNumber";
            this.labelLevelNumber.Size = new System.Drawing.Size(60, 33);
            this.labelLevelNumber.TabIndex = 7;
            this.labelLevelNumber.Text = "Nr";
            this.labelLevelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevel.Location = new System.Drawing.Point(3, 51);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(87, 33);
            this.labelLevel.TabIndex = 6;
            this.labelLevel.Text = "Level: ";
            // 
            // labelCharacterInfo
            // 
            this.labelCharacterInfo.AutoSize = true;
            this.labelCharacterInfo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCharacterInfo.Location = new System.Drawing.Point(3, 3);
            this.labelCharacterInfo.Margin = new System.Windows.Forms.Padding(3);
            this.labelCharacterInfo.Name = "labelCharacterInfo";
            this.labelCharacterInfo.Size = new System.Drawing.Size(247, 45);
            this.labelCharacterInfo.TabIndex = 5;
            this.labelCharacterInfo.Text = "Character info:";
            // 
            // labelWeaponInfo
            // 
            this.labelWeaponInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeaponInfo.Location = new System.Drawing.Point(75, 285);
            this.labelWeaponInfo.Name = "labelWeaponInfo";
            this.labelWeaponInfo.Size = new System.Drawing.Size(346, 64);
            this.labelWeaponInfo.TabIndex = 18;
            // 
            // labelShieldInfo
            // 
            this.labelShieldInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShieldInfo.Location = new System.Drawing.Point(75, 355);
            this.labelShieldInfo.Name = "labelShieldInfo";
            this.labelShieldInfo.Size = new System.Drawing.Size(346, 64);
            this.labelShieldInfo.TabIndex = 19;
            // 
            // labelHelmetInfo
            // 
            this.labelHelmetInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHelmetInfo.Location = new System.Drawing.Point(75, 425);
            this.labelHelmetInfo.Name = "labelHelmetInfo";
            this.labelHelmetInfo.Size = new System.Drawing.Size(346, 64);
            this.labelHelmetInfo.TabIndex = 20;
            // 
            // labelChestArmorInfo
            // 
            this.labelChestArmorInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChestArmorInfo.Location = new System.Drawing.Point(75, 495);
            this.labelChestArmorInfo.Name = "labelChestArmorInfo";
            this.labelChestArmorInfo.Size = new System.Drawing.Size(346, 64);
            this.labelChestArmorInfo.TabIndex = 21;
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // labelTimerHours
            // 
            this.labelTimerHours.AutoSize = true;
            this.labelTimerHours.Location = new System.Drawing.Point(0, 3);
            this.labelTimerHours.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelTimerHours.Name = "labelTimerHours";
            this.labelTimerHours.Size = new System.Drawing.Size(25, 13);
            this.labelTimerHours.TabIndex = 6;
            this.labelTimerHours.Text = "00h";
            // 
            // labelTimerMinutes
            // 
            this.labelTimerMinutes.AutoSize = true;
            this.labelTimerMinutes.Location = new System.Drawing.Point(22, 3);
            this.labelTimerMinutes.Margin = new System.Windows.Forms.Padding(0);
            this.labelTimerMinutes.Name = "labelTimerMinutes";
            this.labelTimerMinutes.Size = new System.Drawing.Size(27, 13);
            this.labelTimerMinutes.TabIndex = 7;
            this.labelTimerMinutes.Text = "00m";
            // 
            // labelTimerSeconds
            // 
            this.labelTimerSeconds.AutoSize = true;
            this.labelTimerSeconds.Location = new System.Drawing.Point(44, 3);
            this.labelTimerSeconds.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelTimerSeconds.Name = "labelTimerSeconds";
            this.labelTimerSeconds.Size = new System.Drawing.Size(24, 13);
            this.labelTimerSeconds.TabIndex = 8;
            this.labelTimerSeconds.Text = "00s";
            // 
            // panelTimerHolder
            // 
            this.panelTimerHolder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelTimerHolder.Controls.Add(this.labelTimerHours);
            this.panelTimerHolder.Controls.Add(this.labelTimerSeconds);
            this.panelTimerHolder.Controls.Add(this.labelTimerMinutes);
            this.panelTimerHolder.Location = new System.Drawing.Point(68, 12);
            this.panelTimerHolder.Name = "panelTimerHolder";
            this.panelTimerHolder.Size = new System.Drawing.Size(67, 19);
            this.panelTimerHolder.TabIndex = 9;
            // 
            // pictureBoxShowInformations
            // 
            this.pictureBoxShowInformations.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShowInformations.Image = global::GladiatorsWindows.Properties.Resources.info;
            this.pictureBoxShowInformations.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxShowInformations.Name = "pictureBoxShowInformations";
            this.pictureBoxShowInformations.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxShowInformations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShowInformations.TabIndex = 5;
            this.pictureBoxShowInformations.TabStop = false;
            this.pictureBoxShowInformations.Click += new System.EventHandler(this.pictureBoxShowInformations_Click);
            // 
            // pictureBoxLevelUp
            // 
            this.pictureBoxLevelUp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLevelUp.Image = global::GladiatorsWindows.Properties.Resources.upgrade;
            this.pictureBoxLevelUp.Location = new System.Drawing.Point(371, 34);
            this.pictureBoxLevelUp.Name = "pictureBoxLevelUp";
            this.pictureBoxLevelUp.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLevelUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLevelUp.TabIndex = 22;
            this.pictureBoxLevelUp.TabStop = false;
            this.pictureBoxLevelUp.Click += new System.EventHandler(this.pictureBoxLevelUp_Click);
            // 
            // pictureBoxWeapon
            // 
            this.pictureBoxWeapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeapon.Location = new System.Drawing.Point(5, 285);
            this.pictureBoxWeapon.Name = "pictureBoxWeapon";
            this.pictureBoxWeapon.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWeapon.TabIndex = 11;
            this.pictureBoxWeapon.TabStop = false;
            // 
            // pictureBoxMoney
            // 
            this.pictureBoxMoney.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxMoney.Image = global::GladiatorsWindows.Properties.Resources.crownCoin;
            this.pictureBoxMoney.Location = new System.Drawing.Point(5, 229);
            this.pictureBoxMoney.Name = "pictureBoxMoney";
            this.pictureBoxMoney.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoney.TabIndex = 6;
            this.pictureBoxMoney.TabStop = false;
            // 
            // pictureBoxChestArmor
            // 
            this.pictureBoxChestArmor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxChestArmor.Location = new System.Drawing.Point(5, 495);
            this.pictureBoxChestArmor.Name = "pictureBoxChestArmor";
            this.pictureBoxChestArmor.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxChestArmor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChestArmor.TabIndex = 14;
            this.pictureBoxChestArmor.TabStop = false;
            // 
            // pictureBoxHelmet
            // 
            this.pictureBoxHelmet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHelmet.Location = new System.Drawing.Point(5, 425);
            this.pictureBoxHelmet.Name = "pictureBoxHelmet";
            this.pictureBoxHelmet.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxHelmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHelmet.TabIndex = 13;
            this.pictureBoxHelmet.TabStop = false;
            // 
            // pictureBoxShield
            // 
            this.pictureBoxShield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShield.Location = new System.Drawing.Point(5, 355);
            this.pictureBoxShield.Name = "pictureBoxShield";
            this.pictureBoxShield.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShield.TabIndex = 12;
            this.pictureBoxShield.TabStop = false;
            // 
            // buttonArena
            // 
            this.buttonArena.BackColor = System.Drawing.Color.Transparent;
            this.buttonArena.BackgroundImage = global::GladiatorsWindows.Properties.Resources.fist;
            this.buttonArena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonArena.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonArena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonArena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.buttonArena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArena.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonArena.ForeColor = System.Drawing.Color.Black;
            this.buttonArena.Location = new System.Drawing.Point(860, 268);
            this.buttonArena.Name = "buttonArena";
            this.buttonArena.Size = new System.Drawing.Size(400, 440);
            this.buttonArena.TabIndex = 3;
            this.buttonArena.Text = " Arena";
            this.buttonArena.UseVisualStyleBackColor = false;
            this.buttonArena.Click += new System.EventHandler(this.buttonArena_Click);
            // 
            // buttonGoToShop
            // 
            this.buttonGoToShop.BackColor = System.Drawing.Color.Transparent;
            this.buttonGoToShop.BackgroundImage = global::GladiatorsWindows.Properties.Resources.shop;
            this.buttonGoToShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGoToShop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonGoToShop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGoToShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.buttonGoToShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToShop.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoToShop.Location = new System.Drawing.Point(12, 268);
            this.buttonGoToShop.Name = "buttonGoToShop";
            this.buttonGoToShop.Size = new System.Drawing.Size(400, 440);
            this.buttonGoToShop.TabIndex = 2;
            this.buttonGoToShop.Text = " Shop";
            this.buttonGoToShop.UseVisualStyleBackColor = false;
            this.buttonGoToShop.Click += new System.EventHandler(this.buttonGoToShop_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.Image = global::GladiatorsWindows.Properties.Resources.exitDoor;
            this.pictureBoxExit.Location = new System.Drawing.Point(1218, 12);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 1;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // MainGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelTimerHolder);
            this.Controls.Add(this.pictureBoxShowInformations);
            this.Controls.Add(this.panelPlayerDetails);
            this.Controls.Add(this.buttonArena);
            this.Controls.Add(this.buttonGoToShop);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.labelPlayersName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainGameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGameWindow";
            this.panelPlayerDetails.ResumeLayout(false);
            this.panelPlayerDetails.PerformLayout();
            this.panelTimerHolder.ResumeLayout(false);
            this.panelTimerHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowInformations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevelUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChestArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlayersName;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Button buttonGoToShop;
        private System.Windows.Forms.Button buttonArena;
        private System.Windows.Forms.Panel panelPlayerDetails;
        private System.Windows.Forms.Label labelCharacterInfo;
        private System.Windows.Forms.PictureBox pictureBoxShowInformations;
        private System.Windows.Forms.Label labelLevelNumber;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.PictureBox pictureBoxShield;
        private System.Windows.Forms.PictureBox pictureBoxWeapon;
        private System.Windows.Forms.ProgressBar progressBarHealthPoints;
        private System.Windows.Forms.Label labelHealthPoints;
        private System.Windows.Forms.ProgressBar progressBarLevel;
        private System.Windows.Forms.Label labelFunds;
        private System.Windows.Forms.PictureBox pictureBoxMoney;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.PictureBox pictureBoxChestArmor;
        private System.Windows.Forms.PictureBox pictureBoxHelmet;
        private System.Windows.Forms.Label labelChestArmorInfo;
        private System.Windows.Forms.Label labelHelmetInfo;
        private System.Windows.Forms.Label labelShieldInfo;
        private System.Windows.Forms.Label labelWeaponInfo;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.Label labelTimerHours;
        private System.Windows.Forms.Label labelTimerMinutes;
        private System.Windows.Forms.Label labelTimerSeconds;
        private System.Windows.Forms.Panel panelTimerHolder;
        private System.Windows.Forms.PictureBox pictureBoxLevelUp;
    }
}