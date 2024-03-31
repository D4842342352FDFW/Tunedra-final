using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tunedra
{
    public partial class FormAddAnArtist : Form
    {
        private string dbPath1;
        private string connectionString1;
        private OleDbConnection con1;
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter ad1 = new OleDbDataAdapter();
        public FormAddAnArtist()
        {
            InitializeComponent();
            dbPath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_artists.accdb");
            connectionString1 = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath1};";
            con1 = new OleDbConnection(connectionString1);
        }
        private void FormAddAnArtist_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxProfile.Width - 3, pictureBoxProfile.Height - 3);
            Region rg = new Region(gp);
            pictureBoxProfile.Region = rg;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || savedImagePath == "")
            {
                MessageBox.Show("Name field or picture is empty", "Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con1.Open();
                    string register = "INSERT INTO tbl_artists (Name, Picture) VALUES (?, ?)";
                    cmd1 = new OleDbCommand(register, con1);
                    cmd1.Parameters.AddWithValue("?", textBoxName.Text);
                    cmd1.Parameters.AddWithValue("?", savedImagePath);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Your Artist has been Successfully Added", "Success add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxName.Text = "";
                    savedImagePath = "";
                    new FormInApp().Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con1.State == ConnectionState.Open)
                    {
                        con1.Close();
                    }
                }
            }
        }
        private string savedImagePath = "";
        private void SaveProfileImage(string imagePath)
        {
            try
            {
                con1.Open();
                string updateDb = "UPDATE tbl_artists SET Picture = ? WHERE Name = ?";
                cmd1 = new OleDbCommand(updateDb, con1);
                cmd1.Parameters.AddWithValue("?", imagePath);
                cmd1.Parameters.AddWithValue("?", textBoxName.Text);
                int rows = cmd1.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Artist picture updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    savedImagePath = ofd.FileName;
                    pictureBoxProfile.ImageLocation = savedImagePath;
                    SaveProfileImage(savedImagePath);
                }
            }
            catch
            {
                MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormInApp formInApp = new FormInApp();
            formInApp.Show();
            this.Hide();
        }

        private void pictureBoxMinimazeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
