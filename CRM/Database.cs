using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CRM
{
    public class Database
    {
        protected MySqlConnection connection;
        protected string connectionDetails = "Server=52.206.157.109 ;Database=U05wTT;Uid=U05wTT;Pwd=53688630320; convert zero datetime=True";

        public void GetConnectionState()
        {
            if (this.connection.State.ToString() == "open")
            {
                Console.WriteLine("connection is open");
            }
            else
            {
                Console.WriteLine("connection is closed");
            }
        }

        public DataTable GetQueryResultAsDatatable(string selectQuery)
        {
            using (MySqlConnection connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable queryResult = new DataTable();
                adapter.Fill(queryResult);
                return queryResult;
            }

        }
        public string GetQueryResultAsString(string Selectquery)
        {
            using (MySqlConnection connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Selectquery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string result = reader.GetValue(0).ToString();
                    return result;
                }
                else
                {

                    return "No result.";
                }



            }
        }

    }
}
