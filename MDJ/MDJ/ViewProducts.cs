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
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.ViewProductsFormClosed = true;
            this.Dispose();

        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDJDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mDJDataSet.Products);

        }
    }
}
