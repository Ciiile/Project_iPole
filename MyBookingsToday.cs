﻿using System;
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
    public partial class MyBookingsToday : Form
    {
        public MyBookingsToday()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 login = new Form1();
            login.Show();
        }
    }
}
