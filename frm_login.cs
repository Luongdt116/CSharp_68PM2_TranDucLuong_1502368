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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "1502368@st.huce.edu.vn" && password == "1502368")
            {
                MessageBox.Show("Đăng nhập thành công.");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.");
            }
        }
    }
}
