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
    public partial class AddSuppliers : Form
    {
        public AddSuppliers()
        {
            InitializeComponent();
            GetNextKey();
        }

        private void GetNextKey()
        {
            QueryParamter outputParam = new QueryParamter("SuplrId", "", "varchar");
            string custId = DBUtils.getValue("NextSuplrId", new QueryParamter[] { }, outputParam);
            textBox1.Text = custId;
        }

        private void AddSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIMain.AddSuppliersFormClosed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Please enter an account no");
                return;
            }
            else if (!textBox3.Text.StartsWith("2"))
            {
                MessageBox.Show("Account no must start with 2");
                return;
            }
            else if (textBox3.Text.Length != 6)
            {
                MessageBox.Show("Account no must be 6 digit");
                return;
            }
            else
            {
                try
                {
                    long.Parse(textBox3.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Account no must a number");
                    return;
                }
            }

            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            else if ((textBox2.Text.Length < 5) || (textBox2.Text.Length > 20))
            {
                MessageBox.Show("Name must be 5 to 20 characters");
                return;
            }

            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("Please enter an address");
                return;
            }

            string suplrId = textBox1.Text.Split(new char[] { '_' })[1];
            QueryParamter[] parameters = new QueryParamter[]
            {
                new QueryParamter("Id", suplrId, "int"),
                new QueryParamter("Name", textBox2.Text, "varchar"),
                new QueryParamter("AccountNo", textBox3.Text, "varchar"),
                new QueryParamter("Address", textBox4.Text, "varchar"),
            };

            DBUtils.insertData("AddSupplier", parameters);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            GetNextKey();

            MessageBox.Show("New Supplier added");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                errorProviderWarning.SetError(textBox2, "Please fill");
                errorProviderError.SetError(textBox2, "");
                errorProviderSuccess.SetError(textBox2, "");
            }
            else if ((textBox2.Text.Length < 5) || (textBox2.Text.Length > 20))
            {
                errorProviderWarning.SetError(textBox2, "");
                errorProviderError.SetError(textBox2, "length must be between 5 and 20");
                errorProviderSuccess.SetError(textBox2, "");
            }
            else
            {
                errorProviderWarning.SetError(textBox2, "");
                errorProviderError.SetError(textBox2, "");
                errorProviderSuccess.SetError(textBox2, "Correct");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                errorProviderWarning.SetError(textBox3, "Please fill");
                errorProviderError.SetError(textBox3, "");
                errorProviderSuccess.SetError(textBox3, "");
            }
            else if (!textBox3.Text.StartsWith("2"))
            {
                errorProviderWarning.SetError(textBox3, "");
                errorProviderError.SetError(textBox3, "Must start with 2");
                errorProviderSuccess.SetError(textBox3, "");
            }
            else if (textBox3.Text.Length != 6)
            {
                errorProviderWarning.SetError(textBox3, "");
                errorProviderError.SetError(textBox3, "Must be 6 digit");
                errorProviderSuccess.SetError(textBox3, "");
            }
            else
            {
                try
                {
                    long.Parse(textBox3.Text);
                    errorProviderWarning.SetError(textBox3, "");
                    errorProviderError.SetError(textBox3, "");
                    errorProviderSuccess.SetError(textBox3, "Correct");
                }
                catch (Exception ex)
                {
                    errorProviderWarning.SetError(textBox3, "");
                    errorProviderError.SetError(textBox3, "Must be a number");
                    errorProviderSuccess.SetError(textBox3, "");
                }
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                errorProviderWarning.SetError(textBox4, "Please fill");
                errorProviderError.SetError(textBox4, "");
                errorProviderSuccess.SetError(textBox4, "");
            }
            else
            {
                errorProviderWarning.SetError(textBox4, "");
                errorProviderError.SetError(textBox4, "");
                errorProviderSuccess.SetError(textBox4, "Correct");
            }
        }
    }
}
