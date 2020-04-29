using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_iPole_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string id = textBoxMemberID.Text;
            string password = textBoxPassword.Text;

            if (id == "abe" && password == "hest")
            {
                this.Hide();

                MyBookingsToday nextPage = new MyBookingsToday();
                nextPage.Show();
            }
            else
            {
                MessageBox.Show("Member ID or Password was incorrect");
                textBoxPassword.Text = "";
            }
        }

        private void TextPassword_Click(object sender, EventArgs e)
        {

        }

        private void TextMemberID_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
