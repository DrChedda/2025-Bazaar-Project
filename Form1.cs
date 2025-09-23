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
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            Button startButton = new Button();
            startButton.Text = "Start Game";
            startButton.Width = 200;
            startButton.Height = 60;
            startButton.Click += StartButton_Click;

            // Center the button after the form is maximized
            this.Load += (s, e) =>
            {
                startButton.Left = (this.ClientSize.Width - startButton.Width) / 2;
                startButton.Top = (this.ClientSize.Height - startButton.Height) / 2;
            };
            startButton.Anchor = AnchorStyles.None;

            this.Controls.Add(startButton);
            this.KeyPreview = true;
            this.KeyDown += GameForm_KeyDown;
        }
        private void GameForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }
        private void StartButton_Click(object? sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.FormClosed += (s, args) => this.Show(); // Return to menu when game closes
            gameForm.Show();
        }
    }
}