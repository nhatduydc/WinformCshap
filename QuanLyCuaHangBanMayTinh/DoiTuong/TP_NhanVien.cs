using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanMayTinh.DoiTuong
{
    class TP_NhanVien
    {
        KetNoiSQL.NhanVien nhanvien = new KetNoiSQL.NhanVien();
        FormGiaoDien.Form_NhanVien frm_nhanvien;
        FormGiaoDien.Form_HoaDon frm_hoadon;

        public TP_NhanVien(FormGiaoDien.Form_HoaDon hd)
        {
            frm_hoadon = hd;
        }

        public TP_NhanVien(FormGiaoDien.Form_NhanVien nv)
        {
            frm_nhanvien = nv;
        }

        public void luunv()
        {
            int ketqua = nhanvien.themNV
                (
                    frm_nhanvien.txt_manv.Text, 
                    frm_nhanvien.txt_tennv.Text, 
                    frm_nhanvien.dt_ngaysinh.Value, 
                    frm_nhanvien.cb_gioitinh.Text, 
                    frm_nhanvien.txt_diachi.Text, 
                    frm_nhanvien.txt_sdt.Text
                );
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else if (ketqua == 0)
                MessageBox.Show("Thêm thất bai");
        }

        public void suanv()
        {
            int ketqua = nhanvien.suaNV
                (
                    frm_nhanvien.txt_manv.Text, 
                    frm_nhanvien.txt_tennv.Text, 
                    frm_nhanvien.dt_ngaysinh.Value, 
                    frm_nhanvien.cb_gioitinh.Text, 
                    frm_nhanvien.txt_diachi.Text, 
                    frm_nhanvien.txt_sdt.Text
                );
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
        }

        public void xoanv()
        {
            int ketqua = nhanvien.xoaNV(frm_nhanvien.txt_manv.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
        }

        public void loadnv()
        {
            frm_nhanvien.dtv_nhanvien.DataSource = nhanvien.loadNhanVien();
        }

        public void LayDSNV()
        {
            frm_hoadon.cb_manv.DataSource = nhanvien.loadNhanVien();
            frm_hoadon.cb_manv.DisplayMember = "MANV";
            frm_hoadon.cb_manv.ValueMember = "MANV";
        }
    }
}
