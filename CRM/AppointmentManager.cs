using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRM
{
    public class AppointmentManager: Database
    {
        public Boolean checkIfTimeIsValid(string start)
        {
            double appointmentStartTime = Convert.ToDouble(start.Substring(10, 5).Replace(":", "."));
            int openTime = 7;
            int closeTime = 18;
            if (openTime <= appointmentStartTime && closeTime >= appointmentStartTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean AddAppointment(int customerId, string title, string description, string location, string contact, string url, string start, string end, string createDate, string createdBy, string lastUpdate, string lastUpdateBy, string type, int userId)
        {
            if (checkIfTimeIsValid(start))
            {
                TimeConversion timeConversion = new TimeConversion();
                using (connection = new MySqlConnection(this.connectionDetails))
                {
                    connection.Open();
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO appointment(customerid, title, description, location, contact, url, start, end, createdate, createdby, lastupdate, lastupdateby, type, userid) VALUES(@customerid, @title, @description, @location, @contact, @url, convert_tz(@start, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), convert_tz(@end, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), convert_tz(@createdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), @createdby, convert_tz(@lastupdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), @lastupdateby, @type, @userid)";

                        command.Parameters.AddWithValue("@customerid", customerId);
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@location", location);
                        command.Parameters.AddWithValue("@contact", contact);
                        command.Parameters.AddWithValue("@url", url);
                        command.Parameters.AddWithValue("@start", start);
                        command.Parameters.AddWithValue("@end", end);
                        command.Parameters.AddWithValue("@createdate", createDate);
                        command.Parameters.AddWithValue("@createdby", createdBy);
                        command.Parameters.AddWithValue("@lastupdate", lastUpdate);
                        command.Parameters.AddWithValue("@lastupdateby", lastUpdateBy);
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@userid", userId);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteAppointment(int appointmentId)
        {
            using (connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM appointment WHERE appointmentId = @appointmentid";

                    command.Parameters.AddWithValue("@appointmentid", Convert.ToInt32(appointmentId));

                    command.ExecuteNonQuery();
                }
            }
        }
        public Boolean UpdateAppointment(int customerId, string title, string description, string location, string contact, string url, string start, string end, string lastUpdate, string lastUpdateBy, string type, int userId, int appointmentId)
        {
            TimeConversion timeConversion = new TimeConversion();
            if (checkIfTimeIsValid(start))
            {
                using (connection = new MySqlConnection(this.connectionDetails))
                {
                    connection.Open();
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Update appointment SET customerid = @customerid, title = @title, description = @description, location = @location, contact = @contact, url = @url, start = convert_tz(@start, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), end = convert_tz(@end, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), lastupdate = convert_tz(@lastupdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), lastupdateby = @lastupdateby, type = @type, userid = @userid WHERE appointmentId = '" + appointmentId + "'";

                        command.Parameters.AddWithValue("@customerid", customerId);
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@location", location);
                        command.Parameters.AddWithValue("@contact", contact);
                        command.Parameters.AddWithValue("@url", url);
                        command.Parameters.AddWithValue("@start", start);
                        command.Parameters.AddWithValue("@end", end);
                        command.Parameters.AddWithValue("@lastupdate", lastUpdate);
                        command.Parameters.AddWithValue("@lastupdateby", lastUpdateBy);
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@userid", userId);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
