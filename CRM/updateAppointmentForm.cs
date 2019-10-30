using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM
{
    public partial class updateAppointmentForm : Form
    {
        private AppointmentManager appointmentManager = new AppointmentManager();
        private User user { get; set; } = new User();
        private int appointmentId;
        public void SetFields()
        {
            TimeConversion timeConversion = new TimeConversion();
            customerDataGridView.DataSource = this.appointmentManager.GetQueryResultAsDatatable("SELECT customerId, customerName FROM customer");
            titleTextbox.Text = this.appointmentManager.GetQueryResultAsString("SELECT title from appointment where appointmentId = '" + this.appointmentId + "'");
            descriptionTextbox.Text = this.appointmentManager.GetQueryResultAsString("SELECT description from appointment where appointmentId = '" + this.appointmentId + "'");
            locationTextbox.Text = this.appointmentManager.GetQueryResultAsString("SELECT location from appointment where appointmentId = '" + this.appointmentId + "'");
            contactTextbox.Text = this.appointmentManager.GetQueryResultAsString("SELECT contact from appointment where appointmentId = '" + this.appointmentId + "'");
            urlTextbox.Text = this.appointmentManager.GetQueryResultAsString("SELECT url from appointment where appointmentId = '" + this.appointmentId + "'");
            typeTextbox.Text = this.appointmentManager.GetQueryResultAsString("SELECT type from appointment where appointmentId = '" + this.appointmentId + "'");
            startDateTimePicker.Value = DateTime.Parse(this.appointmentManager.GetQueryResultAsString("SELECT convert_tz(start, '+00:00', '"+timeConversion.getUserTimeZoneOffset()+"') from appointment where appointmentId = '" + this.appointmentId + "'"));
            endDateTimePicker.Value = DateTime.Parse(this.appointmentManager.GetQueryResultAsString("SELECT convert_tz(end, '+00:00', '" + timeConversion.getUserTimeZoneOffset() + "') from appointment where appointmentId = '" + this.appointmentId + "'"));
        }
        private string getCustomerIdFromDataGridView(DataGridView dataGridView)
        {
            int rowindex = dataGridView.CurrentCell.RowIndex;
            int columnindex = dataGridView.CurrentCell.ColumnIndex;
            return dataGridView.Rows[rowindex].Cells[columnindex].Value.ToString();
        }
        public updateAppointmentForm(int appointmentId, User user)
        {
            InitializeComponent();
            this.user = user;
            this.appointmentId = appointmentId;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.appointmentManager.UpdateAppointment(Convert.ToInt32(getCustomerIdFromDataGridView(customerDataGridView)), titleTextbox.Text, descriptionTextbox.Text, locationTextbox.Text, contactTextbox.Text, urlTextbox.Text, startDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"), endDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), this.user.Username, typeTextbox.Text, this.user.UserId, this.appointmentId))
            {
                Translation errorControlMessage = new Translation();
                MessageBox.Show(errorControlMessage.GetInvalidTime());
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void updateAppointmentForm_Load(object sender, EventArgs e)
        {
            SetFields();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}