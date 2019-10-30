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
    public partial class reminderForm : Form
    {
        private Database database = new Database();
        private User user = new User();
        public reminderForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public mainForm mainform
        {
            get => default(mainForm);
            set
            {
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reminderForm_Load(object sender, EventArgs e)
        {
            TimeConversion timeConversion = new TimeConversion();
            reminderDataGridView.DataSource = this.database.GetQueryResultAsDatatable("SELECT appointmentid, title, description, customerId, contact, type, convert_tz(start, '+00:00', '"+timeConversion.getUserTimeZoneOffset()+ "') as 'start', convert_tz(end, '+00:00', '" + timeConversion.getUserTimeZoneOffset() + "') as 'end' FROM appointment WHERE convert_tz(start, '+00:00', '" + timeConversion.getUserTimeZoneOffset() + "') between '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + DateTime.Now.AddMinutes(15).ToString("yyyy-MM-dd HH:mm:ss") + "' and userId = '" + this.user.UserId + "'");
        }
    }
}
