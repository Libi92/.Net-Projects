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
    public partial class MonthEndSale : Form
    {
        public MonthEndSale()
        {
            InitializeComponent();


        }

        private void MonthEndSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.MonthEndSaleFormClosed = true;
        }

        private void MonthEndSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDJDataSet3.GetPurchaseOfMonth' table. You can move, or remove it, as needed.
            this.getPurchaseOfMonthTableAdapter.Fill(this.mDJDataSet3.GetPurchaseOfMonth);
            // TODO: This line of code loads data into the 'mDJDataSet2.GetSaleOfMonth' table. You can move, or remove it, as needed.
            this.getSaleOfMonthTableAdapter.Fill(this.mDJDataSet2.GetSaleOfMonth);
            // TODO: This line of code loads data into the 'mDJDataSet1.GetCreditLimitedSupliers' table. You can move, or remove it, as needed.
            this.getCreditLimitedSupliersTableAdapter.Fill(this.mDJDataSet1.GetCreditLimitedSupliers);
            // TODO: This line of code loads data into the 'mDJDataSet.GetCreditLimitedCustomers' table. You can move, or remove it, as needed.
            this.getCreditLimitedCustomersTableAdapter.Fill(this.mDJDataSet.GetCreditLimitedCustomers);

        }
    }
}
