namespace Tunedra
{
    partial class FormStart
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
            pictureBoxLogo = new PictureBox();
            labelText = new Label();
            pictureBoxCloseButton = new PictureBox();
            pictureBoxMinimazeButton = new PictureBox();
            pictureBoxSingUp = new PictureBox();
            labelSignUp = new Label();
            pictureBoxLogIn = new PictureBox();
            labelLogIn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSingUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogIn).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logoalb;
            pictureBoxLogo.Location = new Point(133, 89);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(163, 158);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelText
            // 
            labelText.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelText.ForeColor = Color.White;
            labelText.Location = new Point(117, 260);
            labelText.Name = "labelText";
            labelText.Size = new Size(216, 109);
            labelText.TabIndex = 1;
            labelText.Text = "Millions of songs.\r\n Free on Tunedra.\r\n\r\n";
            // 
            // pictureBoxCloseButton
            // 
            pictureBoxCloseButton.Cursor = Cursors.Hand;
            pictureBoxCloseButton.Image = Properties.Resources.butonclose;
            pictureBoxCloseButton.Location = new Point(24, 12);
            pictureBoxCloseButton.Name = "pictureBoxCloseButton";
            pictureBoxCloseButton.Size = new Size(20, 20);
            pictureBoxCloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseButton.TabIndex = 2;
            pictureBoxCloseButton.TabStop = false;
            pictureBoxCloseButton.MouseClick += pictureBoxCloseButton_MouseClick;
            // 
            // pictureBoxMinimazeButton
            // 
            pictureBoxMinimazeButton.Cursor = Cursors.Hand;
            pictureBoxMinimazeButton.Image = Properties.Resources.butonminimaze1;
            pictureBoxMinimazeButton.Location = new Point(54, 12);
            pictureBoxMinimazeButton.Name = "pictureBoxMinimazeButton";
            pictureBoxMinimazeButton.Size = new Size(20, 20);
            pictureBoxMinimazeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimazeButton.TabIndex = 3;
            pictureBoxMinimazeButton.TabStop = false;
            pictureBoxMinimazeButton.MouseClick += pictureBoxMinimazeButton_MouseClick;
            // 
            // pictureBoxSingUp
            // 
            pictureBoxSingUp.Cursor = Cursors.Hand;
            pictureBoxSingUp.Image = Properties.Resources.butmov;
            pictureBoxSingUp.Location = new Point(81, 361);
            pictureBoxSingUp.Name = "pictureBoxSingUp";
            pictureBoxSingUp.Size = new Size(283, 55);
            pictureBoxSingUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSingUp.TabIndex = 4;
            pictureBoxSingUp.TabStop = false;
            pictureBoxSingUp.MouseClick += pictureBoxSingUp_MouseClick;
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.BackColor = Color.FromArgb(139, 83, 255);
            labelSignUp.Cursor = Cursors.Hand;
            labelSignUp.ForeColor = Color.White;
            labelSignUp.Location = new Point(152, 378);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(138, 23);
            labelSignUp.TabIndex = 5;
            labelSignUp.Text = "Sign up for free";
            labelSignUp.Click += labelSignUp_Click;
            // 
            // pictureBoxLogIn
            // 
            pictureBoxLogIn.Cursor = Cursors.Hand;
            pictureBoxLogIn.Image = Properties.Resources.image;
            pictureBoxLogIn.Location = new Point(81, 422);
            pictureBoxLogIn.Name = "pictureBoxLogIn";
            pictureBoxLogIn.Size = new Size(283, 55);
            pictureBoxLogIn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogIn.TabIndex = 6;
            pictureBoxLogIn.TabStop = false;
            pictureBoxLogIn.Click += pictureBoxLogIn_Click;
            // 
            // labelLogIn
            // 
            labelLogIn.AutoSize = true;
            labelLogIn.BackColor = Color.FromArgb(35, 35, 35);
            labelLogIn.Cursor = Cursors.Hand;
            labelLogIn.ForeColor = Color.White;
            labelLogIn.Location = new Point(187, 439);
            labelLogIn.Name = "labelLogIn";
            labelLogIn.Size = new Size(60, 23);
            labelLogIn.TabIndex = 7;
            labelLogIn.Text = "Log in";
            labelLogIn.Click += labelLogIn_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(442, 700);
            Controls.Add(labelLogIn);
            Controls.Add(pictureBoxLogIn);
            Controls.Add(labelSignUp);
            Controls.Add(pictureBoxSingUp);
            Controls.Add(pictureBoxMinimazeButton);
            Controls.Add(pictureBoxCloseButton);
            Controls.Add(labelText);
            Controls.Add(pictureBoxLogo);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSingUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGetStarted;
        private PictureBox pictureBoxLogo;
        private Label labelText;
        private PictureBox pictureBoxCloseButton;
        private PictureBox pictureBoxMinimazeButton;
        private PictureBox pictureBoxSingUp;
        private Label labelSignUp;
        private PictureBox pictureBoxLogIn;
        private Label labelLogIn;
    }
}