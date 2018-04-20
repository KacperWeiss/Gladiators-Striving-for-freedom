namespace GladiatorsWindows
{
    partial class NewGameWindow
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelNewGame = new System.Windows.Forms.Label();
            this.labelChooseYourName = new System.Windows.Forms.Label();
            this.labelGameName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(388, 314);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(212, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Let\'s start new adventure!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayerName.HideSelection = false;
            this.textBoxPlayerName.Location = new System.Drawing.Point(200, 277);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(400, 31);
            this.textBoxPlayerName.TabIndex = 1;
            this.textBoxPlayerName.Text = "Hercules";
            this.textBoxPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::GladiatorsWindows.Properties.Resources.exitDoor;
            this.pictureBoxExit.Location = new System.Drawing.Point(738, 12);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewGame.Location = new System.Drawing.Point(13, 12);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(236, 52);
            this.labelNewGame.TabIndex = 3;
            this.labelNewGame.Text = "Welcome to:";
            // 
            // labelChooseYourName
            // 
            this.labelChooseYourName.AutoSize = true;
            this.labelChooseYourName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChooseYourName.Location = new System.Drawing.Point(196, 251);
            this.labelChooseYourName.Name = "labelChooseYourName";
            this.labelChooseYourName.Size = new System.Drawing.Size(142, 23);
            this.labelChooseYourName.TabIndex = 4;
            this.labelChooseYourName.Text = "Choose your name:";
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameName.Location = new System.Drawing.Point(13, 64);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(277, 68);
            this.labelGameName.TabIndex = 5;
            this.labelGameName.Text = "Game name";
            // 
            // NewGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.labelChooseYourName);
            this.Controls.Add(this.labelNewGame);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewGameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.Label labelChooseYourName;
        private System.Windows.Forms.Label labelGameName;
    }
}