namespace GCHS_2025_Bazaar
{
    partial class introductionScene
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            imageList1 = new ImageList(components);
            introText = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 40F);
            button1.Location = new Point(2332, 1189);
            button1.Name = "button1";
            button1.Size = new Size(200, 200);
            button1.TabIndex = 0;
            button1.Text = "Skip";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // introText
            // 
            introText.AutoSize = true;
            introText.Font = new Font("Segoe UI", 81F);
            introText.Location = new Point(118, 408);
            introText.Name = "introText";
            introText.Size = new Size(2338, 145);
            introText.TabIndex = 1;
            introText.Text = "Error, if you see this something has gone wrong";
            // 
            // introductionScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2544, 1401);
            Controls.Add(introText);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "introductionScene";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "introductionScene";
            WindowState = FormWindowState.Maximized;
            KeyDown += IntroductionScene_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ImageList imageList1;
        private Label introText;
    }
}