﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration regis = new UserRegistration();
            regis.Show();
            //this.Close();
        }
    }
}
