using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_1._0_
{
    internal class TaiKhoan
    {
        private string tentaikhoan;
        private string matkhau;

        public TaiKhoan()
        {

        }
        public TaiKhoan(string tentaikhoan, string matkhau)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
        }

        public string TenTaiKhoan
        {
            get => tentaikhoan;
            set => tentaikhoan = value;
        }

        public string MatKhau
        {
            get => matkhau; 
            set => matkhau = value;
        }
    }
}
