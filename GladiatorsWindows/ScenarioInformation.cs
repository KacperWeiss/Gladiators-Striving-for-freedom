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
    /// Window shows scenario informations
    /// </summary>
    public partial class ScenarioInformation : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ScenarioInformation()
        {
            InitializeComponent();
            labelScenarioInformation.Text = $"You are a gladiator in early Roman Empire. You are promised" +
                $" that if you ever become master of the arena, you will earn your freedom back. \nYour goal:\n" +
                $"Fight in the arena, to earn more money and experience and then stand up against arena's master!";
        }
        /// <summary>
        /// Closes window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
