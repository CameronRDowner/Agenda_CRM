using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRM
{
    public class CustomerManager : Database
    {
        private Boolean checkIfDuplicateCityExists(string cityName)
        {
            DataTable result = GetQueryResultAsDatatable("SELECT COUNT(*) FROM city WHERE UPPER(city) = UPPER('" + cityName + "')");
            if (result.Rows[0][0].ToString() == "1")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private Boolean checkIfDuplicateAddressExists(string address, string postalCode)
        {
            DataTable result = GetQueryResultAsDatatable("SELECT COUNT(*) FROM address WHERE UPPER(address) = UPPER('" + address + "') AND UPPER(postalcode) = UPPER('" + postalCode + "')");
            if (result.Rows[0][0].ToString() == "1")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private Boolean checkIfDuplicateCustomerExists(string address, string customerName)
        {

            int addressId = Convert.ToInt32(GetQueryResultAsString("SELECT addressId from address WHERE UPPER(address) = UPPER('" + address + "')"));
            DataTable result = GetQueryResultAsDatatable("SELECT COUNT(*) FROM customer WHERE UPPER(customerName) = UPPER('" + customerName + "') AND UPPER(addressId) = UPPER('" + addressId + "')");
            if (result.Rows[0][0].ToString() == "1")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private void addCity(string city, int countryId, string userName)
        {
            TimeConversion timeConversion = new TimeConversion();
            using (connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@city, @countryId, convert_tz(@createDate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), @createdBy, convert_tz(@lastupdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), @lastUpdateBy)";

                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@countryId", countryId);
                    command.Parameters.AddWithValue("@createDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@createdBy", userName);
                    command.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@lastUpdateBy", userName);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void addAddress(string address, string city, string postalCode, string phoneNumber, string userName)
        {
            TimeConversion timeConversion = new TimeConversion();
            using (connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO address (address, cityId, postalCode, phone, createdBy, createDate, lastUpdate, lastUpdateBy) VALUES (@address, @cityId, @postalCode, @phone, @createdBy, convert_tz(@createDate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), convert_tz(@lastupdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), @lastUpdateBy)";

                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@cityId", Convert.ToInt32(GetQueryResultAsString("SELECT cityId FROM city WHERE city = '" + city + "'")));
                    command.Parameters.AddWithValue("@postalCode", postalCode);
                    command.Parameters.AddWithValue("@phone", phoneNumber);
                    command.Parameters.AddWithValue("@createdBy", userName);
                    command.Parameters.AddWithValue("@createDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@lastUpdateBy", userName);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddCustomer(string name, string phoneNumber, string postalCode, string address, int countryId, string city, string userName)
        {
            TimeConversion timeConversion = new TimeConversion();
            if (!checkIfDuplicateCityExists(city))
            {
                addCity(city, countryId, userName);
            }
            if (!checkIfDuplicateAddressExists(address, postalCode))
            {
                addAddress(address, city, postalCode, phoneNumber, userName);
            }
            if (!checkIfDuplicateCustomerExists(address, name))
            {
                using (connection = new MySqlConnection(this.connectionDetails))
                {
                    connection.Open();
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerName, @addressId, @active, convert_tz(@createDate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), @createdBy, convert_tz(@lastupdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), @lastUpdateBy)";

                        command.Parameters.AddWithValue("@customerName", name);
                        command.Parameters.AddWithValue("@addressId", Convert.ToUInt32(GetQueryResultAsString("SELECT addressId FROM address WHERE address = '" + address + "'")));
                        command.Parameters.AddWithValue("@active", 1);
                        command.Parameters.AddWithValue("@createDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@createdBy", userName);
                        command.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@lastUpdateBy", userName);

                        command.ExecuteNonQuery();
                    }
                }
            }

        }
        public void DeleteCustomer(int customerId)
        {
            using (connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM customer WHERE customerId = @customerId";

                    command.Parameters.AddWithValue("@customerId", customerId);

                    command.ExecuteNonQuery();
                }



            }
        }

        private void updateAddress(string address, string city, string postalCode, string phoneNumber, string userName)
        {
            TimeConversion timeConversion = new TimeConversion();
            using (connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE address SET address = @address, cityId = @cityId, postalCode = @postalCode, phone = @phone, lastUpdate = convert_tz(@lastupdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), lastUpdateBy = @lastUpdateBy";

                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@cityId", Convert.ToInt32(GetQueryResultAsString("SELECT cityId FROM city WHERE city = '" + city + "'")));
                    command.Parameters.AddWithValue("@postalCode", postalCode);
                    command.Parameters.AddWithValue("@phone", phoneNumber);
                    command.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@lastUpdateBy", userName);

                    command.ExecuteNonQuery();
                }
            }
        }
        private void updateCity(string city, int countryId, string userName, int cityId)
        {
            TimeConversion timeConversion = new TimeConversion();
            using (connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE city SET city = @city, countryid = @countryid, lastupdate = convert_tz(@lastupdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), lastupdateBy = @lastupdateBy WHERE cityId = @cityid";

                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@countryid", countryId);
                    command.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@lastupdateBy", userName);
                    command.Parameters.AddWithValue("@cityid", cityId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCustomer(string name, int customerId, string city, int countryId, string userName, string address, string postalCode, string phoneNumber, int cityId)
        {
            TimeConversion timeConversion = new TimeConversion();
            if (!checkIfDuplicateCityExists(city))
            {
                addCity(city, countryId, userName);
            }
            else
            {
                updateCity(city, countryId, userName, cityId);
            }
            if (!checkIfDuplicateAddressExists(address, postalCode))
            {
                addAddress(address, city, postalCode, phoneNumber, userName);
            }
            else
            {
                updateAddress(address, city, postalCode, phoneNumber, userName);
            }

            using (connection = new MySqlConnection(this.connectionDetails))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE customer SET customerName = @customerName, addressId = @addressId, active = @active, lastUpdate = convert_tz(@lastupdate, '" + timeConversion.getUserTimeZoneOffset() + "', '+00:00'), lastUpdateBy = @lastUpdateBy WHERE customerId = '" + customerId + "'";

                    command.Parameters.AddWithValue("@customerName", name);
                    command.Parameters.AddWithValue("@addressId", Convert.ToUInt32(GetQueryResultAsString("SELECT addressId FROM address WHERE address = '" + address + "'")));
                    command.Parameters.AddWithValue("@active", 1);
                    command.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@lastUpdateBy", userName);
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}
