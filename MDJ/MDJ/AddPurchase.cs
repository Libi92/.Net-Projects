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
    public partial class AddPurchase : Form
    {
        public AddPurchase()
        {
            InitializeComponent();
        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDJDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mDJDataSet.Products);
            // TODO: This line of code loads data into the 'mDJDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.mDJDataSet.Suppliers);


            this.dataGridView1.Columns.Add("Product", "Product");
            this.dataGridView1.Columns.Add("Description", "Description");
            this.dataGridView1.Columns.Add("Price", "Price");
            this.dataGridView1.Columns.Add("SellingPrice", "SellingPrice");
            this.dataGridView1.Columns.Add("Quantity", "Quantity");
            this.dataGridView1.Columns.Add("Total", "Total");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QueryParamter[] parameters = new QueryParamter[]
            {
                new QueryParamter("Id", comboBox2.SelectedValue.ToString(), "int")
            };

            DataTable table = DBUtils.getDataTable("GetProducts", parameters);

            int itemTotal = Int32.Parse(textBox3.Text) * Int32.Parse(table.Rows[0][4].ToString());

            dataGridView1.Rows.Add(table.Rows[0][1], table.Rows[0][2], table.Rows[0][3], table.Rows[0][4], textBox3.Text, itemTotal);

            int total = Int32.Parse(textBox1.Text) + itemTotal;

            textBox1.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            QueryParamter[] parameters = new QueryParamter[]
            {
                new QueryParamter("SuplrId", comboBox1.SelectedValue.ToString(), "int"),
                new QueryParamter("DateTime", dateTime, "varchar"),
                new QueryParamter("Total", textBox1.Text, "varchar"),
                new QueryParamter("AmountPaid", textBox2.Text, "varchar"),
            };

            DBUtils.insertData("AddPurchase", parameters);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            dataGridView1.Rows.Clear();

            MessageBox.Show("Purchase data added");
        }

        private void AddPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.AddPurchaseFormClosed = true;
        }
    }
}
