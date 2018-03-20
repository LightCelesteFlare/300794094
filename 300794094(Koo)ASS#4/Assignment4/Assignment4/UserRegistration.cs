using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Assignment4
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //using (UserLoginModels context = new UserLoginModels())
            //{
            //    Customer cust = new Customer();
            //    cust.NameStyle = txtUserID.Text;
            //    cust.FirstName = txtFName.Text;
            //    cust.LastName = txtLName.Text;
            //    cust.Phone = txtPhoneNumber.Text;
            //    cust.EmailAddress = txtEmail.Text;
            //    cust.Password = txtPassword.Text;
            //    try { 
            //    context.Customers.Add(cust);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("There is a error in adding register");
            //        return;
            //    }
            //    context.SaveChanges();
            //}

            //string Username = "INSERT INTO CUSTOMER(NameStyle) VALUES (@text1)";
            //string FName = "INSERT INTO CUSTOMER(FirstName) VALUES (@text2)";
            //string LName = "INSERT INTO CUSTOMER(LastName) VALUES (@text3)";
            //string phoneNum = "INSERT INTO CUSTOMER(Phone) VALUES (@text4)";
            //string Email = "INSERT INTO CUSTOMER(EmailAddress) VALUES (@text5)";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login Home = new Login(); //Create object of Page2
            Home.Show(); //Show page2
            //this.Close(); //this will close Page1
        }
    }
}
