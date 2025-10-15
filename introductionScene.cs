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
    public partial class introductionScene : Form
    {
        public introductionScene()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Introduction();
        }
        private void IntroductionScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScene mainScene = new MainScene();
            this.Hide();
            mainScene.Show();
        }

        private void Introduction()
        {
            introText.Text = "This is working!!!!!!!!!";
            introText.Location = new Point(118, 408);
        }
    }
}
