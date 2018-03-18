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
            // TODO: This line of code loads data into the 'userLoginDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.userLoginDataSet1.Customer);
            // TODO: This line of code loads data into the 'userLoginDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.userLoginDataSet.Customer);

        }
    }
}
