using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class UCQLSV : UserControl
    {
        dbQLSV db = new dbQLSV();
        public UCQLSV()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_sinhvien sv = new tbl_sinhvien();
            sv.MaSV = txtMaSV.Text;
            sv.HoTen = txtHoTen.Text;
            sv.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            sv.GioiTinh = cboGioiTinh.Text;
            db.tbl_sinhviens.InsertOnSubmit(sv);
            db.SubmitChanges();
            LoadData();
        }
        public void LoadData()
        {
            List<tbl_sinhvien> dsSV = db.tbl_sinhviens.ToList();
            dgv_DSSV.DataSource = dsSV;
        }
        
        //Load dữ liệu lên combobox lớp
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<tbl_lophoc> dsLop = db.tbl_lophocs.ToList();
            cboLop.DataSource = dsLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

    }

}
