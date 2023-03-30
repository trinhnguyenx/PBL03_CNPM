using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PBL3_1._0_
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();
        private void btnresetMK_Click(object sender, EventArgs e)
        {
            string email = txtEmailForget.Text;
            if(email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí");
            }
            else
            {
                string query = " Select * from ACCOUNTT where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count !=0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật Khẩu:" + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng kí";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn quay trở lại trang đăng nhập không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
