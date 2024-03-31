namespace Tunedra
{
    partial class FormAddASong
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
            labelAdd = new Label();
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            labelArtist = new Label();
            textBoxArtist = new TextBox();
            labelFileName = new Label();
            textBoxFileName = new TextBox();
            pictureBoxBack = new PictureBox();
            pictureBoxMinimazeButton = new PictureBox();
            pictureBoxCloseButton = new PictureBox();
            buttonSend = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).BeginInit();
            SuspendLayout();
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAdd.ForeColor = Color.White;
            labelAdd.Location = new Point(135, 83);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(197, 46);
            labelAdd.TabIndex = 0;
            labelAdd.Text = "Add a song";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(64, 177);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(54, 28);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(64, 218);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(370, 27);
            textBoxTitle.TabIndex = 2;
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelArtist.ForeColor = Color.White;
            labelArtist.Location = new Point(64, 271);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(65, 28);
            labelArtist.TabIndex = 3;
            labelArtist.Text = "Artist";
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(64, 319);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(370, 27);
            textBoxArtist.TabIndex = 4;
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFileName.ForeColor = Color.White;
            labelFileName.Location = new Point(64, 376);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(102, 28);
            labelFileName.TabIndex = 5;
            labelFileName.Text = "File name";
            // 
            // textBoxFileName
            // 
            textBoxFileName.Location = new Point(64, 430);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(370, 27);
            textBoxFileName.TabIndex = 6;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Cursor = Cursors.Hand;
            pictureBoxBack.Image = Properties.Resources.applebackbut_removebg_preview;
            pictureBoxBack.Location = new Point(84, 12);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(20, 20);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 16;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // pictureBoxMinimazeButton
            // 
            pictureBoxMinimazeButton.Cursor = Cursors.Hand;
            pictureBoxMinimazeButton.Image = Properties.Resources.butonminimaze1;
            pictureBoxMinimazeButton.Location = new Point(54, 12);
            pictureBoxMinimazeButton.Name = "pictureBoxMinimazeButton";
            pictureBoxMinimazeButton.Size = new Size(20, 20);
            pictureBoxMinimazeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimazeButton.TabIndex = 17;
            pictureBoxMinimazeButton.TabStop = false;
            pictureBoxMinimazeButton.Click += pictureBoxMinimazeButton_Click;
            // 
            // pictureBoxCloseButton
            // 
            pictureBoxCloseButton.Cursor = Cursors.Hand;
            pictureBoxCloseButton.Image = Properties.Resources.butonclose;
            pictureBoxCloseButton.Location = new Point(24, 12);
            pictureBoxCloseButton.Name = "pictureBoxCloseButton";
            pictureBoxCloseButton.Size = new Size(20, 20);
            pictureBoxCloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseButton.TabIndex = 18;
            pictureBoxCloseButton.TabStop = false;
            pictureBoxCloseButton.Click += pictureBoxCloseButton_Click;
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.White;
            buttonSend.Cursor = Cursors.Hand;
            buttonSend.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSend.Location = new Point(73, 534);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(352, 44);
            buttonSend.TabIndex = 19;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // FormAddASong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(479, 653);
            Controls.Add(buttonSend);
            Controls.Add(pictureBoxCloseButton);
            Controls.Add(pictureBoxMinimazeButton);
            Controls.Add(pictureBoxBack);
            Controls.Add(textBoxFileName);
            Controls.Add(labelFileName);
            Controls.Add(textBoxArtist);
            Controls.Add(labelArtist);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Controls.Add(labelAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddASong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdd";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimazeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAdd;
        private Label labelTitle;
        private TextBox textBoxTitle;
        private Label labelArtist;
        private TextBox textBoxArtist;
        private Label labelFileName;
        private TextBox textBoxFileName;
        private PictureBox pictureBoxBack;
        private PictureBox pictureBoxMinimazeButton;
        private PictureBox pictureBoxCloseButton;
        private Button buttonSend;
    }
}