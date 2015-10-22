using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDJ
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.ViewCustomerFormClosed = true;
            this.Dispose();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDJDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mDJDataSet.Customers);

        }
    }
}
