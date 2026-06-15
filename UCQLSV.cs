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
        DataClasses1DataContext db = new DataClasses1DataContext();

        int pageSize = 2; 
        int currentPage = 1; 
        int totalPages = 0; 
        int totalRecords = 0; 
        string currentSearchKeyword = ""; 

        public UCQLSV()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow row = dgv_DSSV.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }

                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();

                if (row.Cells["MaLop"].Value != null)
                {
                    string maLopDuocChon = row.Cells["MaLop"].Value.ToString().Trim();
                    cboLop.SelectedValue = maLopDuocChon;
                }
            }
        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string maSV = txtMaSV.Text.Trim();
                var checkSV = db.tbl_sinhviens.FirstOrDefault(x => x.MaSV == maSV);

                if (checkSV != null)
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại! Vui lòng nhập mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tbl_sinhvien sv = new tbl_sinhvien();
                sv.MaSV = maSV;
                sv.HoTen = txtHoTen.Text.Trim();
                sv.NgaySinh = dtpNgaySinh.Value; 
                sv.GioiTinh = cboGioiTinh.Text;
                sv.MaLop = cboLop.SelectedValue?.ToString();

                db.tbl_sinhviens.InsertOnSubmit(sv);
                db.SubmitChanges();

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            try
            {
                var query = db.tbl_sinhviens.AsQueryable();

                if (!string.IsNullOrEmpty(currentSearchKeyword))
                {
                    query = query.Where(x => x.MaSV.Contains(currentSearchKeyword) ||
                                             x.HoTen.Contains(currentSearchKeyword));
                }

                totalRecords = query.Count();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                if (totalPages == 0) totalPages = 1;

                if (currentPage > totalPages) currentPage = totalPages;
                if (currentPage < 1) currentPage = 1;

                var pagedData = query.OrderBy(x => x.MaSV) 
                                     .Skip((currentPage - 1) * pageSize) 
                                     .Take(pageSize) 
                                     .ToList();

                dgv_DSSV.DataSource = pagedData;
                lblSoTrang.Text = $"Trang {currentPage} / {totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        public void LoadComboBoxLop()
        {
            List<tbl_lophoc> dsLop = db.tbl_lophocs.ToList();
            cboLop.DataSource = dsLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        //Bấm vào đổ dl ra ô
        //sửa
        //Xóa
        //Phân trang, search p
        //Load dữ liệu lên combobox lớp
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn sinh viên chưa
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng click chọn sinh viên cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tìm sinh viên trong CSDL dựa vào MaSV đang hiển thị trên txtMaSV
                string maSV = txtMaSV.Text.Trim();
                tbl_sinhvien sv = db.tbl_sinhviens.FirstOrDefault(x => x.MaSV == maSV);

                if (sv != null) // Nếu tìm thấy
                {
                    sv.HoTen = txtHoTen.Text;
                    sv.NgaySinh = dtpNgaySinh.Value;
                    sv.GioiTinh = cboGioiTinh.Text;
                    sv.MaLop = cboLop.SelectedValue.ToString();

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên này trong CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn sinh viên chưa
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng click chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại hỏi đáp trước khi xóa
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    // 1. Tìm sinh viên cần xóa
                    string maSV = txtMaSV.Text.Trim();
                    tbl_sinhvien sv = db.tbl_sinhviens.FirstOrDefault(x => x.MaSV == maSV);

                    if (sv != null)
                    {
                        db.tbl_sinhviens.DeleteOnSubmit(sv);
                        db.SubmitChanges();

                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                        txtMaSV.Clear();
                        txtHoTen.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage = 1;
                LoadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            currentSearchKeyword = txtTimKiem.Text.Trim();

            currentPage = 1;

            LoadData();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage = totalPages;
                LoadData();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }
    }

}
