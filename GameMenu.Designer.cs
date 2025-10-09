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
            startBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.Location = new Point(12, 576);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(400, 100);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 864);
            button2.Name = "button2";
            button2.Size = new Size(400, 100);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 1152);
            button3.Name = "button3";
            button3.Size = new Size(400, 100);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // GameMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2560, 1440);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(startBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameMenu";
            KeyDown += GameMenu_KeyDown;
            ResumeLayout(false);
        }

        #endregion
        private Button startBtn;
        private Button button2;
        private Button button3;
    }
}