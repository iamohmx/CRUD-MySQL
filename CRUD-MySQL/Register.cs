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
    public partial class registerForm : Form
    {
        Connection cnnDB = new Connection();
        public registerForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginForm loginFrm = new loginForm();
            loginFrm.Show();
            this.Close();
        }

        private void regSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (regUsername.Text != "" && regPassword.Text != "" && regFirstName.Text != "" && regLastName.Text != "" && regEmail.Text != "" && regTel.Text != "" && regPassword.Text != "" && regConfirmPassword.Text != "")
                {
                    try
                    {
                        cnnDB.Open();
                        if (regPassword.Text == regConfirmPassword.Text)
                        {
                            cnnDB.addUser(regUsername.Text, regPassword.Text, regFirstName.Text, regLastName.Text, regEmail.Text, regTel.Text);
                            MessageBox.Show("สมัครสมาชิกเรียบร้อยแล้วครับ");
                            loginForm loginFrm = new loginForm();
                            loginFrm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("กรุณากรอกรหัสผ่านให้ตรงกัน");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex );
                    }

                   
                    
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน!!", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Error");
            }
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
