using System;
using System.Windows.Forms;

namespace GCHS_2025_Bazaar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "GCHS 2025 Bazaar";
            this.Width = 800;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;

            Button startButton = new Button();
            startButton.Text = "Start Game";
            startButton.Width = 200;
            startButton.Height = 60;
            startButton.Left = (this.ClientSize.Width - startButton.Width) / 2;
            startButton.Top = (this.ClientSize.Height - startButton.Height) / 2;
            startButton.Click += StartButton_Click;

            this.Controls.Add(startButton);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.FormClosed += (s, args) => this.Show(); // Return to menu when game closes
            gameForm.Show();
        }
    }
}