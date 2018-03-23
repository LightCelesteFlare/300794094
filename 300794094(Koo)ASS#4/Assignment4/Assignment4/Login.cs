using System;
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
            //if (IsvalidUser(txtUserName.Text, txtPassword.Text))
            //{
            //    Users F = new Users();
            //    F.Show();
            //}
        }

        private void btnNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration regis = new UserRegistration();
            regis.Show();
            this.Hide();
        }
        //private bool IsvalidUser(string userName, string password)

        //{



        //    //UserLoginEntities context = new UserLoginEntities();

        //    //var q = from p in context.Customers

        //    //        where p.NameStyle == txtUserName.Text

        //    //        && p.Password == txtPassword.Text

        //    //        select p;



        //    //if (q.Any())

        //    //{

        //    //    return true;

        //    //}

        //    //else

        //    //{

        //    //    return false;

        //    //}

        //}
    }
}
