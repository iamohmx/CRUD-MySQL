using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace CRUD_MySQL
{
    public class Connection
    {
        MySqlConnection conn = null;
        
        private string connStr = "server=127.0.0.1;uid=root;pwd=;database=vb_data";
        public bool Open() 
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public void closeConnection()
        {
            conn.Open();
            conn.Close();
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void addUser(string username, string password, string firstName, string lastName, string email, string tel)
        {
            try
            {
                
                string sql = @"INSERT INTO users (username, password, firstName, lastName, email, tel)  VALUES (@username, @password, @firstName, @lastName, @email, @tel);";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@tel", tel);
                command.ExecuteNonQuery();

                Console.WriteLine("Added Successfully!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
