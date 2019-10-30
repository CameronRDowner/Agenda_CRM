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
    public partial class addAppointmentForm : Form
    {
       
        private AppointmentManager appointmentManager = new AppointmentManager();
        private User user { get; set; } = new User();
        public addAppointmentForm(User user)
        {
            InitializeComponent();
            customerDataGridView.DataSource = appointmentManager.GetQueryResultAsDatatable("SELECT customerId, customerName FROM customer");
            this.user = user;
        }
        private string getCustomerIdFromDataGridView(DataGridView dataGridView)
        {
            int rowindex = dataGridView.CurrentCell.RowIndex;
            int columnindex = 0;
            return dataGridView.Rows[rowindex].Cells[columnindex].Value.ToString();
        }

        private void addAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.appointmentManager.AddAppointment(Convert.ToInt32(getCustomerIdFromDataGridView(customerDataGridView)), titleTextbox.Text, descriptionTextbox.Text, locationTextbox.Text, contactTextbox.Text, urlTextbox.Text, startDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"), endDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), this.user.Username, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), user.Username, typeTextbox.Text, this.user.UserId))
            {
                Translation errorControlMessage = new Translation();
                MessageBox.Show(errorControlMessage.GetInvalidTime());
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
