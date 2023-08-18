using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanMayTinh.KetNoiSQL
{
    class KhachHang
    {
        LopDungChung lopchung = new LopDungChung();

        public int ThemKH(string makh, string tenkh, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string sql = "Insert into KHACHHANG values(N'" + makh + "',N'" + tenkh + "',N'" + ngaysinh.ToString() + "',N'" + gioitinh + "',N'" + diachi + "',N'" + sdt + "')";
            return lopchung.ThemXoaSua(sql);
        }

        public int Suakh(string makh, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string sql = "Update KHACHHANG set TENKH =N'" + hoten + "',NGAYSINH =N'" + ngaysinh.ToString() + "',GIOITINH =N'" + gioitinh + "',DIACHI =N'" + diachi + "',SDT =N'" + sdt + "'where MAKH = '" + makh + "'";
            return lopchung.ThemXoaSua(sql);
        }

        public int Xoakh(string makh)
        {
            string sql = "Delete KHACHHANG where MAKH = N'" + makh + "'";
            return lopchung.ThemXoaSua(sql);

        }

        public DataTable Loadkh()
        {
            string sql = "Select * from KHACHHANG";
            return lopchung.LoadDuLieu(sql);

        }
    }
}
