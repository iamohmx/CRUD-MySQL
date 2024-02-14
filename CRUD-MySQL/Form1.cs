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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }


        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ต้องการออกจากระบบหรือไม่", "ออกจากระบบ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
                loginForm login = new loginForm();
                login.Show();
            }
        }
        private void showProducts_Click(object sender, EventArgs e)
        {
            showProductForm showProductForm = new showProductForm();
            showProductForm.Show();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
