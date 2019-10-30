using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace CRM
{
    public class ReportGenerator: Database
    {
        private string incrementMonth(int i)
        {
            string date = "2019-01-01";
            if (i.ToString().Length == 1)
            {
                return date.Remove(5, 2).Insert(5, String.Concat("0", i.ToString()));
            }
            else
            {
                return date.Remove(5, 2).Insert(5, i.ToString());
            }
        }
        public List<MonthRecord> GetAppointmentTypesPerMonth()
        {
            List<MonthRecord> appointmentTypesPerMonth = new List<MonthRecord>();
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < months.Length; i++)
            {
                appointmentTypesPerMonth.Add(new MonthRecord(months[i], Convert.ToInt32(GetQueryResultAsString("SELECT count(DISTINCT type) FROM appointment WHERE cast(start AS date) BETWEEN cast((cast('" + incrementMonth(i) + "' as date) - extract(day from cast('" + incrementMonth(i) + "' as date)) + 1) AS date) AND LAST_DAY(cast('" + incrementMonth(i) + "' as date))"))));
            }
            return appointmentTypesPerMonth;
        }
        public DataTable GetSchedules()
        {
            TimeConversion timeConversion = new TimeConversion();
            return GetQueryResultAsDatatable("select appointment.userId, userName as 'User Name', appointmentId as 'Appointment ID', convert_tz(start, '+00:00', '" + timeConversion.getUserTimeZoneOffset() + "') as 'Start', convert_tz(end, '+00:00', '" + timeConversion.getUserTimeZoneOffset() + "') as 'End' from appointment join user on appointment.userId = user.userId order by userId, start");
        }
        public DataTable GetTotalAppointmentsCreated()
        {
            return GetQueryResultAsDatatable("select appointment.userId, count(appointmentId) as 'Appointments Created' from user join appointment on user.userId = appointment.userId group by userId");
        }
    }

}
