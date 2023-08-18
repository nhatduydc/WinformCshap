using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanMayTinh.DoiTuong
{
    class TP_HangHoa
    {
        KetNoiSQL.HangHoa hanghoa = new KetNoiSQL.HangHoa();
        FormGiaoDien.Form_HangHoa frm_hh;
        FormGiaoDien.Form_HoaDon frm_hoadon;
        FormGiaoDien.Form_NhaCungCap frm_ncc;

        public TP_HangHoa(FormGiaoDien.Form_HangHoa hh)
        {
            frm_hh = hh;
        }

        public TP_HangHoa(FormGiaoDien.Form_HoaDon hd)
        {
            frm_hoadon = hd;
        }

        public TP_HangHoa(FormGiaoDien.Form_NhaCungCap ncc)
        {
            frm_ncc = ncc;
        }

        public void themhh()
        {
            int ketqua = hanghoa.Themhang
                (
                    frm_hh.txt_mahang.Text, 
                    frm_hh.cb_ncc.SelectedValue.ToString(), 
                    frm_hh.txt_tenhang.Text, 
                    frm_hh.txt_soluong.Text, 
                    frm_hh.txt_dongianhap.Text, 
                    frm_hh.txt_dongiaban.Text
                );
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
        }

        public void suahh()
        {
            int ketqua = hanghoa.Suahang
                (
                    frm_hh.txt_mahang.Text, 
                    frm_hh.cb_ncc.SelectedValue.ToString(), 
                    frm_hh.txt_tenhang.Text, 
                    frm_hh.txt_soluong.Text, 
                    frm_hh.txt_dongianhap.Text, 
                    frm_hh.txt_dongiaban.Text
                );
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
        }

        public void xoahh()
        {
            int ketqua = hanghoa.Xoahang(frm_hh.txt_mahang.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
        }

        public void loadhh()
        {
            frm_hh.dtv_hanghoa.DataSource = hanghoa.Loadhh();
        }

        public void LayDSHH()
        {
            frm_hoadon.cb_mahang.DataSource = hanghoa.Loadhh();
            frm_hoadon.cb_mahang.DisplayMember = "MAHH";
            frm_hoadon.cb_mahang.ValueMember = "MAHH";
        }

    }
}
