namespace GCHS_2025_Bazaar
{
    partial class GameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            creditsBtn = new Button();
            startBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // creditsBtn
            // 
            creditsBtn.Location = new Point(12, 864);
            creditsBtn.Name = "creditsBtn";
            creditsBtn.Size = new Size(400, 100);
            creditsBtn.TabIndex = 1;
            creditsBtn.Text = "Credits";
            creditsBtn.UseVisualStyleBackColor = true;
            creditsBtn.Click += creditsBtn_Click;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.Transparent;
            startBtn.BackgroundImageLayout = ImageLayout.Center;
            startBtn.Cursor = Cursors.Hand;
            startBtn.Image = Properties.Resources.Button;
            startBtn.Location = new Point(13, 569);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(414, 107);
            startBtn.TabIndex = 0;
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.background;
            pictureBox1.Location = new Point(2, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1795, 1031);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // GameMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2560, 1440);
            Controls.Add(creditsBtn);
            Controls.Add(startBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameMenu";
            WindowState = FormWindowState.Maximized;
            KeyDown += GameMenu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button creditsBtn;
        private Button startBtn;
        private PictureBox pictureBox1;
    }
}