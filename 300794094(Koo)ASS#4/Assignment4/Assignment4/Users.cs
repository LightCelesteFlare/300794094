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
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userLoginDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.userLoginDataSet2.Customer);
            // TODO: This line of code loads data into the 'userLoginDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.userLoginDataSet.Customer);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //using (UserLoginModels context = new UserLoginModels())
            //{
            //    Customer cust = new Customer();
            //    cust.
            //}


            var searchText = txtSearchEmail.Text;
            using (UserLoginModels query = new UserLoginModels())
            {
                var emailquery = from t in query.Customers
                                 where t.EmailAddress == searchText
                                 select t;
                dataGridView1.DataSource = emailquery;

            }
        }

        private void Address()
        {
            string connetionString = null;

            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mike\Documents\300794094(Koo)ASS#4\Assignment4\Assignment4\UserLogin.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Customer where NameStyle='" + txtFName.Text + "' and Password ='" + txtPassword.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
    }
}
