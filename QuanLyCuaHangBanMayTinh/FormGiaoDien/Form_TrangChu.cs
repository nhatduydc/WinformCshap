using QuanLyCuaHangBanMayTinh;
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
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NhanVien nv = new Form_NhanVien();
            nv.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_KhachHang kh = new Form_KhachHang();
            kh.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HangHoa hh = new Form_HangHoa();
            hh.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NhaCungCap ncc = new Form_NhaCungCap();
            ncc.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ThongKe tk = new Form_ThongKe();
            tk.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HoaDon hd = new Form_HoaDon();
            hd.Show();
        }

        private void toolStripButton_nhanvien_Click(object sender, EventArgs e)
        {
            Form_NhanVien nv = new Form_NhanVien();
            nv.Show();
        }

        private void toolStripButton_khachhang_Click(object sender, EventArgs e)
        {
            Form_KhachHang kh = new Form_KhachHang();
            kh.Show();
        }

        private void toolStripButton_hanghoa_Click(object sender, EventArgs e)
        {
            Form_HangHoa hh = new Form_HangHoa();
            hh.Show();
        }

        private void toolStripButton_nhacungcap_Click(object sender, EventArgs e)
        {
            Form_NhaCungCap ncc = new Form_NhaCungCap();
            ncc.Show();
        }

        private void toolStripButton_hoadon_Click(object sender, EventArgs e)
        {
            Form_HoaDon hd = new Form_HoaDon();
            hd.Show();
        }

        private void toolStripButton_thongke_Click(object sender, EventArgs e)
        {
            Form_ThongKe hd = new Form_ThongKe();
            hd.Show();
        }
    }
}
