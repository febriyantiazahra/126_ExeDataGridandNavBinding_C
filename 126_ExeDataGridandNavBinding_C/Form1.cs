using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _126_ExeDataGridandNavBinding_C
{
    public partial class Form1 : Form
    {
        readonly string user = "Febriyanti";
        readonly string pass = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == user && tbPassword.Text == pass)
            {
                this.Hide();
                MessageBox.Show("Berhasil Login");
                homepage data = new homepage();
                data.Show();
            }
            else if (tbUsername.Text == "" && tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password Harus diisi!");
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cekpass.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
