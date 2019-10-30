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
using System.Globalization;
using System.Dynamic;
using System.IO;

namespace CRM
{
    public partial class mainForm : Form
    {
        private Database database = new Database();
        private User user = new User();
        private List<LoginRecord> logins = new List<LoginRecord>();
        private TimeConversion timeConversion = new TimeConversion();

        private int getAppointmentIdFromDataGridView()
        {
            int rowindex = appointmentDataGridView.CurrentCell.RowIndex;
            int columnindex = appointmentDataGridView.CurrentCell.ColumnIndex;
            return Convert.ToInt32(appointmentDataGridView.Rows[rowindex].Cells[0].Value.ToString());
        }
        private void resetAppointmentDataGridView()
        {
            if (weekRadioButton.Checked == true)
            {
                loadAppointmentDataGridViewToWeek();
            }
            else if (monthRadioButton.Checked == true)
            {
                loadAppointmentDataGridViewToMonth();
            }
            else
            {
                loadAppointmentDataGridViewToAll();
            }
        }
        private void loadCustomerDataGridView()
        {
            customerDataGridView.DataSource = database.GetQueryResultAsDatatable("SELECT customerId as 'Customer ID', customerName as 'Customer Name' FROM customer ORDER BY customerId");
        }
        private void loadAppointmentDataGridViewToAll()
        {
            appointmentDataGridView.DataSource = database.GetQueryResultAsDatatable("SELECT appointmentid as 'Appointment ID', title as 'Title', description as 'Description', customerId as 'Customer ID', contact as 'Contact', type as 'Type', convert_tz(start, '+00:00', '" + this.timeConversion.getUserTimeZoneOffset() + "') as 'Start', convert_tz(end, '+00:00', '" + this.timeConversion.getUserTimeZoneOffset() + "') as 'End' FROM appointment WHERE userId = '" +user.UserId+"' ORDER BY start ");
        }
        private void loadAppointmentDataGridViewToWeek()
        {
            appointmentDataGridView.DataSource = database.GetQueryResultAsDatatable("SELECT appointmentid as 'Appointment ID', title as 'Title', description as 'Description', customerId as 'Customer ID', contact as 'Contact', type as 'Type', convert_tz(start, '+00:00', '" + this.timeConversion.getUserTimeZoneOffset() + "') as 'Start', convert_tz(end, '+00:00', '" + this.timeConversion.getUserTimeZoneOffset() + "') as 'End' FROM appointment WHERE cast(start AS date) BETWEEN '"+ DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek).ToString("yyyy-MM-dd")+"' AND '" + DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek).AddDays(7).AddSeconds(-1).ToString("yyyy-MM-dd") + "' and userId = '"+user.UserId+"' order by start");
        }
        private void loadAppointmentDataGridViewToMonth()
        {
            appointmentDataGridView.DataSource = database.GetQueryResultAsDatatable("SELECT appointmentid as 'Appointment ID', title as 'Title', description as 'Description', customerId as 'Customer ID', contact as 'Contact', type as 'Type', convert_tz(start, '+00:00', '" + this.timeConversion.getUserTimeZoneOffset() + "') as 'Start', convert_tz(end, '+00:00', '" + this.timeConversion.getUserTimeZoneOffset() + "') as 'End' FROM appointment WHERE cast(start AS date) BETWEEN '"+ new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("yyyy-MM-dd") + "' AND '"+ new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd") + "' and userid = '"+user.UserId+"' order by start");
        }
        private int getCustomerIdFromDataGridView()
        {
            int rowindex = customerDataGridView.CurrentCell.RowIndex;
            int columnindex = 0;
            return Convert.ToInt32(customerDataGridView.Rows[rowindex].Cells[columnindex].Value.ToString());
        }
        private Boolean checkForUpcomingAppointments()
        {
            DataTable upcomingAppointmentsResult = database.GetQueryResultAsDatatable("SELECT * FROM appointment WHERE convert_tz(start, '+00:00', '"+timeConversion.getUserTimeZoneOffset()+"') between '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + DateTime.Now.AddMinutes(15).ToString("yyyy-MM-dd HH:mm:ss") + "' and userId = '" + this.user.UserId + "'");
            if (upcomingAppointmentsResult.Rows.Count >= 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            loginForm login = new loginForm();
            login.TopMost = true;
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.user = login.GetUser();
                loadCustomerDataGridView();
                loadAppointmentDataGridViewToAll();
                this.logins.Add(new LoginRecord(this.user.UserId, this.user.Username, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                if (checkForUpcomingAppointments())
                {
                    reminderForm reminderForm = new reminderForm(this.user);
                    reminderForm.TopMost = true;
                    reminderForm.Show();

                }
            }
        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadAppointmentDataGridViewToMonth();
        }

        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadAppointmentDataGridViewToWeek();
        }
        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            addAppointmentForm addAppointment = new addAppointmentForm(this.user);
            if (addAppointment.ShowDialog() == DialogResult.OK)
            {
                resetAppointmentDataGridView();
            }
        }

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentManager appointmentManager = new AppointmentManager();
            appointmentManager.DeleteAppointment(getAppointmentIdFromDataGridView());
            resetAppointmentDataGridView();
        }

        private void updateAppointmentButton_Click(object sender, EventArgs e)
        {
            updateAppointmentForm updateAppointment = new updateAppointmentForm(getAppointmentIdFromDataGridView(), this.user);
            if (updateAppointment.ShowDialog() == DialogResult.OK)
            {
                resetAppointmentDataGridView();
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
           
        }

        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            addCustomerForm addCustomer = new addCustomerForm(this.user.Username);
            if (addCustomer.ShowDialog() == DialogResult.OK)
            {
                loadCustomerDataGridView();
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerManager customerManager = new CustomerManager();
            int selectedCustomerId = getCustomerIdFromDataGridView();
            customerManager.DeleteCustomer(selectedCustomerId);
            loadCustomerDataGridView();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            updateCustomerForm addCustomer = new updateCustomerForm(getCustomerIdFromDataGridView());
            if (addCustomer.ShowDialog() == DialogResult.OK)
            {
                loadCustomerDataGridView();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Logins.txt"))
            {
                this.logins.ForEach((login) => writer.WriteLine(String.Concat(login.userId, login.userName, login.loginTime)));
            }
            this.Close();
        }

        private void appointmentTypeReportButton_Click(object sender, EventArgs e)
        {
            ReportGenerator reportGenerator = new ReportGenerator();
            reportForm reportForm = new reportForm();
            reportForm.LoadDataGridView(reportGenerator.GetAppointmentTypesPerMonth());
            reportForm.Show();
        }

        private void ConsultantSchedulesReportButton_Click(object sender, EventArgs e)
        {
            ReportGenerator reportGenerator = new ReportGenerator();
            reportForm reportForm = new reportForm();
            reportForm.LoadDataGridView(reportGenerator.GetSchedules());
            reportForm.Show();
        }

        private void CustomersAddedReportButton_Click(object sender, EventArgs e)
        {
            ReportGenerator reportGenerator = new ReportGenerator();
            reportForm reportForm = new reportForm();
            reportForm.LoadDataGridView(reportGenerator.GetTotalAppointmentsCreated());
            reportForm.Show();
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadAppointmentDataGridViewToAll();
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            var searchTerm = String.Concat("%", searchCustomerTextbox.Text, "%");
            customerDataGridView.DataSource = this.database.GetQueryResultAsDatatable("SELECT customerId as 'Customer ID', customerName as 'Customer Name' FROM customer WHERE customerName LIKE '" + searchTerm + "'");
        }

        private void searchAppointmentButton_Click(object sender, EventArgs e)
        {
            var searchTerm = String.Concat("%", searchAppointmentTextbox.Text, "%");
            appointmentDataGridView.DataSource = this.database.GetQueryResultAsDatatable("SELECT appointmentid as 'Appointment ID', title as 'Title', description as 'Description', customerId as 'Customer ID', contact as 'Contact', type as 'Type', convert_tz(start, '+00:00', '" + this.timeConversion.getUserTimeZoneOffset() + "') as 'Start', convert_tz(end, '+00:00', '" + this.timeConversion.getUserTimeZoneOffset() + "') as 'End' FROM appointment WHERE title LIKE '"+ searchTerm +"' ");
        }

        private void customerClearSearchButton_Click(object sender, EventArgs e)
        {
            searchCustomerTextbox.Text = "";
            loadCustomerDataGridView();
        }

        private void appointmentClearSearchButton_Click(object sender, EventArgs e)
        {
            searchAppointmentTextbox.Text = "";
            resetAppointmentDataGridView();
        }
    }
}
