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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void grb1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLSV uCQLSV = new UCQLSV();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(uCQLSV);
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            UCQLSV uCQLSV = new UCQLSV();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(uCQLSV);
        }

        private void pn_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLLH uCQLLH = new UCQLLH();
            pn_main.Controls.Clear();
            pn_main.Controls.Add(uCQLLH);
        }
    }
}
