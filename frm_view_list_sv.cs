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
            //Load dữ liệu sinh viên vào DataGridView
            var query = from sv in db.tbl_sinhviens
                        join lop in db.tbl_lophocs on sv.MaLop equals lop.MaLop
                        select new
                        {
                            sv.MaSV,
                            sv.HoTen,
                            sv.NgaySinh,
                            sv.GioiTinh,
                            sv.MaLop
                        };
            dgvDssv.DataSource = query.ToList();    
        }

        private void dgvDssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
