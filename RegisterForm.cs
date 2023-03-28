using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace PBL3_1._0_
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
 
        public bool CheckAccount(string ac) // check tk mk
        { 
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string em)
        {
            /*return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");*/
            return Regex.IsMatch(em, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        }
            
            Modify modify = new Modify();   
        private void btnRes_Click(object sender, EventArgs e)
        {
                string idposition = txtPosition.Text;
                string tkres = txtTKres.Text;
                string mkres = txtMKres.Text;
                string xacnhanmk = txtMKresC.Text;
                string gmail = txtGmail.Text;

                if (!CheckAccount(tkres))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các chữ số, chữ hoa và chữ thường");
                    return;
                }

                if (!CheckAccount(mkres))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 kí tự, với các chữ số, chữ hoa và chữ thường");
                    return;
                }

                if (!CheckAccount(xacnhanmk))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu xác nhận dài 6-24 kí tự, với các chữ số, chữ hoa và chữ thường");
                    return;
                }

                if (!CheckEmail(gmail))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng");
                    return;
                }

                if (modify.TaiKhoans("Select * from ACCOUNT where Email = '" + gmail + "'").Count != 0)
                {
                    MessageBox.Show("Email này đã được đăng kí,vui lòng đăng kí Email khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (mkres != xacnhanmk)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu chính xác");
                    return;
                }

            try
            {
                string query = "INSERT INTO ACCOUNT VALUES ('" + tkres + "','" + mkres + "','" + gmail + "','"+idposition+"')";
                modify.Command(query);
                if(MessageBox.Show("Đăng kí thành công ! Bạn có muốn đăng nhập luôn không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes) {
                    Login login = new Login();
                    login.Show();
                    this.Close();

                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Tài khoản này đã được đăng kí");
            }
        }
            
    }
}

