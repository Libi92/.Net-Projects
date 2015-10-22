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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryParamter[] parameters = new QueryParamter[]
            {
                new QueryParamter("Name", textBox1.Text, "varchar"),
                new QueryParamter("Description", textBox2.Text, "varchar"),
                new QueryParamter("Price", textBox3.Text, "varchar"),
                new QueryParamter("SellingPrice", textBox4.Text, "varchar"),
            };

            DBUtils.insertData("AddProducts", parameters);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            
            MessageBox.Show("New Product added");
        }

        private void AddProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.AddProductsFormClosed = true;
            this.Dispose();
        }
    }
}
