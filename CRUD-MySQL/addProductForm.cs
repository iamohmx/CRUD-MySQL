using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRUD_MySQL
{
    public partial class addProductForm : Form
    {
        private const string connectionString = "server=localhost;user=root;database=vb_data;port=3306;password=";
        public addProductForm()
        {
            InitializeComponent();
            categoriesList_SelectedIndexChanged();
        }


        private void categoriesList_SelectedIndexChanged()
        {
            categoriesList.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT cat_id, cat_name FROM categories";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string catId = reader["cat_id"].ToString();
                            string catName = reader["cat_name"].ToString();
                            categoriesList.Items.Add(new Category { Id = catId, Name = catName });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public class Category
        {
            public string Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Id} - {Name}";
            }
        }
        private void saveProduct_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (categoriesList.Text != "" && proName.Text != "" && proPrice.Text != "" && proStocks.Text != "")
                    {
                        string sql = "INSERT INTO products (cat_id, pro_name, pro_price, pro_stocks) VALUES (@cat_id, @pro_name, @pro_price, @pro_stocks)";
                        MySqlCommand command = new MySqlCommand(sql, connection);

                        // Get the selected item from ComboBox
                        Category selectedCategory = (Category)categoriesList.SelectedItem;

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@cat_id", selectedCategory.Id);
                        command.Parameters.AddWithValue("@pro_name", proName.Text);
                        command.Parameters.AddWithValue("@pro_price", proPrice.Text);
                        command.Parameters.AddWithValue("@pro_stocks", proStocks.Text);

                        // Execute the command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all fields!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
