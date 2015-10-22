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
    public partial class ViewSuppliers : Form
    {
        public ViewSuppliers()
        {
            InitializeComponent();
        }

        private void ViewSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDJDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.mDJDataSet.Suppliers);

        }

        private void ViewSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.ViewSuppliersFormClosed = true;
        }
    }
}
