using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangBanMayTinh.KetNoiSQL
{
    class NhanVien
    {
        LopDungChung lopchung = new LopDungChung();

        public int themNV(string manv, string tennv, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string sql = "INSERT INTO NHANVIEN VALUES(N'" + manv + "',N'" + tennv + "',N'" + ngaysinh.ToString() + "',N'" + gioitinh + "',N'" + diachi + "',N'" + sdt + "')";
            return lopchung.ThemXoaSua(sql);
        }

        public int suaNV(string manv, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string sql = "UPDATE NHANVIEN SET TENNV =N'" + hoten + "',NGAYSINH =N'" + ngaysinh.ToString() + "',GIOITINH =N'" + gioitinh + "',DIACHI =N'" + diachi + "',SDT =N'" + sdt + "'where MANV = '" + manv + "'";
            return lopchung.ThemXoaSua(sql);
        }

        public int xoaNV(string manv)
        {
            string sql = "DELETE NHANVIEN WHERE MANV = N'" + manv + "'";
            return lopchung.ThemXoaSua(sql);
        }

        public DataTable loadNhanVien()
        {
            string sql = "SELECT * FROM NHANVIEN";
            return lopchung.LoadDuLieu(sql);
        }
    }
}
