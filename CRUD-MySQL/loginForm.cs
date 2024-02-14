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
    public partial class loginForm : Form
    {
        Connection cnnDB = new Connection();
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                
                    cnnDB.Open();
                    string loginQuery = @"SELECT username, password FROM users WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' LIMIT 1;";
                    MySqlDataReader row;
                    row = cnnDB.ExecuteReader(loginQuery);

                    if (row.HasRows)
                    {
                        MessageBox.Show("เข้าสู่ระบบสำเร็จ");

                        dashboard dbd = new dashboard();
                        dbd.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ขื้อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง!!", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
                else
                {
                    MessageBox.Show("ขื้อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง!!", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            /*cnnDB.closeConnection();*/
            } catch (Exception ex)
            {
                MessageBox.Show(ex + " Error");
            }
            



            /*if(username.Text == "admin" && password.Text == "123")
            {
                dashboard dbd = new dashboard();
    dbd.Show();
                this.Hide();
    } 
            else
            {
                MessageBox.Show( "ขื้อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง!!","เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            /*System.Diagnostics.Process.GetCurrentProcess().Kill();*/
            Application.Exit();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            registerForm regFrm = new registerForm();
            regFrm.Show();
            this.Hide();
        }

        
    }
}
