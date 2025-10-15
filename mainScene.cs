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
    public partial class MainScene : Form
    {
        public MainScene()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void MainScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                Process.GetCurrentProcess().Kill();
            }
        }

    }
}
