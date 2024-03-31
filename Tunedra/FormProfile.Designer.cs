namespace Tunedra
{
    partial class FormProfile
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
            pictureBoxCloseButton = new PictureBox();
            pictureBoxMinimazeButton = new PictureBox();
            pictureBoxBack = new PictureBox();
            labelProfile = new Label();
            labelLogOut = new Label();
            labelUsername = new Label();
            labelUN = new Label();
            labelURSN = new Label();
            pictureBoxProfile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCloseButton
            // 
            pictureBoxCloseButton.Cursor = Cursors.Hand;
            pictureBoxCloseButton.Image = Properties.Resources.butonclose;
            pictureBoxCloseButton.Location = new Point(24, 12);
            pictureBoxCloseButton.Margin = new Padding(3, 4, 3, 4);
            pictureBoxCloseButton.Name = "pictureBoxCloseButton";
            pictureBoxCloseButton.Size = new Size(20, 20);
            pictureBoxCloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseButton.TabIndex = 4;
            pictureBoxCloseButton.TabStop = false;
            pictureBoxCloseButton.Click += pictureBoxCloseButton_Click;
            // 
            // pictureBoxMinimazeButton
            // 
            pictureBoxMinimazeButton.Cursor = Cursors.Hand;
            pictureBoxMinimazeButton.Image = Properties.Resources.butonminimaze1;
            pictureBoxMinimazeButton.Location = new Point(54, 12);
            pictureBoxMinimazeButton.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMinimazeButton.Name = "pictureBoxMinimazeButton";
            pictureBoxMinimazeButton.Size = new Size(20, 20);
            pictureBoxMinimazeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimazeButton.TabIndex = 5;
            pictureBoxMinimazeButton.TabStop = false;
            pictureBoxMinimazeButton.Click += pictureBoxMinimazeButton_Click;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Cursor = Cursors.Hand;
            pictureBoxBack.Image = Properties.Resources.applebackbut_removebg_preview;
            pictureBoxBack.Location = new Point(84, 12);
            pictureBoxBack.Margin = new Padding(3, 4, 3, 4);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(20, 20);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 8;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelProfile.ForeColor = Color.White;
            labelProfile.Location = new Point(222, 92);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(128, 46);
            labelProfile.TabIndex = 9;
            labelProfile.Text = "Profile";
            // 
            // labelLogOut
            // 
            labelLogOut.AutoSize = true;
            labelLogOut.Cursor = Cursors.Hand;
            labelLogOut.ForeColor = Color.FromArgb(139, 83, 255);
            labelLogOut.Location = new Point(238, 401);
            labelLogOut.Name = "labelLogOut";
            labelLogOut.Size = new Size(69, 20);
            labelLogOut.TabIndex = 18;
            labelLogOut.Text = "LOGOUT";
            labelLogOut.Click += labelLogOut_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(272, 232);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(80, 20);
            labelUsername.TabIndex = 19;
            labelUsername.Text = "Username";
            // 
            // labelUN
            // 
            labelUN.AutoSize = true;
            labelUN.Location = new Point(272, 283);
            labelUN.Name = "labelUN";
            labelUN.Size = new Size(0, 20);
            labelUN.TabIndex = 20;
            // 
            // labelURSN
            // 
            labelURSN.AutoSize = true;
            labelURSN.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            labelURSN.ForeColor = Color.White;
            labelURSN.Location = new Point(272, 275);
            labelURSN.Name = "labelURSN";
            labelURSN.Size = new Size(46, 28);
            labelURSN.TabIndex = 21;
            labelURSN.Text = "IDK";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Cursor = Cursors.Hand;
            pictureBoxProfile.Image = Properties.Resources.profile_removebg_preview;
            pictureBoxProfile.Location = new Point(66, 198);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(150, 150);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 22;
            pictureBoxProfile.TabStop = false;
            pictureBoxProfile.Click += pictureBoxProfile_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(542, 498);
            Controls.Add(pictureBoxProfile);
            Controls.Add(labelURSN);
            Controls.Add(labelUN);
            Controls.Add(labelUsername);
            Controls.Add(labelLogOut);
            Controls.Add(labelProfile);
            Controls.Add(pictureBoxBack);
            Controls.Add(pictureBoxMinimazeButton);
            Controls.Add(pictureBoxCloseButton);
            Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProfile";
            Load += FormProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCloseButton;
        private PictureBox pictureBoxMinimazeButton;
        private PictureBox pictureBoxBack;
        private Label labelProfile;
        private Label labelLogOut;
        private Label labelUsername;
        private Label labelUN;
        private Label labelURSN;
        private PictureBox pictureBoxProfile;
    }
}