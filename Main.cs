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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }      

        private void Form2_Load(object sender, EventArgs e)
        {
            //sạiaisjaisjaisji
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Login login = new Login();
                
                login.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TTDocGia form = new TTDocGia();
            form.Name = "Quan Li Thong Tin Ban Doc";
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TTSach form = new TTSach();
            form.Name = "Quan Li Thong Tin Sach";
            form.Show();
            this.Hide();
        }
    }
}
