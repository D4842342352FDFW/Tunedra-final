namespace Tunedra
{
    partial class FormRegister
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
            labelGetStarted = new Label();
            labelUsername = new Label();
            pictureBoxBack = new PictureBox();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelConfirmPassword = new Label();
            textBoxCPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            buttonRegister = new Button();
            labelHaveAnAcc = new Label();
            labelLogIn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCloseButton
            // 
            pictureBoxCloseButton.Cursor = Cursors.Hand;
            pictureBoxCloseButton.Image = Properties.Resources.butonclose;
            pictureBoxCloseButton.Location = new Point(24, 12);
            pictureBoxCloseButton.Name = "pictureBoxCloseButton";
            pictureBoxCloseButton.Size = new Size(20, 20);
            pictureBoxCloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseButton.TabIndex = 3;
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
            pictureBoxMinimazeButton.TabIndex = 4;
            pictureBoxMinimazeButton.TabStop = false;
            pictureBoxMinimazeButton.MouseClick += pictureBoxMinimazeButton_MouseClick;
            // 
            // labelGetStarted
            // 
            labelGetStarted.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGetStarted.ForeColor = Color.White;
            labelGetStarted.Location = new Point(181, 92);
            labelGetStarted.Name = "labelGetStarted";
            labelGetStarted.Size = new Size(154, 41);
            labelGetStarted.TabIndex = 5;
            labelGetStarted.Text = "Get Started";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(61, 174);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 23);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "Username";
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Cursor = Cursors.Hand;
            pictureBoxBack.Image = Properties.Resources.applebackbut_removebg_preview;
            pictureBoxBack.Location = new Point(84, 12);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(20, 20);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 7;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.MouseClick += pictureBoxBack_MouseClick;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.ForeColor = Color.Black;
            textBoxUsername.Location = new Point(61, 228);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(362, 27);
            textBoxUsername.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(61, 278);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(84, 23);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(68, 326);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(362, 27);
            textBoxPassword.TabIndex = 10;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConfirmPassword.Location = new Point(68, 373);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(155, 23);
            labelConfirmPassword.TabIndex = 11;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxCPassword
            // 
            textBoxCPassword.BackColor = Color.White;
            textBoxCPassword.BorderStyle = BorderStyle.None;
            textBoxCPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCPassword.ForeColor = Color.Black;
            textBoxCPassword.Location = new Point(68, 425);
            textBoxCPassword.Multiline = true;
            textBoxCPassword.Name = "textBoxCPassword";
            textBoxCPassword.PasswordChar = '•';
            textBoxCPassword.Size = new Size(362, 27);
            textBoxCPassword.TabIndex = 12;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.ForeColor = Color.FromArgb(164, 165, 169);
            checkBoxShowPassword.Location = new Point(338, 488);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(136, 24);
            checkBoxShowPassword.TabIndex = 13;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.White;
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.Location = new Point(75, 546);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(362, 44);
            buttonRegister.TabIndex = 14;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelHaveAnAcc
            // 
            labelHaveAnAcc.AutoSize = true;
            labelHaveAnAcc.Cursor = Cursors.Hand;
            labelHaveAnAcc.Location = new Point(169, 603);
            labelHaveAnAcc.Name = "labelHaveAnAcc";
            labelHaveAnAcc.Size = new Size(180, 20);
            labelHaveAnAcc.TabIndex = 16;
            labelHaveAnAcc.Text = "Already have an account";
            labelHaveAnAcc.Click += labelHaveAnAcc_Click;
            // 
            // labelLogIn
            // 
            labelLogIn.AutoSize = true;
            labelLogIn.Cursor = Cursors.Hand;
            labelLogIn.ForeColor = Color.FromArgb(139, 83, 255);
            labelLogIn.Location = new Point(201, 635);
            labelLogIn.Name = "labelLogIn";
            labelLogIn.Size = new Size(111, 20);
            labelLogIn.TabIndex = 17;
            labelLogIn.Text = "Back to LOGIN";
            labelLogIn.Click += labelLogIn_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(497, 700);
            Controls.Add(labelLogIn);
            Controls.Add(labelHaveAnAcc);
            Controls.Add(buttonRegister);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(textBoxCPassword);
            Controls.Add(labelConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(pictureBoxBack);
            Controls.Add(labelUsername);
            Controls.Add(labelGetStarted);
            Controls.Add(pictureBoxMinimazeButton);
            Controls.Add(pictureBoxCloseButton);
            Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCloseButton;
        private PictureBox pictureBoxMinimazeButton;
        private Label labelGetStarted;
        private Label labelUsername;
        private PictureBox pictureBoxBack;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelConfirmPassword;
        private TextBox textBoxCPassword;
        private CheckBox checkBoxShowPassword;
        private Button buttonRegister;
        private Label labelHaveAnAcc;
        private Label labelLogIn;
    }
}