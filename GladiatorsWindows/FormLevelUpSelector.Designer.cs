namespace GladiatorsWindows
{
    partial class FormLevelUpSelector
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
            this.labelSelectLevelUp = new System.Windows.Forms.Label();
            this.pictureBoxToughness = new System.Windows.Forms.PictureBox();
            this.pictureBoxAgility = new System.Windows.Forms.PictureBox();
            this.pictureBoxStrength = new System.Windows.Forms.PictureBox();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelAgility = new System.Windows.Forms.Label();
            this.labelToughness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToughness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectLevelUp
            // 
            this.labelSelectLevelUp.AutoSize = true;
            this.labelSelectLevelUp.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSelectLevelUp.Location = new System.Drawing.Point(4, 9);
            this.labelSelectLevelUp.Name = "labelSelectLevelUp";
            this.labelSelectLevelUp.Size = new System.Drawing.Size(252, 45);
            this.labelSelectLevelUp.TabIndex = 0;
            this.labelSelectLevelUp.Text = "Select level up:";
            // 
            // pictureBoxToughness
            // 
            this.pictureBoxToughness.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxToughness.Image = global::GladiatorsWindows.Properties.Resources.Toughness;
            this.pictureBoxToughness.Location = new System.Drawing.Point(360, 135);
            this.pictureBoxToughness.Name = "pictureBoxToughness";
            this.pictureBoxToughness.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxToughness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxToughness.TabIndex = 9;
            this.pictureBoxToughness.TabStop = false;
            this.pictureBoxToughness.Click += new System.EventHandler(this.pictureBoxToughness_Click);
            // 
            // pictureBoxAgility
            // 
            this.pictureBoxAgility.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxAgility.Image = global::GladiatorsWindows.Properties.Resources.Agility;
            this.pictureBoxAgility.Location = new System.Drawing.Point(186, 135);
            this.pictureBoxAgility.Name = "pictureBoxAgility";
            this.pictureBoxAgility.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxAgility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAgility.TabIndex = 8;
            this.pictureBoxAgility.TabStop = false;
            this.pictureBoxAgility.Click += new System.EventHandler(this.pictureBoxAgility_Click);
            // 
            // pictureBoxStrength
            // 
            this.pictureBoxStrength.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxStrength.Image = global::GladiatorsWindows.Properties.Resources.Strength;
            this.pictureBoxStrength.Location = new System.Drawing.Point(12, 135);
            this.pictureBoxStrength.Name = "pictureBoxStrength";
            this.pictureBoxStrength.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxStrength.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStrength.TabIndex = 7;
            this.pictureBoxStrength.TabStop = false;
            this.pictureBoxStrength.Click += new System.EventHandler(this.pictureBoxStrength_Click);
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStrength.Location = new System.Drawing.Point(12, 103);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(108, 29);
            this.labelStrength.TabIndex = 10;
            this.labelStrength.Text = "Strength:";
            // 
            // labelAgility
            // 
            this.labelAgility.AutoSize = true;
            this.labelAgility.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAgility.Location = new System.Drawing.Point(181, 103);
            this.labelAgility.Name = "labelAgility";
            this.labelAgility.Size = new System.Drawing.Size(85, 29);
            this.labelAgility.TabIndex = 11;
            this.labelAgility.Text = "Agility:";
            // 
            // labelToughness
            // 
            this.labelToughness.AutoSize = true;
            this.labelToughness.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelToughness.Location = new System.Drawing.Point(355, 103);
            this.labelToughness.Name = "labelToughness";
            this.labelToughness.Size = new System.Drawing.Size(119, 29);
            this.labelToughness.TabIndex = 12;
            this.labelToughness.Text = "Toughness:";
            // 
            // FormLevelUpSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.Controls.Add(this.labelToughness);
            this.Controls.Add(this.labelAgility);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.pictureBoxToughness);
            this.Controls.Add(this.pictureBoxAgility);
            this.Controls.Add(this.pictureBoxStrength);
            this.Controls.Add(this.labelSelectLevelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevelUpSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLevelUpSelector";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToughness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStrength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectLevelUp;
        private System.Windows.Forms.PictureBox pictureBoxStrength;
        private System.Windows.Forms.PictureBox pictureBoxAgility;
        private System.Windows.Forms.PictureBox pictureBoxToughness;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelAgility;
        private System.Windows.Forms.Label labelToughness;
    }
}