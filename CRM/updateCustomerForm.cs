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
    public partial class updateCustomerForm : Form
    {
        private int customerId;
        private CustomerManager customerManager = new CustomerManager();
        public updateCustomerForm(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }
        private void selectCustomersCountryInDataGridView(int customerId)
        {
            string searchValue = customerManager.GetQueryResultAsString("SELECT countryId FROM country WHERE countryId = (SELECT countryId FROM city WHERE cityId = (SELECT cityId FROM city WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = '" + customerId + "'))))");
            int rowIndex = -1;
            foreach (DataGridViewRow row in countryDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            countryDataGridView.Rows[rowIndex].Selected = true;
        }
        private void loadFields(int customerId)
        {
            NameTextbox.Text = this.customerManager.GetQueryResultAsString("SELECT customerName FROM customer WHERE customerId = '" + customerId + "'");
            streetAddressTextbox.Text = this.customerManager.GetQueryResultAsString("SELECT address FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = '" + customerId + "')");
            cityTextbox.Text = this.customerManager.GetQueryResultAsString("SELECT city FROM city WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = '" + customerId + "'))");
            postalCodeTextbox.Text = this.customerManager.GetQueryResultAsString("SELECT postalCode FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = '" + customerId + "')");
            selectCustomersCountryInDataGridView(customerId);
            phoneNumberTextbox.Text = this.customerManager.GetQueryResultAsString("SELECT phone FROM address WHERE addressId = (SELECT addressId from customer WHERE customerId = '" + customerId + "')");
        }
        private int getCountryIdFromDataGridView()
        {
            int rowindex = countryDataGridView.CurrentCell.RowIndex;
            int columnindex = 0;
            return Convert.ToInt32(countryDataGridView.Rows[rowindex].Cells[columnindex].Value.ToString());
        }
        private void updateCustomerForm_Load(object sender, EventArgs e)
        {
            countryDataGridView.DataSource = this.customerManager.GetQueryResultAsDatatable("SELECT countryId, country FROM country");
            loadFields(this.customerId);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            customerManager.UpdateCustomer(NameTextbox.Text, this.customerId, cityTextbox.Text, getCountryIdFromDataGridView(), NameTextbox.Text, streetAddressTextbox.Text, postalCodeTextbox.Text, phoneNumberTextbox.Text, Convert.ToInt32(customerManager.GetQueryResultAsString("SELECT cityid FROM city WHERE city = '"+cityTextbox.Text+"'")));
            this.DialogResult = DialogResult.OK;
        }
    }
}
