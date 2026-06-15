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
    public partial class frm_view_list_sv : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_view_list_sv()
        {
            InitializeComponent();
            this.Load += frm_view_list_sv_Load;

        }

        private void frm_view_list_sv_Load(object sender, EventArgs e)
        {
            try
            {
                var dsToanBoSinhVien = db.tbl_sinhviens
                                         .Select(x => new {
                                             Mã_SV = x.MaSV,
                                             Họ_Tên = x.HoTen,
                                             Ngày_Sinh = x.NgaySinh,
                                             Giới_Tính = x.GioiTinh,
                                             Mã_Lớp = x.MaLop 
                                         }).ToList();

                dgvDssv.DataSource = dsToanBoSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
