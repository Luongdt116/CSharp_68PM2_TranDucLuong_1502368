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
    public partial class UCQLLH : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();


        // Các biến dùng cho phân trang
        int pageSize = 2;
        int currentPage = 1;
        int totalPages = 0;
        int totalRecords = 0;
        string currentSearchKeyword = "";

        public UCQLLH()
        {
            InitializeComponent();
        }

        private void UCQLLH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                var query = db.tbl_lophocs.AsQueryable();

                // Tìm kiếm theo Mã Lớp hoặc Tên Lớp
                if (!string.IsNullOrEmpty(currentSearchKeyword))
                {
                    query = query.Where(x => x.MaLop.Contains(currentSearchKeyword) ||
                                             x.TenLop.Contains(currentSearchKeyword));
                }

                totalRecords = query.Count();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                if (totalPages == 0) totalPages = 1;
                if (currentPage > totalPages) currentPage = totalPages;
                if (currentPage < 1) currentPage = 1;

                var pagedData = query.OrderByDescending(x => x.ID)
                     .Skip((currentPage - 1) * pageSize)
                     .Take(pageSize)
                     .ToList();

                dgvQLLH.DataSource = null;
                dgvQLLH.DataSource = pagedData;

                lblTrang.Text = $"Trang {currentPage} / {totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu: " + ex.Message);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnSuasv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng click chọn lớp học cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = txtID.Text.Trim();
                tbl_lophoc lh = db.tbl_lophocs.FirstOrDefault(x => x.ID == id);

                if (lh != null)
                {
                    lh.TenLop = txtTenLop.Text.Trim();
                    lh.GhiChu = txtGhiChu.Text.Trim();


                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvQLLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQLLH.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value?.ToString();
                txtMaLop.Text = row.Cells["MaLop"].Value?.ToString();
                txtTenLop.Text = row.Cells["TenLop"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();

                txtID.ReadOnly = true;
                txtMaLop.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()) || string.IsNullOrEmpty(txtMaLop.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đủ ID và Mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = txtID.Text.Trim();
                string maLop = txtMaLop.Text.Trim();

                // Kiểm tra trùng ID hoặc trùng Mã Lớp
                var checkTonTai = db.tbl_lophocs.FirstOrDefault(x => x.ID == id || x.MaLop == maLop);
                if (checkTonTai != null)
                {
                    MessageBox.Show("ID hoặc Mã lớp này đã tồn tại! Vui lòng nhập thông tin khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tbl_lophoc lh = new tbl_lophoc();
                lh.ID = id;
                lh.MaLop = maLop;
                lh.TenLop = txtTenLop.Text.Trim();
                lh.GhiChu = txtGhiChu.Text.Trim();

                db.tbl_lophocs.InsertOnSubmit(lh);
                db.SubmitChanges();

                MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi_Click(sender, e); // Xóa trắng form sau khi thêm
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng click chọn lớp học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    string id = txtID.Text.Trim();
                    tbl_lophoc lh = db.tbl_lophocs.FirstOrDefault(x => x.ID == id);

                    if (lh != null)
                    {
                        db.tbl_lophocs.DeleteOnSubmit(lh);
                        db.SubmitChanges();

                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLamMoi_Click(sender, e);
                        LoadData();
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    // Lỗi này xảy ra khi Lớp đang có Sinh viên học, khóa ngoại từ bảng sinh viên sẽ chặn không cho xóa
                    MessageBox.Show("Không thể xóa lớp học này vì đang có sinh viên tham chiếu đến!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();

            txtID.ReadOnly = false;
            txtMaLop.ReadOnly = false;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            currentSearchKeyword = txtTimKiem.Text.Trim();
            currentPage = 1;
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentPage > 1) { currentPage = 1; LoadData(); }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (currentPage > 1) { currentPage--; LoadData(); }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages) { currentPage++; LoadData(); }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages) { currentPage = totalPages; LoadData(); }
        }

        private void btnXemdssv_Click(object sender, EventArgs e)
        {
            frm_view_list_sv frmPopup = new frm_view_list_sv();
            frmPopup.ShowDialog();
        }

        private void dgvQLLH_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pm_qllh_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
