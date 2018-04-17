﻿using System;
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
