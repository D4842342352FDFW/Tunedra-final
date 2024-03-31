namespace Tunedra
{
    partial class FormAddAnArtist
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
            buttonSend = new Button();
            pictureBoxCloseButton = new PictureBox();
            pictureBoxMinimazeButton = new PictureBox();
            pictureBoxBack = new PictureBox();
            textBoxName = new TextBox();
            labelName = new Label();
            labelAdd = new Label();
            labelPicture = new Label();
            pictureBoxProfile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.White;
            buttonSend.Cursor = Cursors.Hand;
            buttonSend.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSend.Location = new Point(73, 534);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(352, 44);
            buttonSend.TabIndex = 28;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // pictureBoxCloseButton
            // 
            pictureBoxCloseButton.Cursor = Cursors.Hand;
            pictureBoxCloseButton.Image = Properties.Resources.butonclose;
            pictureBoxCloseButton.Location = new Point(24, 12);
            pictureBoxCloseButton.Name = "pictureBoxCloseButton";
            pictureBoxCloseButton.Size = new Size(20, 20);
            pictureBoxCloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseButton.TabIndex = 27;
            pictureBoxCloseButton.TabStop = false;
            pictureBoxCloseButton.Click += pictureBoxCloseButton_Click;
            // 
            // pictureBoxMinimazeButton
            // 
            pictureBoxMinimazeButton.Cursor = Cursors.Hand;
            pictureBoxMinimazeButton.Image = Properties.Resources.butonminimaze1;
            pictureBoxMinimazeButton.Location = new Point(54, 12);
            pictureBoxMinimazeButton.Name = "pictureBoxMinimazeButton";
            pictureBoxMinimazeButton.Size = new Size(20, 20);
            pictureBoxMinimazeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimazeButton.TabIndex = 26;
            pictureBoxMinimazeButton.TabStop = false;
            pictureBoxMinimazeButton.Click += pictureBoxMinimazeButton_Click;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Cursor = Cursors.Hand;
            pictureBoxBack.Image = Properties.Resources.applebackbut_removebg_preview;
            pictureBoxBack.Location = new Point(84, 12);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(20, 20);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 25;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(64, 234);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(370, 27);
            textBoxName.TabIndex = 22;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(64, 181);
            labelName.Name = "labelName";
            labelName.Size = new Size(68, 28);
            labelName.TabIndex = 21;
            labelName.Text = "Name";
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAdd.ForeColor = Color.White;
            labelAdd.Location = new Point(135, 83);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(228, 46);
            labelAdd.TabIndex = 20;
            labelAdd.Text = "Add an artist";
            // 
            // labelPicture
            // 
            labelPicture.AutoSize = true;
            labelPicture.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelPicture.ForeColor = Color.White;
            labelPicture.Location = new Point(73, 383);
            labelPicture.Name = "labelPicture";
            labelPicture.Size = new Size(78, 28);
            labelPicture.TabIndex = 29;
            labelPicture.Text = "Picture";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Cursor = Cursors.Hand;
            pictureBoxProfile.Image = Properties.Resources.profile_removebg_preview;
            pictureBoxProfile.Location = new Point(235, 324);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(150, 150);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 30;
            pictureBoxProfile.TabStop = false;
            pictureBoxProfile.Click += pictureBoxProfile_Click;
            // 
            // FormAddAnArtist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(479, 653);
            Controls.Add(pictureBoxProfile);
            Controls.Add(labelPicture);
            Controls.Add(buttonSend);
            Controls.Add(pictureBoxCloseButton);
            Controls.Add(pictureBoxMinimazeButton);
            Controls.Add(pictureBoxBack);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddAnArtist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddAnArtist";
            Load += FormAddAnArtist_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSend;
        private PictureBox pictureBoxCloseButton;
        private PictureBox pictureBoxMinimazeButton;
        private PictureBox pictureBoxBack;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelAdd;
        private Label labelPicture;
        private PictureBox pictureBoxProfile;
    }
}