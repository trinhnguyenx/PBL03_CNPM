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
    public partial class TTDocGia : Form
    {
        public TTDocGia()
        {
            InitializeComponent();
        }

        private void changed_gen()
        {
            if (radioButton1.Checked == true) radioButton1.Text = "Nam";
            else if (radioButton2.Checked == true) radioButton2.Text = "Nữ";
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();
            changed_gen();
            var l = db.docgias.Select(p => new {p.madocgia, p.hoten, p.ngaysinh, p.gioitinh, p.diachi, p.sdt });
            dgv_TTdocgia.DataSource = l;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();
            docgia d = new docgia();
            d.madocgia = txt_madocgia.Text;
            d.hoten = txt_Hotendocgia.Text;
            d.ngaysinh = dateTimePicker1.Value;
            d.gioitinh = radioButton1.Checked;
            d.diachi = txt_diachi.Text;
            d.sdt = txt_sdt.Text;
            db.docgias.InsertOnSubmit(d); //Add
            db.SubmitChanges();
            var l = db.docgias.Select(p => new { p.madocgia, p.hoten, p.ngaysinh, p.gioitinh, p.diachi, p.sdt });
            dgv_TTdocgia.DataSource = l;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dgv_TTdocgia.SelectedRows.Count > 0)
            {
                QLNSDataContext db = new QLNSDataContext();
                foreach (DataGridViewRow i in dgv_TTdocgia.SelectedRows) /*Xoa chon nhieu cai nen dung i trong vong lap foreach
                                                                             Sua thi ko chon dc nhieu cai nen ko can dung i*/
                {
                    string Madocgia = i.Cells[0].Value.ToString();
                    var l = db.docgias.Where(p => p.madocgia == Madocgia).FirstOrDefault();
                    db.docgias.DeleteOnSubmit(l); //Delete
                    db.SubmitChanges();
                    dgv_TTdocgia.DataSource = db.docgias.ToList();
                }
            }

           
        }
        private void dgv_TTdocgia_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_TTdocgia.CurrentRow.Index;
            txt_madocgia.Text = dgv_TTdocgia.Rows[i].Cells[0].Value.ToString();
           // txt_madocgia.ReadOnly = true;
            txt_Hotendocgia.Text = dgv_TTdocgia.Rows[i].Cells[1].Value.ToString();
            dateTimePicker1.Text = dgv_TTdocgia.Rows[i].Cells[2].Value.ToString();
            radioButton1.Text = dgv_TTdocgia.Rows[i].Cells[3].Value.ToString();
            txt_diachi.Text = dgv_TTdocgia.Rows[i].Cells[4].Value.ToString();
            txt_sdt.Text = dgv_TTdocgia.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_TTdocgia.SelectedRows.Count == 1)
            {
                QLNSDataContext db = new QLNSDataContext();              
                string Madocgia = dgv_TTdocgia.SelectedRows[0].Cells[0].Value.ToString();
                docgia d = db.docgias.FirstOrDefault(p=>p.madocgia == Madocgia);
                d.madocgia = txt_madocgia.Text;
                d.hoten = txt_Hotendocgia.Text;
                d.ngaysinh = dateTimePicker1.Value;
                d.gioitinh = radioButton1.Checked;
                d.diachi = txt_diachi.Text;
                d.sdt = txt_sdt.Text;
                db.SubmitChanges();
                dgv_TTdocgia.DataSource = db.docgias.ToList();
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_madocgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Hotendocgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*LUU Y: Doi cho radio button thanh combobox
                 Double Click vo header van chua dc
                 Edit van chua xong
                 */

    }
}
