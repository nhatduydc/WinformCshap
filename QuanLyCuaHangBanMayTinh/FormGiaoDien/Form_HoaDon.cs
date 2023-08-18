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
using System.Data.SqlClient;

namespace QuanLyCuaHangBanMayTinh.FormGiaoDien
{
    public partial class Form_HoaDon : Form
    {
        LopDungChung lopchung = new LopDungChung();
        DataTable dthd;
        SqlConnection con;
        SqlCommand comm;

        DoiTuong.TP_KhachHang tpkh;
        DoiTuong.TP_NhanVien tpnv;
        DoiTuong.TP_HangHoa tphh;
        DoiTuong.TP_HoaDon tphd;
        public Form_HoaDon()
        {
            InitializeComponent();
            tpkh = new DoiTuong.TP_KhachHang(this);
            tpnv = new DoiTuong.TP_NhanVien(this);
            tphh = new DoiTuong.TP_HangHoa(this);
            tphd = new DoiTuong.TP_HoaDon(this);
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            tpkh.LayDSNCC();
            tpnv.LayDSNV();
            tphh.LayDSHH();
            tphd.loadhd();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tphd.themhd();
            tphd.loadhd();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                tphd.xoahd();
                tphd.loadhd();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            tphd.suahd();
            tphd.loadhd();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hienthihd_Click(object sender, EventArgs e)
        {
            tphd.loadhd();
        }

        private void cb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from NHANVIEN where MANV = '" + cb_manv.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tennv.Text = reader.GetString(1).ToString();
            }
        }

        private void cb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from KHACHHANG where MAKH = '" + cb_makh.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenkh.Text = reader.GetString(1).ToString();
                txt_diachi.Text = reader.GetString(4).ToString();
                txt_dienthoai.Text = reader.GetString(5).ToString();
            }
        }

        private void cb_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from HANGHOA where MAHH = '" + cb_mahang.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenhang.Text = reader.GetString(2).ToString();
                txt_dongia.Text = reader.GetInt32(5).ToString();
            }
        }

        private void btn_timkiemnv_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_manv.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOADON WHERE 1=1";

            if (cb_manv.Text != "")
                sql += " AND MANV LIKE N'%" + cb_manv.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " nhân viên thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_hd.DataSource = dthd;
        }

        private void btn_timkiemkh_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_makh.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOADON WHERE 1=1";

            if (cb_makh.Text != "")
                sql += " AND MAKH LIKE N'%" + cb_makh.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " khách thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_hd.DataSource = dthd;
        }

        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            int sc = dtv_hd.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dtv_hd.Rows[i].Cells["THANHTIEN"].Value.ToString());
            txt_tongtien.Text = thanhtien.ToString();
        }

        private void dtv_hd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = dtv_hd.CurrentRow.Cells["MAHD"].Value.ToString();
            cb_manv.Text = dtv_hd.CurrentRow.Cells["MANV"].Value.ToString();
            dt_ngayban.Value = Convert.ToDateTime(dtv_hd.CurrentRow.Cells["NGAYBAN"].Value);
            cb_makh.Text = dtv_hd.CurrentRow.Cells["MAKH"].Value.ToString();
            cb_mahang.Text = dtv_hd.CurrentRow.Cells["MAHH"].Value.ToString();
            txt_soluong.Text = dtv_hd.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txt_dongia.Text = dtv_hd.CurrentRow.Cells["DONGIA"].Value.ToString();
            txt_thanhtien.Text = dtv_hd.CurrentRow.Cells["THANHTIEN"].Value.ToString();
        }
    }
}
