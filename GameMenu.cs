using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GCHS_2025_Bazaar
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void GameMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                Process.GetCurrentProcess().Kill();
            }
        }
        private void startBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
