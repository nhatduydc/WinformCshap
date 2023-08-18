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
    public partial class Form_NhanVien : Form
    {
        DoiTuong.TP_NhanVien tpnv;
        LopDungChung lopchung = new LopDungChung();
        public Form_NhanVien()
        {
            InitializeComponent();
            tpnv = new DoiTuong.TP_NhanVien(this);
            tpnv.loadnv();
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            tpnv.loadnv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tpnv.luunv();
            tpnv.loadnv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                tpnv.xoanv();
                tpnv.loadnv();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                tpnv.suanv();
                tpnv.loadnv();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if ((txt_tennv.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập tên nhân viên cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "SELECT * from NHANVIEN WHERE 1=1";
            if (txt_tennv.Text != "")
                sql += " AND TENNV LIKE N'%" + txt_tennv.Text + "%'";
            DataTable dt = lopchung.LoadDuLieu(sql);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có tên nhân viên cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dt.Rows.Count + " nhân viên thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_nhanvien.DataSource = dt;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            tpnv.loadnv();
        }

        private void dtv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = dtv_nhanvien.CurrentRow.Cells["MANV"].Value.ToString();
            txt_tennv.Text = dtv_nhanvien.CurrentRow.Cells["TENNV"].Value.ToString();
            cb_gioitinh.Text = dtv_nhanvien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            dt_ngaysinh.Value = Convert.ToDateTime(dtv_nhanvien.CurrentRow.Cells["NGAYSINH"].Value);
            txt_diachi.Text = dtv_nhanvien.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_sdt.Text = dtv_nhanvien.CurrentRow.Cells["SDT"].Value.ToString();
        }
    }
}
