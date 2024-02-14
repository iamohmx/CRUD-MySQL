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

namespace CRUD_MySQL
{
    public partial class showProductForm : Form
    {
        private const string connectionString = "server=localhost;user=root;database=vb_data;port=3306;password=";
        public showProductForm()
        {
            InitializeComponent();
            showProductViews_CellContentClick_1();
            categoriesList_SelectedIndexChanged();
        }

 

        private void showProductViews_CellContentClick_1()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    string sql = @"SELECT p.pro_id ID, p.pro_name P_Name, p.pro_price Price , p.pro_stocks Stock, c.cat_name Category FROM `products` `p` INNER JOIN `categories` `c` ON c.cat_id = p.cat_id ORDER BY `p`.`pro_id`;";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.SelectCommand = command;
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    showProductViews.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchKeyword = searchTextBox.Text.Trim();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT pro_id ID, pro_name P_Name, pro_price Price ,pro_stocks Stock, c.cat_name Category FROM `products` `p` INNER JOIN `categories` `c` ON c.cat_id = p.cat_id WHERE pro_name LIKE @SearchKeyword";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SearchKeyword", $"%{searchKeyword}%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    showProductViews.DataSource = dataTable.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        

        private void showProductViews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoriesList_SelectedIndexChanged()
        {
            categoriesList.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT cat_id, cat_name FROM categories";
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

        private void showProductViews_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // ตรวจสอบว่าการคลิกเป็นแถวข้อมูล (ไม่ใช่หัวตาราง)
            {
                DataGridViewRow selectedRow = showProductViews.Rows[e.RowIndex];
                Id.Text = selectedRow.Cells["ID"].Value.ToString();
                proName.Text = selectedRow.Cells["P_Name"].Value.ToString();
                categoriesList.Text = selectedRow.Cells["Category"].Value.ToString();
                proPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                proStocks.Text = selectedRow.Cells["Stock"].Value.ToString();

                // เซ็ตค่าของ ComboBox categoriesList
                string categoryName = selectedRow.Cells["Category"].Value.ToString();
                if (categoriesList.Items.Contains(categoryName))
                {
                    categoriesList.SelectedItem = categoryName;
                }
            }
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            // ตรวจสอบที่ตรงกับการเลือกแถวใน DataGridView ก่อนที่จะทำงานเพิ่มเติม
            if (showProductViews.SelectedRows.Count != 0)
            {
                // ดึง ID ของสินค้าที่เลือก
                string productId = showProductViews.SelectedRows[0].Cells["ID"].Value.ToString();

                // ตรวจสอบว่ามีการเลือกหมวดหมู่ใน ComboBox
                if (categoriesList.SelectedItem != null)
                {
                    Category selectedCategory = (Category)categoriesList.SelectedItem;
                    string catId = selectedCategory.Id;

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string sql = @"UPDATE products SET cat_id = @cat_id, pro_name = @pro_name, pro_price = @pro_price, pro_stocks = @pro_stocks WHERE pro_id = @id";
                            MySqlCommand command = new MySqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@cat_id", catId);
                            command.Parameters.AddWithValue("@pro_name", proName.Text);
                            command.Parameters.AddWithValue("@pro_price", proPrice.Text);
                            command.Parameters.AddWithValue("@pro_stocks", proStocks.Text);
                            command.Parameters.AddWithValue("@id", productId);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Product updated successfully!");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
            showProductViews_CellContentClick_1();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string productId = showProductViews.SelectedRows[0].Cells["ID"].Value.ToString();
                DialogResult result = MessageBox.Show("ต้องการลบข้อมูลหรือไม่", "ลบข้อมูลสินค้า", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        string sql = "DELETE FROM products WHERE pro_id = @id";
                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@id", productId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product deleted successfully!");
                        showProductViews_CellContentClick_1();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void addDataBtn_Click(object sender, EventArgs e)
        {
            addProductForm addNewData = new addProductForm();
            addNewData.ShowDialog();
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            showProductViews_CellContentClick_1();
        }









        /*private void showProductViews_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id.Text = showProductViews.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            proName.Text = showProductViews.Rows[e.RowIndex].Cells["P_Name"].Value.ToString();
            categoriesList.Text = showProductViews.Rows[e.RowIndex].Cells["Category"].Value.ToString();
            proPrice.Text = showProductViews.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            proStocks.Text = showProductViews.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
        }*/
    }
}
