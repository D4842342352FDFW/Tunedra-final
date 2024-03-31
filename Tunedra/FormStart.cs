using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tunedra
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void pictureBoxCloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimazeButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {

            FormRegister form3 = new FormRegister();
            form3.Show();
            this.Hide();

        }

        private void pictureBoxSingUp_MouseClick(object sender, MouseEventArgs e)
        {
            FormRegister form3 = new FormRegister();
            form3.Show();
            this.Hide();
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            FormLogIn form4 = new FormLogIn();
            form4.Show();
            this.Hide();
        }

        private void pictureBoxLogIn_Click(object sender, EventArgs e)
        {
            FormLogIn form4 = new FormLogIn();
            form4.Show();
            this.Hide();
        }
    }
}
