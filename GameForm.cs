using System;
using System.Windows.Forms;
using System.Drawing;

namespace GCHS_2025_Bazaar
{
    public partial class GameForm : Form
    {
        private Label sceneLabel;
        private Button choiceA;
        private Button choiceB;

        public GameForm()
        {
            InitializeComponent();
            this.Text = "Scene 1";
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            sceneLabel = new Label();
            sceneLabel.Text = "You wake up in a strange room. Two paths lie ahead.";
            sceneLabel.Width = 600;
            sceneLabel.Height = 100;
            sceneLabel.Font = new Font("Segoe UI", 14);
            this.Controls.Add(sceneLabel);

            choiceA = new Button();
            choiceA.Text = "Take the left path";
            choiceA.Width = 250;
            choiceA.Click += ChoiceA_Click;
            this.Controls.Add(choiceA);

            choiceB = new Button();
            choiceB.Text = "Take the right path";
            choiceB.Width = 250;
            choiceB.Click += ChoiceB_Click;
            this.Controls.Add(choiceB);

            this.Load += (s, e) =>
            {
                // Center the label at the top
                sceneLabel.Left = (this.ClientSize.Width - sceneLabel.Width) / 2;
                sceneLabel.Top = 50;

                // Center the buttons horizontally, spaced apart
                int spacing = 40;
                int totalWidth = choiceA.Width + spacing + choiceB.Width;
                int startX = (this.ClientSize.Width - totalWidth) / 2;
                int buttonY = sceneLabel.Bottom + 50;

                choiceA.Left = startX;
                choiceA.Top = buttonY;

                choiceB.Left = startX + choiceA.Width + spacing;
                choiceB.Top = buttonY;
            };

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

        private void ChoiceA_Click(object? sender, EventArgs e)
        {
            sceneLabel.Text = "You take the left path and find a key on the ground.";
            choiceA.Text = "Pick up the key";
            choiceB.Text = "Leave it";

            choiceA.Click -= ChoiceA_Click;
            choiceB.Click -= ChoiceB_Click;

            choiceA.Click += (s, ev) =>
            {
                sceneLabel.Text = "You picked up the key. You feel a little safer.";
                choiceA.Visible = false;
                choiceB.Visible = false;
            };

            choiceB.Click += (s, ev) =>
            {
                sceneLabel.Text = "You left the key. Hopefully you won't need it.";
                choiceA.Visible = false;
                choiceB.Visible = false;
            };
        }

        private void ChoiceB_Click(object? sender, EventArgs e)
        {
            sceneLabel.Text = "You fall into a trap! Game over.";
            choiceA.Visible = false;
            choiceB.Visible = false;
        }
        
        private void InitializeComponent()
        {

        }
    }
}
