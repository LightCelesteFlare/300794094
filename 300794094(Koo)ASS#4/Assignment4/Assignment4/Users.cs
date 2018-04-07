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
    public partial class Users : Form
    {
        System.Data.SqlClient.SqlConnection con;
        public Users()
        {
            
            ShowCustomersFN();
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=..\300794094(Koo)ASS#4\Assignment4\Assignment4\UserLogin.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LogIn where Name='" + txtUserID.Text + "' and Password ='" + txtPassword.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //using (UserLoginModels context = new UserLoginModels())
            //{
            //    Customer cust = new Customer();
            //    cust.
            //}


            //var searchText = txtSearchEmail.Text;
            //using ( query = new UserLoginModels())
            //{
            //    var emailquery = from t in query.Customers
            //                     where t.EmailAddress == searchText
            //                     select t;
            //    dataGridView1.DataSource = emailquery;
            //    dataGridView1.BindingContext;
            //}
        }

        private void ShowCustomersFN()
        {
            //con = new System.Data.SqlClient.SqlConnection();
            //con.ConnectionString = "DataSource=.\\SQLEXPRESS;AttachDbFilename=UserLogin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //con.Open();
            //MessageBox.Show("Connection opened");
            //con.Close();
            //MessageBox.Show("Connection closed");
            using (Entities entity = new Entities())
            {
                var f = (from a in entity.Customers
                         join b in entity.Addresses on a.CustomerId equals b.AddressId
                         orderby a.FirstName
                         select new { name = a.FirstName, Address = b.AddressLine1 });
                


            }
        }

    }
}
