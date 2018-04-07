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
using System.Data.SqlClient;

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
            //    context.SaveChanges();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("There is a error in adding register");
            //        return;
            //    }
            string str = null;

            str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mike\Documents\300794094(Koo)ASS#4\Assignment4\Assignment4\UserLogin.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(str))
            {
                //String query = "INSERT INTO dbo.Customer (id,NameStyle,FirstName,LastName,Phone,Password,EmailAddress,CompanyName) VALUES (@id,@username,@FN,@LN,@phone,@password,@email,@Company)";
                String query = "INSERT INTO dbo.Customer (NameStyle,FirstName,LastName,Phone,Password,EmailAddress,CompanyName) VALUES (@username,@FN,@LN,@phone,@password,@email,@Company)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", txtUserID.Text);
                    command.Parameters.AddWithValue("@FN", txtFName.Text);
                    command.Parameters.AddWithValue("@LN", txtLName.Text);
                    command.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Company", txtCompany.Text);

                    connection.Open();
                    
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    { 
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    connection.Close();
                }
            }

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
