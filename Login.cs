using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// DESKTOP-55IHQEI\SQLEXPRESS
namespace PBL3_1._0_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();   
        private void btnLogin_Click(object sender, EventArgs e)
        {    
                string tentaikhoan = txtTK.Text;
                string matkhau = txtMK.Text;

            if (tentaikhoan == "Admin" && matkhau == "123")
            {
                Main form = new Main(); //form Admin
                form.Show();
                this.Hide();
                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tentaikhoan.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else
            {
                string query = "Select * from ACCOUNTT where TaiKhoan = '" + tentaikhoan + "' and MatKhau ='" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DocGia form = new DocGia();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm form = new RegisterForm();
            form.Show();
            
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetpassword = new ForgetPassword();
            forgetpassword.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
