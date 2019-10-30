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
    public partial class reportForm : Form
    {
        public reportForm()
        {
            InitializeComponent();

        }
        public void LoadDataGridView(List<MonthRecord> AppointmentTypesPerMonth)
        {
            reportDataGridView.DataSource = AppointmentTypesPerMonth;
        }
        public void LoadDataGridView(DataTable schedule)
        {
            reportDataGridView.DataSource = schedule;
        }
        private void reportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
