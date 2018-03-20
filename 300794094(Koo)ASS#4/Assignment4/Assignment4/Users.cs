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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //using (UserLoginModels context = new UserLoginModels())
            //{
            //    Customer cust = new Customer();
            //    cust.
            //}


            //var searchText = txtSearchEmail.Text;
            //using (UserLoginModels query = new UserLoginModels())
            //{
            //    var emailquery = from t in query.Customers
            //                     where t.EmailAddress == searchText
            //                     select t;
            //    dataGridView1.DataSource = emailquery;
            //    dataGridView1.BindingContext;
            //}
        }
    }
}
