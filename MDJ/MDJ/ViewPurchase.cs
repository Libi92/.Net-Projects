using MDJ.App_Code;
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
    public partial class ViewPurchase : Form
    {
        public ViewPurchase()
        {
            InitializeComponent();

            DataTable table = DBUtils.getDataTable("GetPurchaseDetails", new QueryParamter[] { new QueryParamter("purchaseId", "0", "int") });

            dataGridView1.DataSource = table;
        }

        private void ViewPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.ViewPurchaseFormClosed = true;
        }
    }
}
