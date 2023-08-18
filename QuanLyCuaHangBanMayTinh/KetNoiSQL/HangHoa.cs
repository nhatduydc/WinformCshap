using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanMayTinh.KetNoiSQL
{
    class HangHoa
    {
        LopDungChung lopchung = new LopDungChung();

        public int Themhang(string mahh, string mancc, string tenhang, string soluong, string dongianhap, string dongiaban)
        {
            string sql = "Insert into HANGHOA values(N'" + mahh + "',N'" + mancc + "',N'" + tenhang + "',N'" + soluong + "',N'" + dongianhap + "',N'" + dongiaban + "')";
            return lopchung.ThemXoaSua(sql);
        }

        public int Suahang(string mahh, string mancc, string tenhang, string soluong, string dongianhap, string dongiaban)
        {
            string sql = "Update HANGHOA set TENHANG =N'" + tenhang + "',SOLUONG =N'" + soluong + "',DONGIANHAP =N'" + dongianhap + "',DONGIABAN =N'" + dongiaban + "',MANCC =N'" + mancc + "'where MAHH = '" + mahh + "'";
            return lopchung.ThemXoaSua(sql);
        }

        public int Xoahang(string mahh)
        {
            string sql = "Delete HANGHOA where MAHH = N'" + mahh + "'";
            return lopchung.ThemXoaSua(sql);
        }

        public DataTable Loadhh()
        {
            string sql = "Select * from HANGHOA";
            return lopchung.LoadDuLieu(sql);
        }
    }
}
