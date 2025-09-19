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
            this.Width = 800;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;

            sceneLabel = new Label();
            sceneLabel.Text = "You wake up in a strange room. Two paths lie ahead.";
            sceneLabel.Width = 600;
            sceneLabel.Height = 100;
            sceneLabel.Top = 50;
            sceneLabel.Left = 100;
            sceneLabel.Font = new Font("Segoe UI", 14);
            this.Controls.Add(sceneLabel);

            choiceA = new Button();
            choiceA.Text = "Take the left path";
            choiceA.Width = 250;
            choiceA.Top = 200;
            choiceA.Left = 100;
            choiceA.Click += ChoiceA_Click;
            this.Controls.Add(choiceA);

            choiceB = new Button();
            choiceB.Text = "Take the right path";
            choiceB.Width = 250;
            choiceB.Top = 200;
            choiceB.Left = 400;
            choiceB.Click += ChoiceB_Click;
            this.Controls.Add(choiceB);
        }

        private void ChoiceA_Click(object sender, EventArgs e)
        {
            sceneLabel.Text = "You take the left path and find a key on the ground.";
            choiceA.Text = "Pick up the key";
            choiceB.Text = "Leave it";

            // Remove existing event handlers
            choiceA.Click -= ChoiceA_Click;
            choiceB.Click -= ChoiceB_Click;

            // Add new ones
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

        private void ChoiceB_Click(object sender, EventArgs e)
        {
            sceneLabel.Text = "You fall into a trap! Game over.";
            choiceA.Visible = false;
            choiceB.Visible = false;
        }

        // Add this method to your GameForm class to resolve CS0103 for InitializeComponent
        private void InitializeComponent()
        {
            // No designer code to initialize, so this is intentionally left empty.
        }
    }
}
