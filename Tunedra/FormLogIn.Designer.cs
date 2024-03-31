namespace Tunedra
{
    partial class FormLogIn
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
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            pictureBoxBack = new PictureBox();
            labelUsername = new Label();
            labelGetStarted = new Label();
            pictureBoxMinimazeButton = new PictureBox();
            pictureBoxCloseButton = new PictureBox();
            checkBoxShowPassword = new CheckBox();
            buttonRegister = new Button();
            labelLogIn = new Label();
            labelHaveAnAcc = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).BeginInit();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(79, 351);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(362, 27);
            textBoxPassword.TabIndex = 18;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(72, 303);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(84, 23);
            labelPassword.TabIndex = 17;
            labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.ForeColor = Color.Black;
            textBoxUsername.Location = new Point(72, 253);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(362, 27);
            textBoxUsername.TabIndex = 16;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Cursor = Cursors.Hand;
            pictureBoxBack.Image = Properties.Resources.applebackbut_removebg_preview;
            pictureBoxBack.Location = new Point(84, 12);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(20, 20);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 15;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(72, 199);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(89, 23);
            labelUsername.TabIndex = 14;
            labelUsername.Text = "Username";
            // 
            // labelGetStarted
            // 
            labelGetStarted.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGetStarted.ForeColor = Color.White;
            labelGetStarted.Location = new Point(181, 92);
            labelGetStarted.Name = "labelGetStarted";
            labelGetStarted.Size = new Size(145, 41);
            labelGetStarted.TabIndex = 13;
            labelGetStarted.Text = "Get Started";
            // 
            // pictureBoxMinimazeButton
            // 
            pictureBoxMinimazeButton.Cursor = Cursors.Hand;
            pictureBoxMinimazeButton.Image = Properties.Resources.butonminimaze1;
            pictureBoxMinimazeButton.Location = new Point(54, 12);
            pictureBoxMinimazeButton.Name = "pictureBoxMinimazeButton";
            pictureBoxMinimazeButton.Size = new Size(20, 20);
            pictureBoxMinimazeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimazeButton.TabIndex = 12;
            pictureBoxMinimazeButton.TabStop = false;
            pictureBoxMinimazeButton.MouseClick += pictureBoxMinimazeButton_MouseClick;
            // 
            // pictureBoxCloseButton
            // 
            pictureBoxCloseButton.Cursor = Cursors.Hand;
            pictureBoxCloseButton.Image = Properties.Resources.butonclose;
            pictureBoxCloseButton.Location = new Point(24, 12);
            pictureBoxCloseButton.Name = "pictureBoxCloseButton";
            pictureBoxCloseButton.Size = new Size(20, 20);
            pictureBoxCloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseButton.TabIndex = 11;
            pictureBoxCloseButton.TabStop = false;
            pictureBoxCloseButton.MouseClick += pictureBoxCloseButton_MouseClick;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.ForeColor = Color.FromArgb(164, 165, 169);
            checkBoxShowPassword.Location = new Point(313, 414);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(128, 24);
            checkBoxShowPassword.TabIndex = 19;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.White;
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.Location = new Point(79, 478);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(362, 44);
            buttonRegister.TabIndex = 20;
            buttonRegister.Text = "LOGIN";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelLogIn
            // 
            labelLogIn.AutoSize = true;
            labelLogIn.Cursor = Cursors.Hand;
            labelLogIn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            labelLogIn.ForeColor = Color.FromArgb(139, 83, 255);
            labelLogIn.Location = new Point(201, 584);
            labelLogIn.Name = "labelLogIn";
            labelLogIn.Size = new Size(116, 20);
            labelLogIn.TabIndex = 22;
            labelLogIn.Text = "Create Account\r\n";
            labelLogIn.Click += labelLogIn_Click;
            // 
            // labelHaveAnAcc
            // 
            labelHaveAnAcc.AutoSize = true;
            labelHaveAnAcc.Cursor = Cursors.Hand;
            labelHaveAnAcc.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            labelHaveAnAcc.Location = new Point(169, 554);
            labelHaveAnAcc.Name = "labelHaveAnAcc";
            labelHaveAnAcc.Size = new Size(170, 20);
            labelHaveAnAcc.TabIndex = 21;
            labelHaveAnAcc.Text = " Dont Have an Account\r\n";
            labelHaveAnAcc.Click += labelHaveAnAcc_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(479, 653);
            Controls.Add(labelLogIn);
            Controls.Add(labelHaveAnAcc);
            Controls.Add(buttonRegister);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(pictureBoxBack);
            Controls.Add(labelUsername);
            Controls.Add(labelGetStarted);
            Controls.Add(pictureBoxMinimazeButton);
            Controls.Add(pictureBoxCloseButton);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private PictureBox pictureBoxBack;
        private Label labelUsername;
        private Label labelGetStarted;
        private PictureBox pictureBoxMinimazeButton;
        private PictureBox pictureBoxCloseButton;
        private CheckBox checkBoxShowPassword;
        private Button buttonRegister;
        private Label labelLogIn;
        private Label labelHaveAnAcc;
    }
}