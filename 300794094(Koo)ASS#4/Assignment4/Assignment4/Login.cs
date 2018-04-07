using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string connetionString = null;

            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mike\Documents\300794094(Koo)ASS#4\Assignment4\Assignment4\UserLogin.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Customer where NameStyle='" + txtUserName.Text + "' and Password ='" + txtPassword.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int count = 0;
            if (dt.Rows[count][count].ToString() == "1")
            {
                this.Hide();
                Users s = new Users();
                s.Show();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration regis = new UserRegistration();
            regis.Show();
            //this.Close();
        }
    }
}
