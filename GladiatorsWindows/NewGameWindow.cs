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
    /// This window initializes the game
    /// </summary>
    public partial class NewGameWindow : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public NewGameWindow()
        {
            InitializeComponent();
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
        /// Starts new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            var playerName = textBoxPlayerName.Text;

            if (playerName == "")
            {
                MessageBox.Show("Player name cannot be empty, try again!", "Empty Name");
            }
            else
            {
                this.Hide();

                var game = new Game(playerName);
                var mainGameWindow = new MainGameWindow(game);

                mainGameWindow.ShowDialog();
                Close();
            }
        }

        /// <summary>
        /// Exit game without start playing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Bye!", "Exit");
            this.Close();
        }
    }
}
