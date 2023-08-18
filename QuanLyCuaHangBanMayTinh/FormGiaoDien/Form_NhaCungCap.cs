using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanMayTinh.FormGiaoDien
{
    public partial class Form_NhaCungCap : Form
    {
        DoiTuong.TP_NhaCungCap tpncc;
        public Form_NhaCungCap()
        {
            InitializeComponent();
            tpncc = new DoiTuong.TP_NhaCungCap(this);
        }

        private void Form_NhaCungCap_Load(object sender, EventArgs e)
        {
            tpncc.Loadncc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tpncc.Themncc();
            tpncc.Loadncc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                tpncc.Xoancc();
                tpncc.Loadncc();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                tpncc.Suancc();
                tpncc.Loadncc();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtv_nhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = dtv_nhacungcap.CurrentRow.Cells["MANCC"].Value.ToString();
            txt_tenncc.Text = dtv_nhacungcap.CurrentRow.Cells["TENNCC"].Value.ToString();
        }
    }
}
