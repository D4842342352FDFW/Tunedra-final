using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.OleDb;
namespace Tunedra
{
    public partial class FormRegister : Form
    {
        public FormRegister()
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
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxCPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (textBoxPassword.Text == textBoxCPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + textBoxUsername.Text + "','" + textBoxPassword.Text + "','" + "" +"')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxCPassword.Text = "";
                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxCPassword.Text = "";
                textBoxPassword.Focus();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxCPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxCPassword.PasswordChar = '•';
            }
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            FormLogIn form2 = new FormLogIn();
            form2.Show();
            this.Close();
        }

        private void labelHaveAnAcc_Click(object sender, EventArgs e)
        {
            FormLogIn form2 = new FormLogIn();
            form2.Show();
            this.Close();
        }
    }
}