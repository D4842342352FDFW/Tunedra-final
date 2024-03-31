using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Tunedra
{
    public partial class FormAddASong : Form
    {
        public static int contor;
        public static bool ok = false;
        public FormAddASong()
        {
            InitializeComponent();
            dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_songs.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            con = new OleDbConnection(connectionString);
        }

        private string dbPath;
        private string connectionString;
        private OleDbConnection con;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();
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
        private void buttonSend_Click(object sender, EventArgs e)
        {
            ok = false;
            if (textBoxTitle.Text == "" || textBoxArtist.Text == "" || textBoxFileName.Text == "")
            {
                MessageBox.Show("Title, Artist or File Name fields are empty", "Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contor++;
                ok = true;
                con.Open();
                string register = "INSERT INTO tbl_songss VALUES ('" + textBoxTitle.Text + "','" + textBoxArtist.Text + "','" + textBoxFileName.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                textBoxTitle.Text = "";
                textBoxArtist.Text = "";
                textBoxFileName.Text = "";
                MessageBox.Show("Your Song has been Successfully Added", "Success add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormInApp f1 = new FormInApp();
                f1.Show();
                this.Close();
            }
        }
    }
}
