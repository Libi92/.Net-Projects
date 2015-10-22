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
    public partial class ViewSales : Form
    {
        public ViewSales()
        {
            InitializeComponent();
            DataTable table = DBUtils.getDataTable("GetSalesDetails", new QueryParamter[] { new QueryParamter("salesId", "0", "int") });
            
            dataGridView1.DataSource = table;

        }
    }
}
