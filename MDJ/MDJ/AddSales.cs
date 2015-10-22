using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDJ.App_Code;

namespace MDJ
{
    public partial class AddSales : Form
    {
        public AddSales()
        {
            InitializeComponent();
        }

        private void AddSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDJDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mDJDataSet.Products);
            // TODO: This line of code loads data into the 'mDJDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mDJDataSet.Customers);

            this.dataGridView1.Columns.Add("Product", "Product");
            this.dataGridView1.Columns.Add("Description", "Description");
            this.dataGridView1.Columns.Add("Price", "Price");
            this.dataGridView1.Columns.Add("SellingPrice", "SellingPrice");
            this.dataGridView1.Columns.Add("Quantity", "Quantity");
            this.dataGridView1.Columns.Add("Total", "Total");
        }

        private void AddSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.AddSalesFormClosed = true;
            this.Dispose();
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
                new QueryParamter("CustId", comboBox1.SelectedValue.ToString(), "int"),
                new QueryParamter("DateTime", dateTime, "varchar"),
                new QueryParamter("Total", textBox1.Text, "varchar"),
                new QueryParamter("AmountPaid", textBox2.Text, "varchar"),
            };

            DBUtils.insertData("AddSales", parameters);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            dataGridView1.Rows.Clear();

            MessageBox.Show("Sales data added");
        }
    }
}
