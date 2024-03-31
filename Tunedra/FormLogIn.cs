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
    public partial class FormLogIn : Form
    {

        public FormLogIn()
        {
            InitializeComponent();
            dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_users.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            con = new OleDbConnection(connectionString);
        }

        private string dbPath;
        private string connectionString;
        private OleDbConnection con;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        public static string username;
        public static string password;
        private void pictureBoxCloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBoxMinimazeButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxBack_MouseClick(object sender, MouseEventArgs e)
        {
            FormStart form2 = new FormStart();
            form2.Show();
            this.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
            }
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + textBoxUsername.Text + "' and password= '" + textBoxPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                new FormInApp().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelHaveAnAcc_Click(object sender, EventArgs e)
        {
            FormRegister form2 = new FormRegister();
            form2.Show();
            this.Close();
        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            if (FormProfile.okprofile == true)
            {
                FormProfile form2 = new FormProfile();
                form2.Show();
                this.Close();
            }
            else
            if (FormInApp.okbk == true)
            {
                FormInApp form2 = new FormInApp();
                form2.Show();
                this.Close();

            }
            else
            {
                FormStart form2 = new FormStart();
                form2.Show();
                this.Close();
            }
        }
    }
}
