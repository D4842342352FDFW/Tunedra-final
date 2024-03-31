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
    public partial class FormProfile : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Boy\\Desktop\\Tunedra\\Tunedra\\Tunedra\\bin\\Debug\\net8.0-windows\\db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private string savedImagePath = "";
        public static bool okprofile = false;
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            labelURSN.Text = FormLogIn.username;
            try
            {
                con.Open();
                string selector = "SELECT profilepicture FROM tbl_users WHERE username = ? AND password = ?";
                cmd = new OleDbCommand(selector, con);
                cmd.Parameters.AddWithValue("?", FormLogIn.username);
                cmd.Parameters.AddWithValue("?", FormLogIn.password);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null && reader.Read())
                    {
                        savedImagePath = reader["profilepicture"].ToString();
                        if (!string.IsNullOrEmpty(savedImagePath))
                        {
                            pictureBoxProfile.ImageLocation = savedImagePath;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No profile picture found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxProfile.Width - 3, pictureBoxProfile.Height - 3);
            Region rg = new Region(gp);
            pictureBoxProfile.Region = rg;
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

        private void SaveProfileImage(string imagePath)
        {
            try
            {
                con.Open();
                string updateDb = "UPDATE tbl_users SET profilepicture = ? WHERE username = ? AND password = ?";
                cmd = new OleDbCommand(updateDb, con);
                cmd.Parameters.AddWithValue("?", imagePath);
                cmd.Parameters.AddWithValue("?", FormLogIn.username);
                cmd.Parameters.AddWithValue("?", FormLogIn.password);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Profile picture updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found or wrong credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void labelLogOut_Click(object sender, EventArgs e)
        {

            okprofile = true;
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Close();
        }

        private void pictureBoxCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimazeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormInApp formInApp = new FormInApp();
            formInApp.Show();
            this.Hide();
        }
    }
}