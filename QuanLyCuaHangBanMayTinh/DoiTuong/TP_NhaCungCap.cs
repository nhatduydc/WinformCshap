using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanMayTinh.DoiTuong
{
    class TP_NhaCungCap
    {
        KetNoiSQL.NhaCungCap nhacungcap = new KetNoiSQL.NhaCungCap();
        FormGiaoDien.Form_NhaCungCap frm_nhacungcap;
        FormGiaoDien.Form_HangHoa frm_hanghoa;

        public TP_NhaCungCap(FormGiaoDien.Form_HangHoa hh)
        {
            frm_hanghoa = hh;

        }
        public TP_NhaCungCap(FormGiaoDien.Form_NhaCungCap ncc)
        {
            frm_nhacungcap = ncc;
        }

        public void Themncc()
        {
            int ketqua = nhacungcap.Themncc(frm_nhacungcap.txt_mancc.Text, frm_nhacungcap.txt_tenncc.Text);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");

        }

        public void Suancc()
        {
            int ketqua = nhacungcap.Suancc(frm_nhacungcap.txt_mancc.Text, frm_nhacungcap.txt_tenncc.Text);
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
        }

        public void Xoancc()
        {
            int ketqua = nhacungcap.Xoancc(frm_nhacungcap.txt_mancc.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
        }

        public void Loadncc()
        {
            frm_nhacungcap.dtv_nhacungcap.DataSource = nhacungcap.Loadncc();
        }

        public void LayDSNCC()
        {
            frm_hanghoa.cb_ncc.DataSource = nhacungcap.Loadncc();
            frm_hanghoa.cb_ncc.DisplayMember = "TENNCC";
            frm_hanghoa.cb_ncc.ValueMember = "MANCC";
        }
    }
}
