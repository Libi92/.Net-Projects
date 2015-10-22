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
    public partial class MDIMain : Form
    {
        AddCustomer formAddCustomer;
        public static bool AddCustomerFormClosed = true;

        AddSuppliers formAddSuppliers;
        public static bool AddSuppliersFormClosed = true;

        ViewCustomer formViewCustomer;
        public static bool ViewCustomerFormClosed = true;

        ViewSuppliers formViewSuppliers;
        public static bool ViewSuppliersFormClosed = true;

        AddProducts formAddProducts;
        public static bool AddProductsFormClosed = true;

        ViewProducts formViewProducts;
        public static bool ViewProductsFormClosed = true;

        AddSales formAddSales;
        public static bool AddSalesFormClosed = true;

        ViewSales formViewSales;
        public static bool ViewSalesFormClosed = true;

        AddPurchase formAddPurchase;
        public static bool AddPurchaseFormClosed = true;

        ViewPurchase formViewPurchase;
        public static bool ViewPurchaseFormClosed = true;

        MonthEndSale formMonthEndSale;
        public static bool MonthEndSaleFormClosed = true;
        public MDIMain()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (AddCustomerFormClosed)
            {
                formAddCustomer = new AddCustomer();
                formAddCustomer.MdiParent = this;

                AddCustomerFormClosed = false;
                formAddCustomer.Visible = true;
            }
            
            
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (AddSuppliersFormClosed)
            {
                formAddSuppliers = new AddSuppliers();
                formAddSuppliers.MdiParent = this;

                AddSuppliersFormClosed = false;
                formAddSuppliers.Visible = true;
            }
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ViewCustomerFormClosed)
            {
                formViewCustomer = new ViewCustomer();
                formViewCustomer.MdiParent = this;

                ViewCustomerFormClosed = false;
                formViewCustomer.Visible = true;
            }
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (ViewSuppliersFormClosed)
            {
                formViewSuppliers = new ViewSuppliers();
                formViewSuppliers.MdiParent = this;

                ViewSuppliersFormClosed = false;
                formViewSuppliers.Visible = true;
            }
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (AddProductsFormClosed)
            {
                formAddProducts = new AddProducts();
                formAddProducts.MdiParent = this;

                AddProductsFormClosed = false;
                formAddProducts.Visible = true;
            }
        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (ViewProductsFormClosed)
            {
                formViewProducts = new ViewProducts();
                formViewProducts.MdiParent = this;

                ViewProductsFormClosed = false;
                formViewProducts.Visible = true;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddSalesFormClosed)
            {
                formAddSales = new AddSales();
                formAddSales.MdiParent = this;

                AddSalesFormClosed= false;
                formAddSales.Visible = true;
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ViewSalesFormClosed)
            {
                formViewSales = new ViewSales();
                formViewSales.MdiParent = this;

                ViewSalesFormClosed = false;
                formViewSales.Visible = true;
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (AddPurchaseFormClosed)
            {
                formAddPurchase = new AddPurchase();
                formAddPurchase.MdiParent = this;

                AddPurchaseFormClosed = false;
                formAddPurchase.Visible = true;
            }
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ViewPurchaseFormClosed)
            {
                formViewPurchase = new ViewPurchase();
                formViewPurchase.MdiParent = this;

                ViewPurchaseFormClosed = false;
                formViewPurchase.Visible = true;
            }
        }

        private void monthEndSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MonthEndSaleFormClosed)
            {
                formMonthEndSale = new MonthEndSale();
                formMonthEndSale.MdiParent = this;

                MonthEndSaleFormClosed = false;
                formMonthEndSale.Visible = true;
            }
        }
    }
}
