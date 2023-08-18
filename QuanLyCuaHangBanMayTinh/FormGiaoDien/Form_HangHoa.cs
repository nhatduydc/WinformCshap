using QuanLyCuaHangBanMayTinh.KetNoiSQL;
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
    public partial class Form_HangHoa : Form
    {
        DataTable tbhh;
        LopDungChung lopchung = new LopDungChung();
        DoiTuong.TP_HangHoa tphh;
        DoiTuong.TP_NhaCungCap tpncc;
        public Form_HangHoa()
        {
            InitializeComponent();
            tpncc = new DoiTuong.TP_NhaCungCap(this);
            tphh = new DoiTuong.TP_HangHoa(this);
        }

        private void Form_HangHoa_Load(object sender, EventArgs e)
        {
            tphh.loadhh();
            tpncc.LayDSNCC();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tphh.themhh();
            tphh.loadhh();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                tphh.suahh();
                tphh.loadhh();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                tphh.xoahh();
                tphh.loadhh();
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if ((txt_mahang.Text == "") && (txt_tenhang.Text == "") && (cb_ncc.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String sql = "SELECT * from HANGHOA WHERE 1=1";
            if (txt_mahang.Text != "")
                sql += " AND MAHH LIKE N'%" + txt_mahang.Text + "%'";
            if (txt_tenhang.Text != "")
                sql += " AND TENHANG LIKE N'%" + txt_tenhang.Text + "%'";
            if (cb_ncc.Text != "")
                sql += " AND MANCC LIKE N'%" + cb_ncc.SelectedValue + "%'";
            tbhh = lopchung.LoadDuLieu(sql);
            if (tbhh.Rows.Count == 0)
                MessageBox.Show("Không có hàng hóa thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tbhh.Rows.Count + "  hàng hóa thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_hanghoa.DataSource = tbhh;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            tphh.loadhh();
        }

        private void dtv_hanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahang.Text = dtv_hanghoa.CurrentRow.Cells["MAHH"].Value.ToString();
            cb_ncc.SelectedValue = dtv_hanghoa.CurrentRow.Cells["MANCC"].Value.ToString();
            txt_tenhang.Text = dtv_hanghoa.CurrentRow.Cells["TENHANG"].Value.ToString();
            txt_soluong.Text = dtv_hanghoa.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txt_dongianhap.Text = dtv_hanghoa.CurrentRow.Cells["DONGIANHAP"].Value.ToString();
            txt_dongiaban.Text = dtv_hanghoa.CurrentRow.Cells["DONGIABAN"].Value.ToString();
        }
    }
}
