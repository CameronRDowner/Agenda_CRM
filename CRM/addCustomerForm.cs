using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class addCustomerForm : Form
    {
        private string userName;
        private CustomerManager customerManager = new CustomerManager();
        public addCustomerForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        private int getCountryIdFromDataGridView()
        {
            int rowindex = countryDataGridView.CurrentCell.RowIndex;
            int columnindex = countryDataGridView.CurrentCell.ColumnIndex;
            return Convert.ToInt32(countryDataGridView.Rows[rowindex].Cells[columnindex].Value.ToString());
        }
        private void addCustomerForm_Load(object sender, EventArgs e)
        {
            countryDataGridView.DataSource = this.customerManager.GetQueryResultAsDatatable("SELECT countryId, country FROM country");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.customerManager.AddCustomer(NameTextbox.Text, phoneNumberTextbox.Text, postalCodeTextbox.Text, streetAddressTextbox.Text, getCountryIdFromDataGridView(), cityTextbox.Text, this.userName);
            this.DialogResult = DialogResult.OK;
        }

        private void streetAddressTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
